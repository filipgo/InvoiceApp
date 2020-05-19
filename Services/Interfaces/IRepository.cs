using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;

namespace ExampleInvoiceApp.Services.Interfaces
{
    public interface IRepository<T>
    {
        Task Create(T item);

        Task<T> Read(int id);

        Task Update(T item);

        Task Delete(int id);
    }
}