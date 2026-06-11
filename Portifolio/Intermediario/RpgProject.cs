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
        public int BaseDamage { get; set; }
        public int BaseDefense { get; set; }

        public int Damage { get; set; }

        public int Defense { get; set; }
        public int Potions { get; set; }
        public int CoolDown { get; set; }




        public virtual int Attack() { return Damage; }

        public void Cd()
        {
            if (CoolDown != 0)
            {
                CoolDown--;
            }
            else 
            {
                Reset();
            }
        }

        public virtual void HealingPotion()
        {
           
            Hp = Hp + 20;
            Potions--;
        }
        public virtual void Reset() { }
        

        public abstract void Ultimate();
        
    }

    public class Knight : Role
    {
        public Knight()
        {
            Name = "Valerium";
            Hp = 100;
            BaseDamage = 30;
            Damage = BaseDamage;
            BaseDefense = 40;
            Defense = BaseDefense;
            Potions = 3;
        }
        public override void Ultimate()
        {
            
            if (CoolDown == 0)
            {
                Damage += 30;
                CoolDown = 3;
            }
            else
            {
                Console.WriteLine("Your Ultimate is on CoolDown");
            }
        }
        public override void Reset() 
        {
            Damage = BaseDamage;
        }
        
        
    }
    public class Mage : Role
    {
        public Mage()
        {
            Name = "Merlin";
            Hp = 65;
            BaseDamage = 60;
            Damage = BaseDamage;
            Defense = 20;
            Potions = 5;
        }
        public override void Ultimate()
        {

            if (CoolDown == 0)
            {
                Console.WriteLine("Fury of Drakar!");
                Damage += 60;
                CoolDown = 3;
            }
            else
            {
                Console.WriteLine("Your Ultimate is on CoolDown");
            }

        }
        public override void Reset()
        {
            Damage = BaseDamage;
        }

        

    }
    public class Tank : Role
    {
        public Tank()
        {
            Name = "Mono";
            Hp = 500;
            BaseDamage = 20;
            Damage = BaseDamage;
            Defense = 80;
            Potions = 2;
        }
        public override void Ultimate()
        {
            
            if (CoolDown == 0)
            {
                Console.WriteLine("Flair of Life!");
                Damage += 50;
                CoolDown = 3;
            }
            else
            {
                Console.WriteLine("Your Ultimate is on CoolDown");
            }
        }
        
    }
    public class Ladin : Role
    {
        public Ladin()
        {
            Name = "Kazuma";
            Hp = 70;
            BaseDamage = 50;
            Damage = BaseDamage;
            Defense = 30;
            Potions = 5;
            
        }
        public override void Ultimate()
        {
            
            if (CoolDown == 0)
            {
                Console.WriteLine("You found 2 potions close by!");
                Potions += 2;
                CoolDown = 3;
                
            }
            else
            {
                Console.WriteLine("Your Ultimate is on CoolDown");
            }
            
        }
        public override int Attack() 
        {
            int criticalHit = new Random().Next(1, 6);
            if (criticalHit == 3)
            {
                Console.WriteLine("Critical hit!");
                return Damage * 5;
            }
            return Damage;
        }

        
    }


    internal class RpgProject
    {
        private static readonly Random random = new Random();

        private static void combat(int option, Role agent, Role pacient)
        {
            switch (option)
            {
                case 1://Attack
                    Console.WriteLine("Attack!\n");
                    pacient.Hp -= agent.Attack();
                    if (pacient.Hp < 0) { pacient.Hp = 0; }

                    break;
                case 2://Defense
                    agent.Defense += 20;
                    
                    break;
                case 3://Heal
                    Console.WriteLine("Heal!\n");
                    if (agent.Potions <= 0) 
                    {
                        Console.WriteLine("You don't have anymore Potions");
                        break;
                    }
                    agent.HealingPotion();
                    

                    break;
                case 4://Ultimate
                    Console.WriteLine("Ultimate!");
                    agent.Ultimate();

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
                    return new Ladin();
               default:
                    return null;
                    }
        }
        
        public static void Executar()
        {
            
            Console.WriteLine("Welcome to the Valarium RPG");

            Console.WriteLine("A terrible attack is happening, quicky! chose your Role!");
            Console.WriteLine("1 - Knight\n2 - Mage\n3 - Tank\n4 - Ladin\n5 - Leave");
            Role player;
            Role enemy;
            if (!int.TryParse(Console.ReadLine(), out int option)) { Console.WriteLine("Invalid"); return; }
            player = createRole(option);
            if (option == 5) { Console.WriteLine("Leaving the Game..."); return; }
            if (player == null) { Console.WriteLine("Invalid Value"); return; }
                //Criação do Inimigo
                int enemyoption = random.Next(1, 5);//1-Knight, 2-Mage, 3-Tank, 4-Heroe
            enemy = createRole(enemyoption);
            Console.WriteLine($"You are {player.Name}\nHP: {player.Hp}\nDamage: {player.Damage}\nDefense: {player.Defense}\nPotions: {player.Potions}\n");
;           Console.WriteLine($"Oh! There you are! {player.Name}! We need your help!\nThe terrible {enemy.Name} is attacking us!");
            Console.WriteLine("You have engaged in battle!");

            int i = 1;

            while(i != 0)
            {
                if (player.Hp <= 0)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
                enemy.Cd();
                player.Cd();
                Console.WriteLine("What will you do now?!");
                Console.WriteLine($"HP:{player.Hp}\nEnemy HP{enemy.Hp}");
                Console.WriteLine("1 - Attack\n2 - Defense\n3 - Heal\n4 - Ultimate ");
                if (!int.TryParse(Console.ReadLine(), out int playeropt)) { Console.WriteLine("What are you doing!!!"); }
                Console.Write("You: ");
                combat(playeropt, player, enemy);
                if(enemy.Hp <= 0)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                Console.Write("Enemy: ");
                int enemyopt = random.Next(1, 5);
                combat(enemyopt, enemy, player);
                

            }
            Console.WriteLine("Thanks for playing");
        }
    }
}
