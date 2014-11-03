using System.Linq;
using InmNow.Domain.SurveyBuilder.Models;

namespace InmNow.Service.Interfaces
{
    public interface IClientService
    {
        Client GetClientById(int clientId);
        Client GetClientByEmail(string email);
        IQueryable<Client> GetAll();
        Client CreateClient(Client newClient);
        Client UpsertClient(Client updateClient);
        bool DeleteClient(Client clientId);

    }
}
