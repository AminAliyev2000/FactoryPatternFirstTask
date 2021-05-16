using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    static class SoldierCreationFactory
    {
        public static Soldier GetSoldier(string soldierType)
        {
            if (soldierType == "S")

            {
               return  new Swordman();
            }
            if (soldierType == "A")
            {
               return new Archery();
            }
            if (soldierType == "C")
            {
                return new Cannons();
            }
            return null;
        }
    }
}
