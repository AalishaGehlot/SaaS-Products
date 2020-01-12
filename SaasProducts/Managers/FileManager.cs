using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SaasProducts.Managers
{
    public class FileManager
    {
        public ProductManager productManager;

        public FileManager(ProductManager _productManager)
        {
            productManager = _productManager;
        }

        /// <summary>
        /// Gets the files bu path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public string[] GetFilesByPath(string filePath)
        {
            string[] files = Directory.GetFiles(filePath);
            return files;
        }

        /// <summary>
        /// Method to handles the content of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="fineName">Name of the fine.</param>
        public void HandleFileContent(string filePath, string fineName)
        {
            switch (fineName)
            {
                case "softwareadvice.json":
                    System.Diagnostics.Debug.WriteLine($"$ import {fineName} {filePath}");
                    productManager.HandleSoftwareAdviceProducts(filePath);
                    break;
                case "capterra.yaml":
                    System.Diagnostics.Debug.WriteLine($"$ import {fineName} {filePath}");
                    productManager.HandleCapterraProducts(filePath);
                    break;
            }
        }
    }
}
