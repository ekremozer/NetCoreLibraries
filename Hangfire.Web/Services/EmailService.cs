using System.Diagnostics;

namespace Hangfire.Web.Services
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Debug.WriteLine($"{to} adresine mail gönderildi.", subject);
        }

        public static void StaticSendEmail(string to, string subject, string body)
        {
            Debug.WriteLine($"{to} adresine mail gönderildi.", subject);
        }
    }
}
