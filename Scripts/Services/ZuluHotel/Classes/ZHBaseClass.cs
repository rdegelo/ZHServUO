using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public abstract class ZHBaseClass
    {
        public abstract string Name { get; }
        public abstract HashSet<SkillName> Skills { get; }

        public override string ToString()
        {
            return Name;
        }
        
        public override bool Equals(object obj)
        {
            var item = obj as ZHBaseClass;
            if (item != null && item.Name == this.Name)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
