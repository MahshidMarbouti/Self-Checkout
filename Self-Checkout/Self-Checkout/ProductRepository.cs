using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace SelfCheckout
{
    /// <summary>
    /// Product repository.
    /// </summary>
    public class ProductRepository 
    {
        private ITextReader _textReader;

        public ProductRepository(ITextReader textReader)
        {
            _textReader = textReader;
        }

        /// <summary>
        /// Finds the product.
        /// </summary>
        /// <returns>The product.</returns>
        /// <param name="id">The product identifier.</param>
        public Product FindById(int id)
        {
            var path = "\\Users\\Mahshid\\Self-Checkout\\Self-Checkout\\Self-Checkout\\Products.txt";
            var linesOfProduct = _textReader.Read(path);
            var products = new List<Product>();
            foreach(var line in linesOfProduct)
            {
                var items = line.Split(',');
                var product = new Product(id, new ProductType(items[1]), Convert.ToInt32(items[2]), items[3]);
                products.Add(product);

            }
            return products.SingleOrDefault(x => x.Id == id);
        }
    }
}
