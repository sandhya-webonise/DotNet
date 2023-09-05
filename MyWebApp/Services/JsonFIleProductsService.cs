using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MyWebApp.Models;
using Microsoft.AspNetCore.Hosting;

namespace MyWebApp.Services
{
    public class JsonFileProductsService
    {
        public JsonFileProductsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");

        public IEnumerable<Product> GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            var products = JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            // Handle the case where products is null (e.g., JSON file is empty or invalid)
            if (products == null)
            {
                // You can choose to return an empty list or throw an exception, depending on your requirements.
                // For example, to return an empty list:
                return Enumerable.Empty<Product>();

                // Or, to throw an exception:
                // throw new InvalidOperationException("Failed to deserialize products from JSON.");
            }

            return products;
        }
        public void AddRating(string productId, int rating)
        {
            var products = GetProducts();
            // LINQ
            var query = products.First(x => x.Id == productId);
            if (query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }
            else
            {
                var ratings = query.Ratings.ToList();
                ratings.Add(rating);
                query.Ratings = ratings.ToArray();
            }
            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products
                );
            }
        }

    }
}