using System.Collections.Generic;

namespace Schematic.Identity
{
    public interface IUserRepository<TUser, TUserFilter>
    {
        int Create(TUser resource, string token, int userID);

        TUser Read(int id);

        TUser ReadByEmail(string email);

        bool Update(TUser resource, int userID);

        bool Delete(int id, int userID);

        List<TUser> List(TUserFilter filter);

        bool SaveToken(TUser resource, string token);

        TokenVerificationResult ValidateToken(string email, string token);

        bool SetPassword(TUser resource, string passHash);
    }
}