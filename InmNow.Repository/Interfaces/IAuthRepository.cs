using System;
using System.Threading.Tasks;
using InmNow.Repository.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InmNow.Repository.Interfaces
{
    public interface IAuthRepository : IDisposable
    {
        Task<IdentityResult> RegisterUser(InmUser inmUserModel);
        Task<IdentityUser> FindUser(string userName, string password);
        void Dispose();
    }
}