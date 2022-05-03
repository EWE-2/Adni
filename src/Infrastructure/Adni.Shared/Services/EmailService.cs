using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.Email;
using Adni.Domain.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Adni.Application.Common;

namespace Adni.Shared.Services
{
    public class EmailService : IEmailService
    {
        private MailSettings MailSettings { get; }
        private ILogger<EmailService> Logger { get; }

        public EmailService(IOptions<MailSettings> mailSettings, ILogger<EmailService> logger)
        {
            MailSettings = mailSettings.Value;
            Logger = logger;
        }

        public async Task SendAsync(EmailDto emailRequest)
        {
            try
            {
                //Creation d'un message
                var email = new MimeMessage
                {
                    Sender = MailboxAddress.Parse(emailRequest.From ?? MailSettings.EmailFrom)
                };
                email.To.Add(MailboxAddress.Parse(emailRequest.To));
                email.Subject = emailRequest.Subject;
                var builder = new BodyBuilder { HtmlBody = emailRequest.Body };
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            } catch(SystemException exception)
            {
                Logger.LogError(exception.Message, exception);
                throw new ApiException(exception.Message);
            }
        }
    }
}
