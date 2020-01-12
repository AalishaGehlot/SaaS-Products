using SaasProducts.Managers;
using SaasProducts.Models;
using System.Collections.Generic;
using Xunit;

namespace SaasProducts.Test.Tests
{
    public class ProductManagerTest
    {
        /// <summary>
        /// Handles the capterra products test.
        /// </summary>
        [Fact]
        public void HandleCapterraProductsTest()
        {
            ProductManager productManager = new ProductManager();
            string filePath = "../../../../saasproducts/wwwroot/feed-products/capterra.yaml";

            //Act
            List<CapterraModel> result = productManager.HandleCapterraProducts(filePath);

            //Assert
            Assert.NotEmpty(result);
            Assert.IsType<List<CapterraModel>>(result);
        }

        /// <summary>
        /// Handles the software advice products test.
        /// </summary>
        [Fact]
        public void HandleSoftwareAdviceProductsTest()
        {
            ProductManager productManager = new ProductManager();
            string filePath = "../../../../saasproducts/wwwroot/feed-products/softwareadvice.json";

            //Act
            List<SoftwareAdviceModel> result = productManager.HandleSoftwareAdviceProducts(filePath);

            //Assert
            Assert.NotEmpty(result);
            Assert.IsType<List<SoftwareAdviceModel>>(result);
        }
    }
}
