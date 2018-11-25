using System;

namespace Schematic.Identity
{
    public class UserRole
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string DisplayTitle { get; set; }

        public DateTime DateCreated { get; set; }

        public int CreatedBy { get; set; }
        
        public bool HasRole { get; set; } = false;
    }
}