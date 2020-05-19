using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;

namespace ExampleInvoiceApp.Services.Interfaces
{
    public interface IClientService
    {
        Task CheckOrCreate(Client client);
    }
}