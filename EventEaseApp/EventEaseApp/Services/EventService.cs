using EventEaseApp.Data;

namespace EventEaseApp.Services
{

    public class EventService
    {
        public List<EventModel> GetEvents()
        {
            return new List<EventModel>
        {
            new EventModel { Id = 1, Name = "Tech Conference", Date = "2025-04-10", Location = "San Francisco" },
            new EventModel { Id = 2, Name = "Music Festival", Date = "2025-05-20", Location = "Austin" },
            new EventModel { Id = 3, Name = "Art Expo", Date = "2025-06-15", Location = "New York" },
            new EventModel { Id = 4, Name = "Book Fair", Date = "2025-07-10", Location = "Seattle" },
            new EventModel { Id = 5, Name = "Gaming Expo", Date = "2025-08-12", Location = "Chicago" },
            new EventModel { Id = 6, Name = "Startup Summit", Date = "2025-09-15", Location = "Boston" },
            new EventModel { Id = 7, Name = "Film Festival", Date = "2025-10-20", Location = "Los Angeles" },
            new EventModel { Id = 8, Name = "Fashion Week", Date = "2025-11-05", Location = "Paris" },
            new EventModel { Id = 9, Name = "Food Carnival", Date = "2025-12-01", Location = "Miami" },
            new EventModel { Id = 10, Name = "Science Symposium", Date = "2026-01-15", Location = "Houston" },
            new EventModel { Id = 11, Name = "Robotics Workshop", Date = "2026-02-10", Location = "San Diego" },
            new EventModel { Id = 12, Name = "Art Gala", Date = "2026-03-25", Location = "Atlanta" },
            new EventModel { Id = 13, Name = "Music Awards", Date = "2026-04-05", Location = "Las Vegas" }
        };
        }
    }
}
