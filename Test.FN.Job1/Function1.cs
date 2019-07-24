using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using Test.Domain.Services;

namespace Test.FN.Job1
{
    public class Function1
    {
        ITestService _service;

        public Function1(ITestService service)
        {
            this._service = service;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            this._service.SendAllWidgetEmails();

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
