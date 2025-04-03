namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; }
        public bool IsRegistered { get; private set; }

        public void StartSession(string name)
        {
            UserName = name;
            IsRegistered = true;
        }

        public void EndSession()
        {
            UserName = string.Empty;
            IsRegistered = false;
        }
    }
}
