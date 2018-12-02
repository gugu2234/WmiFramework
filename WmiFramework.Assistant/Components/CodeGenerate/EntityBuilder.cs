using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Models;

namespace WmiFramework.Assistant.Components.CodeGenerate
{
    class EntityBuilder
    {
        private string namespaces;
        private string savePath;

        public EntityBuilder(string savePath, string namespaces)
        {
            this.namespaces = namespaces;
            this.savePath = savePath;
        }

        /// <summary>
        /// 生成实体并保存
        /// </summary>
        /// <param name="classes"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Generate(Classes classes, string name)
        {
            var codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("using System;");
            codeBuilder.AppendLine("using WMIAccess;");
            codeBuilder.AppendLine($"namespace {namespaces}.Entites");
            codeBuilder.AppendLine("{");
            if (!string.IsNullOrEmpty(classes.Description))
            {
                codeBuilder.AppendLine("    /// <summary>");
                codeBuilder.AppendLine($"    /// {classes.Description.Replace("\n", "\r\n    /// ")}");
                codeBuilder.AppendLine("    /// </summary>");
            }
            codeBuilder.AppendLine($"   [Classes(\"{classes.Name}\", @\"{classes.Namespace}\")]");
            codeBuilder.AppendLine($"    public class {name} : EntityBase");
            codeBuilder.AppendLine("    {");
            foreach (var item in classes.Properties)
            {
                if (!string.IsNullOrEmpty(item.Description))
                {
                    codeBuilder.AppendLine("       /// <summary>");
                    codeBuilder.AppendLine($"       /// {item.Description.Replace("\n", "\r\n       /// ")}");
                    codeBuilder.AppendLine("       /// </summary>");
                }
                if (item.IsArray)
                    codeBuilder.AppendLine($"       public {GetTypeText(item.Type)}[] {item.Name} {{ get; set; }}");
                else
                    codeBuilder.AppendLine($"       public {GetTypeText(item.Type)} {item.Name} {{ get; set; }}");
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

        private string GetTypeText(CimType type)
        {
            switch (type)
            {
                case CimType.Boolean:
                    return "bool";
                case CimType.Char16:
                    return "char";
                case CimType.DateTime:
                    return "DateTime";
                case CimType.None:
                    return null;
                case CimType.Object:
                    return "object";
                case CimType.Real32:
                    return "float";
                case CimType.Real64:
                    return "double";
                case CimType.Reference:
                    return "short";
                case CimType.SInt16:
                    return "short";
                case CimType.SInt32:
                    return "int";
                case CimType.SInt64:
                    return "long";
                case CimType.SInt8:
                    return "sbyte";
                case CimType.String:
                    return "string";
                case CimType.UInt16:
                    return "ushort";
                case CimType.UInt32:
                    return "uint";
                case CimType.UInt64:
                    return "ulong";
                case CimType.UInt8:
                    return "byte";
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
