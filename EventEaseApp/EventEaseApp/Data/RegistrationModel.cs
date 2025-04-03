namespace EventEaseApp.Data
{
    using System.ComponentModel.DataAnnotations;

    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public int? SelectedEventId { get; set; }
    }

}
