namespace Schematic.Identity
{
    public interface IPasswordHasher<TUser> where TUser : ISchematicUser  
    {
        string HashPassword(TUser user, string password);

        PasswordVerificationResult VerifyHashedPassword(
            TUser user, string hashedPassword, string providedPassword);
    }
}