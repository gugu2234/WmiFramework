using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WmiFramework.Assistant.Components.CodeGenerate
{
    class CodeCompiler
    {
        private string namespaces;
        private string savePath;

        public CodeCompiler(string savePath, string namespaces)
        {
            this.namespaces = namespaces;
            this.savePath = savePath;
        }

        public string Build(string[] sources, string name)
        {
            //CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();
            //ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();
            CompilerParameters cplist = new CompilerParameters();
            cplist.GenerateExecutable = false;
            cplist.GenerateInMemory = false;
            cplist.OutputAssembly = Path.Combine(savePath, $"{name}.dll");
            cplist.ReferencedAssemblies.Add("System.dll");
            cplist.ReferencedAssemblies.Add("System.XML.dll");
            cplist.ReferencedAssemblies.Add("System.Data.dll");
            cplist.ReferencedAssemblies.Add("System.Core.dll");
            cplist.ReferencedAssemblies.Add("System.Management.dll");
            cplist.ReferencedAssemblies.Add("WMIAccess.dll");

            // 编译代理类，C# CSharp都可以
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            

            CompilerResults cr = provider.CompileAssemblyFromFile(cplist, sources);
            //cr.Errors
            return string.Join("\r\n", cr.Output.Cast<string>().ToArray());
        }
    }
}
