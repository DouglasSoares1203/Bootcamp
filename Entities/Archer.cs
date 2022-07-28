using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name,Level,HeroType,Life,MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + "Disparou uma flecha";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 2)
            {
                return this.Name + "Disparou uma flecha envenenada super afetiva com bônus de ataque de " + Bonus + " " + "+";

            }
            else
            {
                return this.Name + " Disparou uma flecha no alvo errado bonus de ataque de " + Bonus + " " + "+";
            }
        }

    }
}