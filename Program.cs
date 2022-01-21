using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with human class!!");

            Human greg = new Human("Greg");
            Human bob = new Human("Bob");

            greg.Attack(bob);
            System.Console.WriteLine(bob.Health);
        }
    }




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
        public int Attack(Human target){
            target.health = target.health - (5 * this.Strength);
            return target.health;
        }
    }
}
