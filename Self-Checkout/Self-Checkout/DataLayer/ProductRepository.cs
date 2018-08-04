using System.Collections.Generic;
using System.Linq;
using SelfCheckout;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Models.Product;

namespace Self_Checkout.DataLayer
{
    /// <summary>
    /// Product repository.
    /// </summary>
    public class ProductRepository 
    {
        private ITextReader _textReader;
        private IProductParser _productParser;
        private const string PATH_TO_READ = "SampleData/Products.txt";

        public ProductRepository(ITextReader textReader, IProductParser productParser)
        {
            _textReader = textReader;
            _productParser = productParser;
        }

        /// <summary>
        /// Finds the product.
        /// </summary>
        /// <returns>The product.</returns>
        /// <param name="id">The product identifier.</param>
        public Product FindById(int id)
        {
           
            var linesOfProduct = _textReader.Read(PATH_TO_READ);
            var products = new List<Product>();
            foreach(var line in linesOfProduct)
            {
                Product product = _productParser.ParseLine(line);
                products.Add(product);

            }
            return products.SingleOrDefault(x => x.Id == id);
        }

    }
}
