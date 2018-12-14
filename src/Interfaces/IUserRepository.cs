using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Identity
{
    public interface IUserRepository<TUser, TFilter, TSpecification>
    {
        Task<int> CreateAsync(TUser resource, string token, int userID);

        Task<TUser> ReadAsync(TSpecification user);

        Task<int> UpdateAsync(TUser resource, int userID);

        Task<int> DeleteAsync(int id, int userID);

        Task<List<TUser>> ListAsync(TFilter filter);

        Task<bool> SaveTokenAsync(TUser resource, string token);

        Task<TokenVerificationResult> ValidateTokenAsync(string email, string token);

        Task<bool> SetPasswordAsync(TUser resource, string passHash);
    }
}