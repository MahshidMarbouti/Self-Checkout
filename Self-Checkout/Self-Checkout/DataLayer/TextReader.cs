using System.Collections.Generic;
using System.IO;
using Self_Checkout.DataLayer.Interfaces;

namespace Self_Checkout.DataLayer
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
