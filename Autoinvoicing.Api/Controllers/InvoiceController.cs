using Autoinvoicing.Api.Attributes;
using Autoinvoicing.Domain.Models;
using Autoinvoicing.Intefraces;
using Microsoft.AspNetCore.Mvc;

namespace Autoinvoicing.Api.Controllers;

[ApiController]
[ApiKeyAuthorize]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly ILogger<InvoiceController> _logger;
    private readonly IInvoiceService _invoiceService;

    public InvoiceController(ILogger<InvoiceController> logger, IInvoiceService invoiceService)
    {
        _logger = logger;
        _invoiceService = invoiceService;
    }

    [HttpGet]
    [Route("get")]
    public ValueTask<IEnumerable<Invoice>> GetValue()
    {
        return _invoiceService.GetAll();
    }
}
