namespace Bootcamp.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Life, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
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