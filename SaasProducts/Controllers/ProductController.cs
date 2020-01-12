using System;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using SaasProducts.Managers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaasProducts.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager productManager;
        private FileManager fileManager;
        private const string ProductFilesPath = "wwwroot/feed-products";

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        public ProductController(ProductManager _productManager, FileManager _fileManager)
        {
            productManager = _productManager;
            fileManager = _fileManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets the products feed.
        /// </summary>
        /// <returns></returns>
        public IActionResult GetProductsFeed()
        {
            string[] files = fileManager.GetFilesByPath(ProductFilesPath);
            foreach (string filePath in files)
            {
                string fineName = Path.GetFileName(filePath);
                fileManager.HandleFileContent(filePath, fineName);
            }

            return View();
        }
    }
}
