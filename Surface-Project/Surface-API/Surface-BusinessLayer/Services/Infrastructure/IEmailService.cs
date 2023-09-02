

using Surface.Common.Utils.Models;

namespace Surface.BusinessAccessLayer.Services.Infrastructure;
public interface IEmailService
{
    Task SendEmailAsync(EmailMessage message);
}
