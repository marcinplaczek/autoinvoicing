using Microsoft.Azure.CosmosRepository;

namespace Autoinvoicing.Domain.Models;

public class Invoice : Item 
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public decimal NetAmount { get; set; }
    public decimal GrossAmount {get; set;}
}