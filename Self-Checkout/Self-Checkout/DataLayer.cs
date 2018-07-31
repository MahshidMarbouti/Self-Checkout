using System;
using System.IO;
namespace Self_Checkout
{
    public class DataLayer //TD rename
    {
        public DataLayer()
        {
        }
        public Product FindProduct(int ID)
        {
            foreach (string line in File.ReadLines("\\Users\\Mahshid\\Self-Checkout\\Self-Checkout\\Self-Checkout\\Products.txt"))
            {
                string[] items = line.Split(',');
                if (Convert.ToInt32(items[0]) == ID)
                {
                    ProductType pr_type = new ProductType(items[1]);
                    Product found_product = new Product(ID, pr_type, Convert.ToInt32(items[2]), items[3]);
                    return found_product;
                }

            }
            return null; 
        }
    }
}
