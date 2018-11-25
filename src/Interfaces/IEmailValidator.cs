namespace Schematic.Identity
{
    public interface IEmailValidator
    {
        bool IsValidEmail(string email);
    }
}