namespace EventEaseApp.Services
{
    public class Tracker
    {
        private readonly List<string> attendees = new(); // List to hold registered attendees.

        // Method to register an attendee.
        public void RegisterAttendee(string attendeeName)
        {
            // Check if the name is valid and not already added.
            if (!attendees.Contains(attendeeName) && !string.IsNullOrWhiteSpace(attendeeName))
            {
                attendees.Add(attendeeName);
            }
        }

        // Method to get the list of attendees.
        public List<string> GetAttendees()
        {
            return attendees; // Return the list of registered attendees.
        }
    }
}
