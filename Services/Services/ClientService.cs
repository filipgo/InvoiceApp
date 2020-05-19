using System.Threading.Tasks;
using ExampleInvoiceApp.Common.Models;
using ExampleInvoiceApp.Services.Data.Repository.Base;
using ExampleInvoiceApp.Services.Interfaces;

namespace ExampleInvoiceApp.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly BaseRepository<Client> _clientRepository;

        public ClientService(BaseRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }
        
        public async Task CheckOrCreate(Client client)
        {
            try
            {
                await _clientRepository.Read(client.Id);
            }
            catch
            {
                await _clientRepository.Create(client);
            }
        }
    }
}