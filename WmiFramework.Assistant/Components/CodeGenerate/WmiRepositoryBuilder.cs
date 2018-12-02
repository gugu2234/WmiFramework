using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WmiFramework.Assistant.Components.CodeGenerate
{
    class WmiRepositoryBuilder
    {
        private string namespaces;
        private string savePath;

        public WmiRepositoryBuilder(string savePath, string namespaces)
        {
            this.namespaces = namespaces;
            this.savePath = savePath;
        }

        public string Generate(string[] services)
        {
            var codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("using System;");
            codeBuilder.AppendLine("using System.Management;");
            codeBuilder.AppendLine("using WMIAccess;");
            codeBuilder.AppendLine($"using {namespaces}.Services;");
            codeBuilder.AppendLine($"namespace {namespaces}");
            codeBuilder.AppendLine("{");
            codeBuilder.AppendLine("    public class WmiRepository");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine("        private ConnectionOptions options;");
            codeBuilder.AppendLine("        private string address;");
            codeBuilder.AppendLine("        public WmiRepository() { }");
            codeBuilder.AppendLine("        public WmiRepository(ConnectionOptions options, string address) : this()");
            codeBuilder.AppendLine("        {");
            codeBuilder.AppendLine("            this.options = options;");
            codeBuilder.AppendLine("            this.address = address;");
            codeBuilder.AppendLine("        }");
            foreach (var item in services)
            {
                codeBuilder.AppendLine($"        private {item} m{item};");
                codeBuilder.AppendLine($"        public {item} {item}");
                codeBuilder.AppendLine("        {");
                codeBuilder.AppendLine("            get");
                codeBuilder.AppendLine("            {");
                codeBuilder.AppendLine($"                if(m{item} == null)");
                codeBuilder.AppendLine($"                    m{item} = new {item}(options, address);");
                codeBuilder.AppendLine($"                return m{item};");
                codeBuilder.AppendLine("            }");
                codeBuilder.AppendLine("        }");
            }
            codeBuilder.AppendLine("    }");
            codeBuilder.AppendLine("}");

            var filePath = Path.Combine(savePath, "WmiRepository.cs");
            using (var stream = File.Create(filePath))
            {
                var codeText = codeBuilder.ToString();
                var buffer = Encoding.UTF8.GetBytes(codeText);
                stream.Write(buffer, 0, buffer.Length);
            }

            return filePath;
        }
    }
}
