using System;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using Mono.Cecil;

namespace Arts.DisAssembler
{
    public class ILDisAssembler
    {
        public  void DecompileAsProject(string assemblyFileName, string outputDirectory)
        {
            ModuleDefinition module = UniversalAssemblyResolver.LoadMainModule(assemblyFileName);
            WholeProjectDecompiler decompiler = new WholeProjectDecompiler();
            decompiler.DecompileProject(module, outputDirectory);
        }
    }
}
