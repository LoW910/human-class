using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with human class!!");

            Ninja newNinja = new Ninja("tom", 5,5);
            Wizard newWizard = new Wizard("bob", 10,10);
            Samurai newSamuari = new Samurai("jeb", 10,10,10);

            newSamuari.DispayInfo();
            newNinja.Attack(newSamuari);
            newSamuari.DispayInfo();
            newWizard.Attack(newSamuari);
            newSamuari.DispayInfo();
            System.Console.WriteLine("=========== attacks ========");
            newWizard.DispayInfo();
            newSamuari.Attack(newWizard);
            newWizard.DispayInfo();

            System.Console.WriteLine("======== meditate ===========");
            newSamuari.DispayInfo();
            newSamuari.Meditate();
            newSamuari.DispayInfo();
            
            System.Console.WriteLine("====== steal =============");
            newNinja.DispayInfo();
            newNinja.Steal(newSamuari);
            newNinja.DispayInfo();

        }
    }
}
