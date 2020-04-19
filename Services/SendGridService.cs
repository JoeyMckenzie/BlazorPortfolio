using System;
using System.Net.Http;
using System.Threading.Tasks;
using Portfolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Services
{
    public class SendGridService
    {
        private HttpClient _httpClient;

        public SendGridService(HttpClient httpClient) =>
            _httpClient = httpClient;

        public async Task SendEmail(EmailDto emailDto)
        {
            var sendGridClient = new SendGridClient(_httpClient, "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");
            var sendGridMessage = new SendGridMessage
            {
                From = new EmailAddress(emailDto.Email),
                Subject = emailDto.Subject,
                PlainTextContent = emailDto.Message,
            };
            sendGridMessage.AddTo("joey.mckenzie27@gmail.com");

            try
            {
                var response = await sendGridClient.SendEmailAsync(sendGridMessage);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Could not send email: {e.Message}");
            }
        }
    }
}
