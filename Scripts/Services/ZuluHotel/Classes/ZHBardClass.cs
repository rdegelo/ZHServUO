using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Classes
{
    public class ZHBardClass : ZHBaseClass
    {
        public override string Name
        {
            get { return "Bard"; }
        }

        public override HashSet<SkillName> Skills
        {
            get
            {
                return new HashSet<SkillName>
                {

                    SkillName.Musicianship,
                    SkillName.Begging,
                    SkillName.Herding,
                    SkillName.TasteID,
                    SkillName.Peacemaking,
                    SkillName.Provocation,
                    SkillName.Discordance,
                    SkillName.Cartography
                };
            }
        }
    }
}
