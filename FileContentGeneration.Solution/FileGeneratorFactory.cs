using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentGeneration.Solution
{
    /// <summary>
    /// Factory class for creating file generators.
    /// </summary>
    public static class FileGeneratorFactory
    {
        /// <summary>
        /// Creates a file generator based on the specified type.
        /// </summary>
        /// <param name="type">The type of file generator to create.</param>
        /// <returns>An instance of the file generator.</returns>
        public static IFileGenerator CreateFileGenerator(string type)
        {
            return type switch
            {
                "bytes" => new RandomBytesFileGenerator(),
                "chars" => new RandomCharsFileGenerator(),
                _ => throw new ArgumentException("Invalid type", nameof(type)),
            };
        }
    }
}
