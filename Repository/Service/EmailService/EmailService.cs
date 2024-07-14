using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using SharedModel.Dtos;
using Repository.Config;
using Microsoft.Extensions.Logging;
using MailKit.Security;
using Microsoft.IdentityModel.Tokens;

namespace Repository.Service.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IPayrollConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;
        public EmailService(IPayrollConfiguration configuration, ILogger<EmailService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void SendEmail(EmailDto emailDto)
        {
            var message = CreateEmailMessage(emailDto);
            SendEmailMessage(message);
        }

        private MimeMessage CreateEmailMessage(EmailDto emailDto)
        {
            var from = _configuration.GetConfigurationSection("MailConfiguration").GetSection("From").Value ?? "";
            var fromAlias = _configuration.GetConfigurationSection("MailConfiguration").GetSection("FromAlias").Value ?? "";
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(fromAlias, from.ToString()));
            //message.From.Add(MailboxAddress.Parse(from));
            message.To.Add(MailboxAddress.Parse(emailDto.ToEmail));
            message.Subject = emailDto.Subject;
            message.Body = new TextPart(TextFormat.Html) { Text = emailDto.Body };
            return message;
        }

        private void SendEmailMessage(MimeMessage mimeMessage)
        {
            using var smtpClient = new SmtpClient();
            try
            {
                var smtpServerName = _configuration?.GetConfigurationSection("MailConfiguration").GetSection("Server").Value ?? "";
                var smtpServerUsername = _configuration?.GetConfigurationSection("MailConfiguration").GetSection("Username").Value ?? "";
                var smtpServerPw =  _configuration?.GetConfigurationSection("MailConfiguration").GetSection("Password").Value ?? "";
                var smtpPort = _configuration?.GetConfigurationSection("MailConfiguration").GetSection("Port").Value ?? "";

                smtpClient.CheckCertificateRevocation = false;
                smtpClient.Connect(smtpServerName, int.Parse(smtpPort), SecureSocketOptions.StartTls);
                smtpClient.AuthenticationMechanisms.Remove("XOAUTH2");
                smtpClient.Authenticate(smtpServerUsername, smtpServerPw);
                smtpClient.Send(mimeMessage);


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Failed to send smtp email to client", typeof(EmailService));
                throw new Exception($"Failed to send smtp email to client ! Review error stack " + $": {ex.Message}");

            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }


        }
    }
}
