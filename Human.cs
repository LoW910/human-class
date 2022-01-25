namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public getter property to access health
        public int Health{
            get {
                return health;
            }
            set {
                health = value;
            }
        }

        // add contrustors that takes a name value, and remaining fields to defaults
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // add constructors that assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int life){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = life;
        }

        // build attach method
        public virtual int Attack(Human target){
            int dmg = Strength * 3;
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage");
            return target.health;
        }

        public void DispayInfo(){
            System.Console.WriteLine($"Name: {Name} Strength: {Strength} Intelligence: {Intelligence} Dexterity: {Dexterity} Health: {health}");
        }
    }
}