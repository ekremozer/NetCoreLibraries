using System.Diagnostics;
using Hangfire.Web.Services;

namespace Hangfire.Web.HingfireJobs
{
    public class ContinuationsJobs
    {
        public static void Example()
        {
            var jobId = FireAndForgetJobs.Example();

            //Example:1
            var jobId2 = BackgroundJob.ContinueJobWith(jobId, () => Debug.WriteLine($"{jobId} Id'li job çalıştı."));

            //Example:2
            //var jobId3 = BackgroundJob.ContinueJobWith<EmailService>(jobId, x=>x.SendEmail("ekrem@mail.com", "Hangfire Continuations Job", "Example"));
        }
    }
}
