using System;
using System.IO;
using System.Threading.Tasks;
using Function1.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Function1
{
    public class Addition
    {
        [FunctionName("Addition")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("HTTP trigger Addition function request");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            
            dynamic data = JsonConvert.DeserializeObject<AdditionDto>(requestBody);
            
            var area = data?.Num1 + data?.Num2;

            var resMsg = new ApiResponse(200, "Summation", area);

            return new OkObjectResult(resMsg);
        }
    }
}