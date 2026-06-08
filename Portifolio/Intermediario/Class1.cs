using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public abstract class Role
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public int Damage { get; set; }

        public int Defense { get; set; }

        public virtual int Attack() {
            return Damage;
        }


        public virtual void HealingPotion() { Hp = Hp + 20; }

        public abstract int Ultimate();
        
    }

    public class Knight : Role
    {
        public Knight()
        {
            Name = "Valerium";
            Hp = 100;
            Damage = 30;
            Defense = 40;
        }
        public override int Ultimate()
        { 
            return Damage + 5;
        }
        
        public int Shield (){ 
        
            return Defense + 20;
        }
    }
    public class Mage : Role
    {
        public Mage()
        {
            Name = "Merlin";
            Hp = 65;
            Damage = 80;
            Defense = 20;
        }
        public override int Ultimate()
        {
            return Damage + 5;
        }

        public int MagicShield()
        {

            return Defense;
        }

    }
    public class Tank : Role
    {
        public Tank()
        {
            Name = "Mono";
            Hp = 500;
            Damage = 20;
            Defense = 80;
        }
        public override int Ultimate()
        {
            return Damage;
        }
        public override void HealingPotion()
        {
            Hp = Hp + 20;

        }
        public int Shield()
        {

            return Defense;
        }
    }
    public class Heroe : Role
    {
        public Heroe()
        {
            Name = "The Chosen One";
            Hp = 1000;
            Damage = 50;
            Defense = 0;
        }
        public override int Ultimate()
        {
            return Damage;
        }
        public override void HealingPotion()
        {
            Hp = Hp + 20;

        }
        public int Shield()
        {

            return Defense;
        }
    }


    internal class Class1
    {
    }
}
