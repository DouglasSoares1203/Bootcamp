namespace Bootcamp.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name  = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + "Lançou magia";
        }

        public string Attack(int Bonus)
        {
            return this.Name + " Lançou Magia com bonus de ataque de " + Bonus;
        }
    }
}