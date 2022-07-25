using Hangfire.Web.Services;

namespace Hangfire.Web.HingfireJobs
{
    public class RecurringJobs
    {
        public static void Example()
        {
            //Example:1
            RecurringJob.AddOrUpdate<EmailService>("RecurringJob-1", x => x.SendEmail("ekrem@mail.com", "Recurring Job", "Example"), Cron.Minutely);

            //Example:2
            //RecurringJob.AddOrUpdate("RecurringJob-2", () => EmailService.StaticSendEmail("ekrem@mail.com", "Recurring Job", "Example"), Cron.Minutely);
        }
    }
}
