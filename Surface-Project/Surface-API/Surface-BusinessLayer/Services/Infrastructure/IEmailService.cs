

using Surface.Common.Utils.Models;

namespace Surface.BusinessAccessLayer.Services.Infrastructure;
public interface IEmailService
{
    Task SendPasswordResetEmailAsync(EmailMessage message);
    Task SendTeamInviteEmailAsync(EmailMessage message);
}
