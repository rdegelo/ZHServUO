using Server.Commands;
using Server.Mobiles;
using Server.Services.ZuluHotel.Classes;
using Server.Targeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel.Commands
{
    public class ZHSetClass
    {
        public static void Initialize()
        {
            Register("ZHSetClass", AccessLevel.GameMaster, new CommandEventHandler(ZHSetClass_OnCommand));
        }

        public static void Register(string command, AccessLevel access, CommandEventHandler handler)
        {
            CommandSystem.Register(command, access, handler);
        }

        [Usage("ZHSetClass <class name> <level>")]
        [Description("Set a specific level to a mobile.")]
        public static void ZHSetClass_OnCommand(CommandEventArgs e)
        {
            if (e.Arguments.Length != 2)
            {
                e.Mobile.SendMessage("Usage: ZHSetClass [class] [level].");
                return;
            }

            var c = ZHSpecClass.Classes.SingleOrDefault(o => o.Name.ToLower() == e.Arguments[0].ToLower());

            if (c == null)
            {
                e.Mobile.SendMessage("Can't find this class name.");
                return;
            }

            e.Mobile.Target = new ClassSkillTarget(c, e.GetInt32(1));
        }

        public class ClassSkillTarget : Target
        {
            private ZHBaseClass m_Class;
            private double m_Level;

            public ClassSkillTarget(ZHBaseClass cls, int level)
                : base(-1, false, TargetFlags.None)
            {
                m_Class = cls;
                m_Level = level;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (targeted is PlayerMobile)
                {
                    Mobile targ = (Mobile)targeted;

                    Server.Skills skills = targ.Skills;

                    var skillGain = (600 + ((m_Level - 1) * 120)) / m_Class.Skills.Count;

                    for (int i = 0; i < skills.Length; ++i)
                    {
                        if (m_Class.Skills.Contains(skills[i].SkillName))
                            skills[i].Base = skillGain;
                        else
                            skills[i].Base = 0;
                    }

                    CommandLogging.LogChangeProperty(from, targ, String.Format("ZHSetClass {0}", m_Class.Name), m_Level.ToString());
                    from.SendMessage("Success");
                }
                else
                {
                    from.SendMessage("This is not a player!");
                }
            }
        }
    }
}
