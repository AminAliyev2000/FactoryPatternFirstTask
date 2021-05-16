using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Swordman:Soldier
    {
        public Swordman()
        {
            Name = "Swordman";
            HP = 200;
            Damage = 15;
        }
    }
}
