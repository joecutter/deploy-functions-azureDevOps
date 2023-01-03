using System.Collections.Generic;
using System.Threading.Tasks;
using Function1;
using Function1.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Primitives;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnSummation()
        {
            // var query = new Dictionary<string, StringValues>();
            // query.TryAdd("num1", "20");
            // query.TryAdd("num2", "40");
            //
            // var request = new DefaultHttpRequest(new DefaultHttpContext())
            // {
            //     Query = new QueryCollection
            //     (
            //         query
            //     )
            // };
            //
            // var logger = NullLoggerFactory.Instance.CreateLogger("Addition");
            //
            // Task<IActionResult> response  =  Addition.Run(request,logger);
            //
            // var result = (ApiResponse)response.Result;
            //
            // Assert.IsAssignableFrom<ApiResponse>(result);
            //
            // Assert.IsTrue(result.Code == 200);
        }
    }
}