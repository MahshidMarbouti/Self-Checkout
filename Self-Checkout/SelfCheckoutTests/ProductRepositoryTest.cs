using System;
using Xunit;
using SelfCheckout;
using System.Collections.Generic;
using Self_Checkout.DataLayer;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Interfaces;

namespace SelfCheckoutTests
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void FindByID_ShouldReturnProductWhenGiveID()
        {
            //Arrange
            var textReader = new FakeTextReader();
            var productParser = new ProductParser();
            var parser = new ProductRepository(textReader, productParser);

            //Act
            var foundProduct = parser.FindById(1);

            //Assert
            Assert.Equal(1, foundProduct.Id);
            Assert.Equal("Banana", foundProduct.Name);
        }

        //Dummy class to simulate text reader behaviour.
        private class FakeTextReader : ITextReader
        {
            public IEnumerable<string> Read(string path)
            {
                var listToReturn = new List<string>();
                listToReturn.Add("1,Fruits,2,Banana");
                listToReturn.Add("2,Tool,10,Vaccum");
                listToReturn.Add("3,Grocery,1,Lettuce");
                listToReturn.Add("4,Fruits,4,Strawberry");
                return listToReturn;
            }
        }
    }

}
