using System;
using System.Linq;
using InmNow.Domain.SurveyBuilder.Models;
using InmNow.Repository.Repositories;
using InmNow.Service.Interfaces;
using NLog;


namespace InmNow.Service.Services
{

    public class ClientService : IClientService
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ClientRepository ClientRepository;

        public ClientService()
        {
            ClientRepository = new ClientRepository();
        }

        public IQueryable<Client> GetAll()
        {
            try
            {
                return ClientRepository.FindAll();
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Clients: {0}", ex.Message);
                return null;
            }
        }


        public Client GetClientById(int clientId)
        {
            try
            {
                return ClientRepository.FindOne(a => a.ClientId == clientId);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Client By Id: {0}", ex.Message);
                return null;
            }
        }

        public Client GetClientByEmail(string email)
        {
            try
            {
                return ClientRepository.FindOne(a => a.Email == email);
            }
            catch (Exception ex)
            {
                Logger.Error("Error Retrieving Client By Email: {0}", ex.Message);
                return null;
            }
        }

        public Client CreateClient(Client newClient)
        {
            try
            {
                return ClientRepository.Create(newClient);
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error Creating Client: {0}", ex.Message);
                return null;
            }

        }

        public Client UpsertClient(Client updateClient)
        {
            try
            {
                var exists = ClientRepository.Get(updateClient.ClientId);
                if (exists == null)
                    ClientRepository.Create(updateClient);
                else
                    ClientRepository.Update(updateClient);

                return updateClient;
            }
            catch (Exception ex)
            {
                Logger.Error("Error Upserting Client: {0}", ex.Message);
                return null;
            }
        }

        public bool DeleteClient(Client deleteClient)
        {
            try
            {
                return ClientRepository.Delete(deleteClient);               
            }
            catch (Exception ex)
            {
                Logger.Error("Error Deleting Client: {0}", ex.Message);
                return false;
            }
        }
    }
}