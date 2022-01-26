using Autoinvoicing.Domain.Models;

namespace Autoinvoicing.Intefraces;
public interface IInvoiceService {
    ValueTask<IEnumerable<Invoice>> GetAll();
    ValueTask<Invoice> Add(Invoice invoice);
}