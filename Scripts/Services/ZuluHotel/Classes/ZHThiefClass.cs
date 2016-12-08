using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHThiefClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Thief"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                    {

                        SkillName.Hiding,
                        SkillName.DetectHidden,
                        SkillName.Poisoning,
                        SkillName.RemoveTrap,
                        SkillName.Lockpicking,
                        SkillName.Stealth,
                        SkillName.Snooping,
                        SkillName.Stealing
                    };
            }
        }
    }
}
