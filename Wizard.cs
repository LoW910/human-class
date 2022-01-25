namespace Human
{
    class Wizard : Human
    {
        public Wizard(string name, int strength, int dexterity) : base(name, strength, 25, dexterity, 500)
        {

        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Intelligence;
            target.Health -= dmg;
            Health += dmg;
            return target.Health;
        }

        public int Heal(Human target) {
            int help = Intelligence * 10;
            target.Health += help;
            return help;
        }
    }
}