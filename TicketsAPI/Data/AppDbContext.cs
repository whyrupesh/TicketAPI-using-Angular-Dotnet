using Microsoft.EntityFrameworkCore;
using TicketsAPI.Models;

namespace TicketsAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login Issue",
                    Description = "User cannot login with valid credentials.",
                    CreatedDate = new DateTime(2025, 12, 1, 10, 0, 0),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 12, 10),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 2,
                    ShortDescription = "UI Glitch",
                    Description = "Button overlaps with text on mobile view.",
                    CreatedDate = new DateTime(2025, 12, 5, 14, 30, 0),
                    Severity = "Low",
                    TargetDate = new DateTime(2025, 12, 20),
                    Status = "In Progress"
                },
                new Ticket
                {
                    Id = 3,
                    ShortDescription = "Data Export Fail",
                    Description = "Export to CSV returns 500 error.",
                    CreatedDate = new DateTime(2025, 12, 6, 9, 15, 0),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 12, 8),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 4,
                    ShortDescription = "Feature Request: Dark Mode",
                    Description = "Add dark mode support for better accessibility.",
                    CreatedDate = new DateTime(2025, 11, 20, 11, 0, 0),
                    Severity = "Medium",
                    TargetDate = new DateTime(2026, 1, 15),
                    Status = "New"
                }
            );
        }
    }
}
