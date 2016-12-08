using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHCrafterClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Crafter"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                    {

                        SkillName.ArmsLore,
                        SkillName.Mining,
                        SkillName.Lumberjacking,
                        SkillName.Blacksmith,
                        SkillName.Fletching,
                        SkillName.Carpentry,
                        SkillName.Tailoring,
                        SkillName.Tinkering
                    };
            }
        }
    }
}
