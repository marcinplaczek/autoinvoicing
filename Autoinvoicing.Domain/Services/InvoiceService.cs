using Autoinvoicing.Domain.Models;
using Autoinvoicing.Intefraces;
using Microsoft.Azure.CosmosRepository;

namespace Autoinvoicing.Domain.Services;
public class InvoiceService : IInvoiceService
{
    readonly IRepository<Invoice> _invoiceRepository;

    public InvoiceService(
        IRepository<Invoice> invoiceRepository) =>
        _invoiceRepository = invoiceRepository;

    public IRepository<Invoice> Get_invoiceRepository()
    {
        return _invoiceRepository;
    }

    public ValueTask<IEnumerable<Invoice>> GetAll() {
        return _invoiceRepository.GetAsync(x => true);
    }

    public ValueTask<Invoice> Add(Invoice invoice)
    {
        return _invoiceRepository.CreateAsync(invoice);
    }
}
