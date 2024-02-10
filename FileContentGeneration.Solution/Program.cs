using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentGeneration.Solution
{
    /// <summary>
    /// The main program class.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        static void Main()
        {
            var fileGeneratorType = "chars";
            var fileGenerator = FileGeneratorFactory.CreateFileGenerator(fileGeneratorType);
            fileGenerator.GenerateFiles(5, 100);
        }
    }
}
