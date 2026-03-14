namespace ProductCatalog.Models
{
    public class SensorReading
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public double Temperature { get; set; }   // °C (can be negative)

        public double Pressure { get; set; }      // kPa

        public double Humidity { get; set; }      // %

        public double Voltage { get; set; }       // volts
    }
}
