using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schematic.Identity
{
    public interface IUserRepository<TUser, TUserFilter>
    {
        Task<int> Create(TUser resource, string token, int userID);

        Task<TUser> Read(int id);

        Task<TUser> ReadByEmail(string email);

        Task<int> Update(TUser resource, int userID);

        Task<int> Delete(int id, int userID);

        Task<List<TUser>> List(TUserFilter filter);

        Task<bool> SaveToken(TUser resource, string token);

        Task<TokenVerificationResult> ValidateToken(string email, string token);

        Task<bool> SetPassword(TUser resource, string passHash);
    }
}