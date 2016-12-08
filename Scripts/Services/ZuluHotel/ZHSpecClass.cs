using Server.Services.ZuluHotel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Services.ZuluHotel
{
    public class ZHSpecClass
    {
        #region Static
        public static ZHBaseClass[] Classes =
        {
            new ZHBardClass(), new ZHCrafterClass(), new ZHMageClass(), new ZHRangerClass(), new ZHThiefClass(), new ZHWarriorClass()
        };

        public static ZHSpecClass CalculateClass(Server.Mobiles.PlayerMobile player)
        {
            if (player.Skills == null)
                return null;

            foreach (var c in Classes)
            {
                var sum = c.Skills.Sum(o => player.Skills[o].Value);
                var part = (sum / (player.Skills.Total / 10)) * 100;

                var level = (int)Math.Floor(((sum - 600) / 120) + 1);

                while (level > 0)
                {
                    if (level > 0 && part >= (60 + ((level - 1) * 8)))
                        return new ZHSpecClass(level, c);

                    level--;
                }
            }

            return null;
        }

        #endregion

        public int Level { get; private set; }
        public ZHBaseClass Class { get; set; }

        public ZHSpecClass(int lvl, ZHBaseClass cl)
        {
            Level = lvl;
            Class = cl;
        }

        public override string ToString()
        {
            return string.Format("{0} - Level {1}", Class, Level);
        }

        public override bool Equals(object obj)
        {
            var item = obj as ZHSpecClass;
            if (item != null && item.Class.Equals(Class) && item.Level == this.Level)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return Class.GetHashCode() * Level;
        }
    }
}
