using System;
using Xunit;
using SelfCheckout;

namespace SelfCheckoutTests
{
    public class ProductParserTest
    {
        [Fact]
        public void ParseLine_ShouldParseLineIntoProductCorrectly()
        {
            //Arrange
            const string sampleProductLine = "1,Fruits,2,Banana";
            var productParser = new ProductParser();

            //Act
            var product = productParser.ParseLine(sampleProductLine);

            //Assert
            Assert.NotNull(product);
            Assert.Equal(1, product.Id);
            Assert.Equal("Fruits", product.Type.Name);
            Assert.Equal("Banana", product.Name);
            Assert.Equal(2, product.Price);
            }
    }
}
