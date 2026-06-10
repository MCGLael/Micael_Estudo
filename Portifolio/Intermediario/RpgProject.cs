using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public virtual void takeDamege(int Damage) { 
            int finalDamage = Damage - Defense;
            if (finalDamage <=0) { finalDamage = 0; }
            
            Hp -= finalDamage; 
        
        }

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
            return Damage + 30;
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
            return Defense + 10;
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
            return Hp + 100;
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
            return Damage + 50;
        }
        public int Shield()
        {

            return Defense;
        }
    }


    internal class RpgProject
    {
        private static void combat(int option, Role player)
        {
            switch (option)
            {
                case 1:
                    player.Attack();
                    break;
                case 2:
                    player.Shield();
                    break;
                case 3:
                     player.HealingPotion();
                    break;
                case 4:
                     player.Ultimate();
                    break;
                default:
                    return;
            }
        }
        private static Role createRole(int option)
        {
            switch (option)
            {
                case 1:
                    return new Knight();
                case 2:
                    return new Mage();
                case 3:
                    return new Tank();
                case 4:
                    return new Heroe();
                default:
                    return null;
                    }
        }
        
        public static void Executar()
        {
            Console.WriteLine("Welcome to the Valarium RPG");

            Console.WriteLine("A terrible attack is happening, quicky! chose your Role!");
            Console.WriteLine("1 - Knight\n2 - Mage\n3 - Tank\n4 - Heroe\n5 - Leave");
            Role player;
            Role enemy;
            if (!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid"); return; }
            player = createRole(option);
            if (player == null) { Console.WriteLine("Invalid Value"); return; }
            //Criação do Inimigo
            int enemyoption = new Random().Next(1, 5);//1-Knight, 2-Mage, 3-Tank, 4-Heroe
            enemy = createRole(enemyoption);
;           Console.WriteLine($"Oh! There you are! {player.Name}! We need your help!\nThe terrible {enemy.Name} is attacking us!");
            Console.WriteLine("You have engaged in battle!");

            int i = 1;

            while(i != 0){
                
                Console.WriteLine("What will you do now?!");
                Console.WriteLine($"HP:{player.Hp}\nEnemy HP{enemy.Hp}");
                Console.WriteLine("1 - Attack\n2 - Defense\n3 - Heal\n4 - Ultimate ");
                if (!int.TryParse(Console.ReadLine(), out int playeropt)) { Console.WriteLine("What are you doing!!!"); }
                switch (playeropt)
                {
                    case 1
                }
            }
        }
    }
}
