using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    //public DbSet<SalesReport> SalesReports { get; set; }

    public DbSet<SalesReport2> SalesReports2 { get; set; }

    public DbSet<SensorReading> SensorReadings { get; set; }
}