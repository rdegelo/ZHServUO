using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHRangerClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Ranger"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                {
                    SkillName.Archery,
                    SkillName.AnimalLore,
                    SkillName.AnimalTaming,
                    SkillName.Veterinary,
                    SkillName.Fishing,
                    SkillName.Camping,
                    SkillName.Cooking,
                    SkillName.Tracking
                };
            }
        }
    }
}
