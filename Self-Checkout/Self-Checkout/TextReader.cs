using System;
using System.Collections.Generic;
using System.IO;

namespace SelfCheckout
{
    /// <inheritdoc />
    public class TextReader : ITextReader
    {
        /// <inheritdoc />
        public IEnumerable<string> Read(string path)
        {
            return File.ReadLines(path);
        }
    }
}
