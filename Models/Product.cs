namespace ProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = ""; // map from 'title'
        public string Category { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Thumbnail { get; set; } = ""; // Add the Thumbnail property
    }

    // For deserializing the DummyJSON response
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
        public string thumbnail { get; set; } = ""; // Add the Thumbnail field
    }
}
