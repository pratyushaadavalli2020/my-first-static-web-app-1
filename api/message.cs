using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class message
    {
        [FunctionName("message")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
   return new JsonResult(new { text = "Hello from the API" });
            //string name = req.Query["name"];

           // string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
           // dynamic data = JsonConvert.DeserializeObject(requestBody);
           // name = name ?? data?.name;

            //string responseMessage = string.IsNullOrEmpty(name)
             //   ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello from the API.";

            //return new OkObjectResult(responseMessage);
        }
    }
}
