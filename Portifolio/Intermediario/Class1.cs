using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Role
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public int Damage { get; set; }

        public int Defense { get; set; }

        public int Attack()
        {

            return Damage;
        }

        public int HealingPotion()
        {
            return Hp + 20;

        }
    }

    public class Knight : Role
    {

    }
    public class Mage : Role
    {

    }
    public class Tank : Role
    {

    }
    public class Heroe : Role
    {

    }


    internal class Class1
    {
    }
}
