using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHMageClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Mage"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                    {

                        SkillName.EvalInt,
                        SkillName.Magery,
                        SkillName.Alchemy,
                        SkillName.Meditation,
                        SkillName.SpiritSpeak,
                        SkillName.MagicResist,
                        SkillName.Inscribe,
                        SkillName.ItemID
                    };
            }
        }
    }
}
