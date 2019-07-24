using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using Test.Domain.Jobs;

namespace Test.FN.Job1
{
    public class Function2
    {
        IJob2 _job2;

        public Function2(IJob2 job2)
        {
            this._job2 = job2;
        }

        [FunctionName("Function2")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            _job2.Execute();

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}