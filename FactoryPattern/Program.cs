using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Swordsman press 'S' for archery press 'A' for Cannons press 'C':");
            string selection = Console.ReadLine();
            Soldier s = SoldierCreationFactory.GetSoldier(selection);
            s?.Attack();
            s?.Defend();
        }
    }
}
