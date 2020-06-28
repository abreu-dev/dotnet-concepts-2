using Haze.Core.Domain.Events;

namespace Haze.Authentication.Domain.Events.UserEvents
{
    public class LoginFailedAttemptEvent : Event
    {
        public string Username { get; set; }

        public LoginFailedAttemptEvent(string username)
        {
            Username = username;
        }
    }
}
