using System.IO;
using System.Threading.Tasks;
using Function2.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Function2
{
    public class Subtraction
    {
        [FunctionName("Subtraction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("HTTP trigger Subtraction function request");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            
            SubtractionDto data = JsonConvert.DeserializeObject<SubtractionDto>(requestBody);
            
            var area = data?.Num1 - data?.Num2;

            var resMsg = new ApiResponse(200, "Subtraction", area);

            return new OkObjectResult(resMsg);
        }
    }
}