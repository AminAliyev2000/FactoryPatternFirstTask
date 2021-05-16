using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Cannons:Soldier
    {
        public Cannons()
        {
            Name = "Cannons";
            HP = 300;
            Damage = 150;
        }
    }
}
