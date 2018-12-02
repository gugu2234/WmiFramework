using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.Components.CodeGenerate
{
    class ServiceBuilder
    {
        private string namespaces;
        private string savePath;
        private bool isBuildMethod;

        public ServiceBuilder(string savePath, string namespaces, bool isBuildMethod)
        {
            this.namespaces = namespaces;
            this.savePath = savePath;
            this.isBuildMethod = isBuildMethod;
        }

        public string Generate(Classes classes, string entity, string name)
        {
            var codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("using System;");
            codeBuilder.AppendLine("using System.Management;");
            codeBuilder.AppendLine("using WMIAccess;");
            codeBuilder.AppendLine($"namespace {namespaces}.Services");
            codeBuilder.AppendLine("{");

            if (!string.IsNullOrEmpty(classes.Description))
            {
                codeBuilder.AppendLine("    /// <summary>");
                codeBuilder.AppendLine($"    /// {classes.Description.Replace("\n", "\r\n    /// ")}");
                codeBuilder.AppendLine("    /// </summary>");
            }

            codeBuilder.AppendLine($"    public class {name} : WMIService<Entites.{entity}>");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        public {name}(ConnectionOptions options, string address) : base(options, address) {{ }}");

            if (isBuildMethod)
            {
                foreach (var method in classes.Methods)
                {
                    GenerateMethod(codeBuilder, method, entity);
                }
            }

            codeBuilder.AppendLine("    }");
            codeBuilder.AppendLine("}");

            var filePath = Path.Combine(savePath, $"{name}.cs");
            using (var stream = File.Create(filePath))
            {
                var codeText = codeBuilder.ToString();
                var buffer = Encoding.UTF8.GetBytes(codeText);
                stream.Write(buffer, 0, buffer.Length);
            }

            return filePath;
        }

        private string GetTypeText(CimType type, bool isArray)
        {
            string res = string.Empty;
            switch (type)
            {
                case CimType.Boolean:
                    res = "bool";
                    break;
                case CimType.Char16:
                    res = "char";
                    break;
                case CimType.DateTime:
                    res = "DateTime";
                    break;
                case CimType.None:
                    res = null;
                    break;
                case CimType.Object:
                    res = "object";
                    break;
                case CimType.Real32:
                    res = "float";
                    break;
                case CimType.Real64:
                    res = "double";
                    break;
                case CimType.Reference:
                    res = "short";
                    break;
                case CimType.SInt16:
                    res = "short";
                    break;
                case CimType.SInt32:
                    res = "int";
                    break;
                case CimType.SInt64:
                    res = "long";
                    break;
                case CimType.SInt8:
                    res = "sbyte";
                    break;
                case CimType.String:
                    res = "string";
                    break;
                case CimType.UInt16:
                    res = "ushort";
                    break;
                case CimType.UInt32:
                    res = "uint";
                    break;
                case CimType.UInt64:
                    res = "ulong";
                    break;
                case CimType.UInt8:
                    res = "byte";
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return isArray ? $"{res}[]" : res;
        }

        private void GenerateMethod(StringBuilder codeBuilder, Method method, string entity)
        {
            string returnType = "void";
            if (method.OutParameters.Length == 1 && !method.InParameters.Any(c => c.Name.Equals(method.OutParameters[0].Name)))
                returnType = GetTypeText(method.OutParameters[0].Type, method.OutParameters[0].IsArray);

            var inParams = method.InParameters.Where(c => !method.OutParameters.Any(j => j.Name.Equals(c.Name))).ToArray();
            var outParams = method.OutParameters.Where(c => !method.InParameters.Any(j => j.Name.Equals(c.Name))).ToArray();
            var refParams = method.InParameters.Join(method.OutParameters, c => c.Name, c => c.Name, (i, j) => i).ToArray();

            var inParamsText = string.Join(", ", inParams.Select(c => $"{GetTypeText(c.Type, c.IsArray)} {c.Name}").ToArray());
            var outParamsText = string.Empty;
            if (method.OutParameters.Length > 1 || (method.OutParameters.Length == 1 && method.InParameters.Any(c => c.Name.Equals(method.OutParameters[0].Name))))
                outParamsText = string.Join(", ", outParams.Select(c => $"out {GetTypeText(c.Type, c.IsArray)} {c.Name}").ToArray());
            var refParamsText = string.Join(", ", refParams.Select(c => $"ref {GetTypeText(c.Type, c.IsArray)} {c.Name}").ToArray());
            string paramsText = string.Join(", ", new string[] { inParamsText, outParamsText, refParamsText }.Where(c => !string.IsNullOrEmpty(c)).ToArray());

            //生成静态类方法
            //生成方法注释
            codeBuilder.AppendLine("        /// <summary>");
            codeBuilder.AppendLine($"        /// {method.Description.Replace("\n", "\r\n        /// ")}");
            codeBuilder.AppendLine("        /// </summary>");
            foreach (var item in inParams)
                codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            if (!string.IsNullOrEmpty(outParamsText))
            {
                foreach (var item in outParams)
                    codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            }
            foreach (var item in refParams)
                codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            if (string.IsNullOrEmpty(outParamsText))
                codeBuilder.AppendLine($"        /// <returns>{method.OutParameters[0].Description.Replace("\n", "\r\n        /// ")}</returns>");

            //生成方法主体
            codeBuilder.AppendLine($"        public {returnType} {method.Name}({paramsText})");
            codeBuilder.AppendLine("        {");
            codeBuilder.AppendLine("            using (var classObj = GetClass())");
            codeBuilder.AppendLine("            {");
            codeBuilder.AppendLine($"                var inParams = classObj.GetMethodParameters(\"{method.Name}\");");

            foreach (var item in method.InParameters)
                codeBuilder.AppendLine($"                inParams[\"{item.Name}\"] = NetValueToWmi(CimType.{item.Type.ToString()}, {item.Name});");

            codeBuilder.AppendLine($"                var output = classObj.InvokeMethod(\"{method.Name}\", inParams, null);");

            if (!string.IsNullOrEmpty(outParamsText))
            {
                foreach (var item in method.OutParameters)
                    codeBuilder.AppendLine($"                {item.Name} = ({GetTypeText(item.Type, item.IsArray)})output[\"{item.Name}\"];");
            }
            else if (method.OutParameters.Length == 1)
            {
                codeBuilder.AppendLine($"                return ({GetTypeText(method.OutParameters[0].Type, method.OutParameters[0].IsArray)})WmiValueToNet(CimType.{method.OutParameters[0].Type.ToString()}, output[\"{method.OutParameters[0].Name}\"]);");
            }
            codeBuilder.AppendLine("            }");
            codeBuilder.AppendLine("        }");

            //生成动态类方法
            //生成方法注释
            codeBuilder.AppendLine("        /// <summary>");
            codeBuilder.AppendLine($"        /// {method.Description.Replace("\n", "\r\n        /// ")}");
            codeBuilder.AppendLine("        /// </summary>");
            foreach (var item in inParams)
                codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            if (!string.IsNullOrEmpty(outParamsText))
            {
                foreach (var item in outParams)
                    codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            }
            foreach (var item in refParams)
                codeBuilder.AppendLine($"        /// <param name=\"{item.Name}\">{item.Description.Replace("\n", "\r\n        /// ")}</param>");
            if (string.IsNullOrEmpty(outParamsText))
                codeBuilder.AppendLine($"        /// <returns>{method.OutParameters[0].Description.Replace("\n", "\r\n        /// ")}</returns>");

            //生成方法主体
            codeBuilder.AppendLine($"        public {returnType} {method.Name}(Entites.{entity} entity{(string.IsNullOrEmpty(paramsText) ? string.Empty : ", " + paramsText)})");
            codeBuilder.AppendLine("        {");
            codeBuilder.AppendLine("            var classObj = GetEntityWmiObjecj(entity);");
            codeBuilder.AppendLine($"            var inParams = classObj.GetMethodParameters(\"{method.Name}\");");

            foreach (var item in method.InParameters)
                codeBuilder.AppendLine($"            inParams[\"{item.Name}\"] = NetValueToWmi(CimType.{item.Type.ToString()}, {item.Name});");

            codeBuilder.AppendLine($"            var output = classObj.InvokeMethod(\"{method.Name}\", inParams, null);");

            if (!string.IsNullOrEmpty(outParamsText))
            {
                foreach (var item in method.OutParameters)
                    codeBuilder.AppendLine($"            {item.Name} = ({GetTypeText(item.Type, item.IsArray)})output[\"{item.Name}\"];");
            }
            else if (method.OutParameters.Length == 1)
            {
                codeBuilder.AppendLine($"            return ({GetTypeText(method.OutParameters[0].Type, method.OutParameters[0].IsArray)})WmiValueToNet(CimType.{method.OutParameters[0].Type.ToString()}, output[\"{method.OutParameters[0].Name}\"]);");
            }
            codeBuilder.AppendLine("        }");
        }
    }
}
