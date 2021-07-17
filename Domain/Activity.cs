using System;

namespace Domain
{
    public class Activity
    {   
        // Id is assumed to be the primary key for the database by entity framework
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public string City { get; set; }
        public string Venue { get; set; }
    }
}