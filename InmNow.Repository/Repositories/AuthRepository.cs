using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InmNow.Repository.DbContexts;
using InmNow.Repository.Interfaces;
using InmNow.Repository.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InmNow.Repository.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private InmergeNowContext Context { get; set; }

        private readonly UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            Context = new InmergeNowContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(Context));
        }

        public async Task<IdentityResult> RegisterUser(InmUser inmUserModel)
        {
            var user = new IdentityUser
            {
                UserName = inmUserModel.UserName
            };

            var result = await _userManager.CreateAsync(user, inmUserModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            var user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public void Dispose()
        {
            Context.Dispose();
            _userManager.Dispose();

        }

        public AuthorizedClient FindClient(string authorizedClientId)
        {
            var authorizedClient = Context.AuthorizedClients.Find(authorizedClientId);

            return authorizedClient;
        }

        public async Task<bool> AddRefreshToken(RefreshToken token)
        {

            var existingToken = Context.RefreshTokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).SingleOrDefault();

            if (existingToken != null)
            {
                var result = await RemoveRefreshToken(existingToken);
            }

            Context.RefreshTokens.Add(token);

            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await Context.RefreshTokens.FindAsync(refreshTokenId);

            if (refreshToken != null)
            {
                Context.RefreshTokens.Remove(refreshToken);
                return await Context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            Context.RefreshTokens.Remove(refreshToken);
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = await Context.RefreshTokens.FindAsync(refreshTokenId);

            return refreshToken;
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return Context.RefreshTokens.ToList();
        }
    }
}
