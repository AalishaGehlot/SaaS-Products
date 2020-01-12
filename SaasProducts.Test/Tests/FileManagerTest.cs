using SaasProducts.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using SaasProducts.Managers;
using Xunit;

namespace SaasProducts.Test.Controller
{
    public class FileManagerTest
    {
        [Fact]
        public void GetFilesByPathTest()
        {
            string path = "../../../../saasproducts/wwwroot/feed-products";
            var fileManager = new FileManager(new ProductManager());

            //Act
            string[] files = fileManager.GetFilesByPath(path);

            //Assert
            Assert.NotEmpty(files);
            Assert.IsType<string[]>(files);
        }
    }
}
