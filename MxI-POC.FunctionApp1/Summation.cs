using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MxI_POC.FunctionApp1
{
    public class Summation
    {
        [FunctionName("Summation")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            Console.WriteLine("C# HTTP trigger function processed a request "+req.Query["num"]);
            
            string num1= req.Query["num1"];
            string num2= req.Query["num2"];
            int sum = 0;
            
            if (string.IsNullOrEmpty(num1))
            {
                return new BadRequestResult();
            }
             
            sum = Int32.Parse(num1) + Int32.Parse(num2);;

            return new OkObjectResult(sum);
        }
    }
}