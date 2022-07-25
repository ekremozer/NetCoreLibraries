using Hangfire.Web.Services;

namespace Hangfire.Web.HingfireJobs
{
    public static class FireAndForgetJobs
    {
        [AutomaticRetry(Attempts = 5)]
        public static string Example()
        {
            //Example:1
            var jobId = BackgroundJob.Enqueue<EmailService>(x => x.SendEmail("ekrem@mail.com", "Hangfire Fire And Forget Job", "Example"));

            //Example:2
            //var jobId2 = BackgroundJob.Enqueue(() => EmailService.StaticSendEmail("ekrem@mail.com", "Hangfire Fire And Forget Job", "Example"));

            return jobId;
        }
    }
}
