using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsILogger
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"LogInformation - C# Timer trigger function executed at: {DateTime.Now}");
            log.LogTrace($"LogTrace - C# Timer trigger function executed at: {DateTime.Now}");
            log.LogError($"LogError - C# Timer trigger function executed at: {DateTime.Now}");
            log.LogWarning($"LogWarning - C# Timer trigger function executed at: {DateTime.Now}");
            log.LogCritical($"LogCritical - C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
