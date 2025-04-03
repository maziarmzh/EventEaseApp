namespace EventEaseApp.Services
{
    using EventEaseApp.Data;
    using System.Collections.Generic;

    public class RegistrationService
    {
        private readonly List<RegistrationModel> registrations = new();

        public void Register(RegistrationModel registration)
        {
            registrations.Add(registration);
        }

        public List<RegistrationModel> GetRegistrations()
        {
            return registrations;
        }

    }



}
