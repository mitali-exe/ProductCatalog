namespace ProductCatalog.Models
{
    public class SalesReport2
    {
        public int Id { get; set; }

        public string Months { get; set; }
        public DateTime CreatedAt { get; set; }  

        public double Sales { get; set; }
        public double Revenue { get; set; }
        public double Profit { get; set; }
    }
}
