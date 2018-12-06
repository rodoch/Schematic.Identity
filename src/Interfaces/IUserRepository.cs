using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Identity
{
    public interface IUserRepository<TUser, TUserFilter>
    {
        Task<int> CreateAsync(TUser resource, string token, int userID);

        Task<TUser> ReadAsync(int id);

        Task<TUser> ReadByEmailAsync(string email);

        Task<int> UpdateAsync(TUser resource, int userID);

        Task<int> DeleteAsync(int id, int userID);

        Task<List<TUser>> ListAsync(TUserFilter filter);

        Task<bool> SaveTokenAsync(TUser resource, string token);

        Task<TokenVerificationResult> ValidateTokenAsync(string email, string token);

        Task<bool> SetPasswordAsync(TUser resource, string passHash);
    }
}