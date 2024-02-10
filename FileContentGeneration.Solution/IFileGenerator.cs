using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentGeneration.Solution
{
    /// <summary>
    /// Represents a file generator.
    /// </summary>
    public interface IFileGenerator
    {
        /// <summary>
        /// Gets the working directory for file generation.
        /// </summary>
        string WorkingDirectory { get; }

        /// <summary>
        /// Gets the file extension for generated files.
        /// </summary>
        string FileExtension { get; }

        /// <summary>
        /// Generates the specified number of files with the given content length.
        /// </summary>
        /// <param name="filesCount">The number of files to generate.</param>
        /// <param name="contentLength">The length of the content for each file.</param>
        void GenerateFiles(int filesCount, int contentLength);
    }
}
