using System.Collections.Generic;

namespace Schematic.Identity
{
    public interface IUserRoleRepository<TUserRole>
    {
        List<TUserRole> List();
    }
}