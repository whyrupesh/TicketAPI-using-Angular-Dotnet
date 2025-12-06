using System;

namespace TicketsAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public required string ShortDescription { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public required string Severity { get; set; }
        public DateTime TargetDate { get; set; }
        public required string Status { get; set; }
    }
}
