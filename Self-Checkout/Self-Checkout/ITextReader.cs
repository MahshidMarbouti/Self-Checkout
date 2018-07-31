using System;
using System.Collections.Generic;
using System.IO;

namespace SelfCheckout
{
    /// <summary>
    /// Provides a collection of line for a given file.
    /// </summary>
    public interface ITextReader
    {
        /// <summary>
        /// Read the specified path.
        /// </summary>
        /// <returns>The list of lines</returns>
        /// <param name="path">Path of the file to read.</param>
        IEnumerable<string> Read(string path);
    }

   
 
}
