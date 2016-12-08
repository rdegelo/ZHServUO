using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHWarriorClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Warrior"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                    {

                        SkillName.Anatomy,
                        SkillName.Healing,
                        SkillName.Tactics,
                        SkillName.Parry,
                        SkillName.Swords,
                        SkillName.Fencing,
                        SkillName.Wrestling,
                        SkillName.Macing
                    };
            }
        }
    }
}
