using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using Test.Domain.Services;

namespace Test.FN.Job1
{
    public class Function2
    {
        ITestService _service;

        public Function2(ITestService service)
        {
            this._service = service;
        }

        [FunctionName("Function2")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            _service.SendAllWidgetEmails();

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}