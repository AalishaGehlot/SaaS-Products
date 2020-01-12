using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YamlDotNet.Serialization;
using SaasProducts.Models;

namespace SaasProducts.Managers
{
    public class ProductManager
    {
        /// <summary>
        /// Method to handle software advice products which is in json format.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public List<SoftwareAdviceModel> HandleSoftwareAdviceProducts(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                string reader = file.ReadToEnd();
                List<JToken> content = JObject.Parse(reader).Children().ToList();
                List<JToken> productsData = content.Children().Children().ToList();
                string serializeObject = JsonConvert.SerializeObject(productsData);
                List<SoftwareAdviceModel> result = JsonConvert.DeserializeObject<List<SoftwareAdviceModel>>(serializeObject);

                foreach (var data in result)
                {
                    System.Diagnostics.Debug.WriteLine($"importing: Name: {data.title}; Categories: {data.catecategories}; Twitter: {data.twitter}");
                }

                return result;
            }
        }

        /// <summary>
        /// Method to handle capterra file product which is in yaml format.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<CapterraModel> HandleCapterraProducts(string filePath)
        {
            List<CapterraModel> yamlContent = new List<CapterraModel>();
            using (var reader = File.OpenText(filePath))
            {
                Deserializer deserializer = new Deserializer();
                yamlContent = deserializer.Deserialize<List<CapterraModel>>(reader);
            }

            foreach (var row in yamlContent)
            {
                System.Diagnostics.Debug.WriteLine($"importing: Name: {row.name}; Categories: {row.tags}; Twitter: {row.twitter}");
            }

            return yamlContent;
        }
    }
}
