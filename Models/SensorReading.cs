namespace ProductCatalog.Models
{
    public class SensorReading
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        // Tag name (e.g. "Temperature", "Pressure", ...)
        public string Tag { get; set; } = string.Empty;

        // Numeric value for the tag at the given time
        public double Value { get; set; }
    }
}
