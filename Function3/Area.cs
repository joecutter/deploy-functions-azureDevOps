using System.IO;
using System.Threading.Tasks;
using Function3.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Function3
{
    public class Area
    {
        [FunctionName("Area")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("HTTP trigger Area function request");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            
            dynamic data = JsonConvert.DeserializeObject<AreaDto>(requestBody);
            
            var area = data?.Length * data?.Width;

            var resMsg = new ApiResponse(200, "Area", area);

            return new OkObjectResult(resMsg);
        }
    }
}