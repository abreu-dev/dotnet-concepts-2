using Haze.Authentication.Domain.Events.UserEvents;
using Haze.Authentication.Domain.Repositories;
using Haze.Core.Web.Services;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Haze.Authentication.Domain.EventHandler
{
    public class UserEventHandler:
        INotificationHandler<LoginFailedAttemptEvent>
    {
        private readonly IUserRepository _userRepository;

        public UserEventHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Handle(LoginFailedAttemptEvent notification, CancellationToken cancellationToken)
        {
            var user = _userRepository.Query().Where(c => c.Username == notification.Username).FirstOrDefault();

            if (user != null)
            {
                user.AddFailedAttempt();

                if ((user.FailedAttemptsInARow % 10) == 0)
                {
                    EmailService.SendMail(user.Email,
                                          "Haze - Login Failed Attempt",
                                          $"Hi {user.Username}! You had {user.FailedAttemptsInARow} login failed attempts in a row.");
                }

                await _userRepository.Uow.CommitAsync();
            }
        }
    }
}
