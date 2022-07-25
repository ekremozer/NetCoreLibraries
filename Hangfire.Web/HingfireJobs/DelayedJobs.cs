using Hangfire.Web.Services;

namespace Hangfire.Web.HingfireJobs
{
    public class DelayedJobs
    {
        public static string Example()
        {
            //Example:1
            var jobId = BackgroundJob.Schedule<EmailService>(x => x.SendEmail("ekrem@mail.com", "Hangfire Delayed Job", "Example"), TimeSpan.FromSeconds(5));

            //Example:2
            //var jobId2 = BackgroundJob.Schedule(() => EmailService.StaticSendEmail("ekrem@mail.com", "Hangfire Delayed Job", "Example"), TimeSpan.FromSeconds(5));

            return jobId;
        }
    }
}
