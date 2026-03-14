using ProductCatalog.Models;
using System.Net.Http.Json;

namespace ProductCatalog.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        // Fetch simplified products (id, name, category, price, stock)
        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await _http.GetFromJsonAsync<DummyJsonResponse>("https://dummyjson.com/products?limit=0")
                           ?? new DummyJsonResponse();

            return response.products.Select(p => new Product
            {
                Id = p.id,
                Name = p.title,
                Category = p.category,
                Price = p.price,
                Stock = p.stock,
                Thumbnail = p.thumbnail
            }).ToList();
        }

        // Fetch raw response including images
        public async Task<DummyJsonResponse> GetRawDummyProductsAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<DummyJsonResponse>("https://dummyjson.com/products?limit=0")
                       ?? new DummyJsonResponse();
            }
            catch
            {
                return new DummyJsonResponse();
            }
        }
    }

    // Models for DummyJSON API
    public class DummyJsonResponse
    {
        public List<DummyProduct> products { get; set; } = new();
    }

    public class DummyProduct
    {
        public int id { get; set; }
        public string title { get; set; } = "";
        public string category { get; set; } = "";
        public decimal price { get; set; }
        public int stock { get; set; }
        public string thumbnail { get; set; } = "";
    }


}