using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace MyFunctionApp.Functions;

public class HttpTrigger
{
    private readonly ILogger _logger;

    public HttpTrigger(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<HttpTrigger>();
    }

    [Function("HttpTrigger")]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
        await response.WriteStringAsync("Hello from Azure Functions (.NET)!");
        return response;
    }
}
