using Autoinvoicing.Api.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace Autoinvoicing.Api.Controllers;

[ApiController]
[ApiKeyAuthorize]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    private const string DatabaseId = "Invoices";
    private readonly ILogger<InvoiceController> _logger;
    private readonly IConfiguration _configuration;
    private readonly CosmosClient _cosmosClient;

    public InvoiceController(ILogger<InvoiceController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
        _cosmosClient = new CosmosClient(_configuration["Autoinvoicing:CosmosDB:ConnectionString"]);
        _cosmosClient.CreateDatabaseIfNotExistsAsync(DatabaseId);
    }

    [HttpGet]
    [Route("get")]
    public string GetValue()
    {
        return "it works";
    }
}
