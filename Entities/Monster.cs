using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Entities
{
    public class Monster
    {
        public Monster(string Name, int Level, string HeroType, int Life, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

            public string Name;
            public int Level;
            public string HeroType;
            public int Life;
            public int MagicPoint;


        public override string ToString()
        {
            return Name + " " + Level  + " " + HeroType + " " + Life + " " + MagicPoint;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com uma espada ";
        }
    }
}