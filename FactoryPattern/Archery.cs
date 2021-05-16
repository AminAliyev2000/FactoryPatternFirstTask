using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Archery:Soldier
    {
        public Archery()
        {
            Name = "Archer";
            HP = 100;
            Damage = 20;
        }
    }
}
