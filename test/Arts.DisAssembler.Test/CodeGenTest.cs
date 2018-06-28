using System;
using System.IO;

using Xunit;

namespace Arts.DisAssembler.Test
{
    public class CodeGenTest
    {
        [Theory]
        [InlineData(@"..\..\..\testAssembly\CsharpConsoleApp.dll", @"..\..\..\..\outputCode\csProj")]
        [InlineData(@"..\..\..\testAssembly\VBConsoleApp.dll", @"..\..\..\..\outputCode\vbProj")]
        [InlineData(@"..\..\..\testAssembly\VBConsoleApp20.exe", @"..\..\..\..\outputCode\vbProj20")]
        public void GenerateCodeFromAssembly(string assemblyfileName, string outputDir )
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);
            Directory.CreateDirectory(outputDir);
            ILDisAssembler iLDisAssembler = new ILDisAssembler();
            iLDisAssembler.DecompileAsProject(assemblyfileName, outputDir);
           
        }
    }
}
