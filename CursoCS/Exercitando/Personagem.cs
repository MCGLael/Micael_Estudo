using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CursoCS.Exercitando
{
    public abstract class Character
    {
        public int HP { get; set; }

        public Character(int hp)
        {
            HP = hp;

        }
        public abstract int Atacar();
        public abstract int Defesa();

    }
    public class Mago : Character
    {
        public Mago() : base(55) { }
        public override int Atacar()
        {
            Console.WriteLine("\nFireball");
            return 45;
        }
        public override int Defesa()
        {
            Console.WriteLine("\nMagic Shild!");
            return 30;
        }
    }
    public class Cavaleiro : Character
    {
        public Cavaleiro() : base(300) { }
        public override int Atacar()
        {
            Console.WriteLine("\nAtaque de espada");
            return 30;
        }
        public override int Defesa()
        {
            Console.WriteLine("\nEscudo de Pandora!");
            return 40;
        }
    }
    public class Arqueiro : Character
    {
        public Arqueiro() : base(60) { }
        public override int Atacar()
        {
            Console.WriteLine("\nChuva de flechas");
            return 90;
        }
        public override int Defesa()
        {
            Console.WriteLine("\nEscudo!");
            return 10;
        }
    }
    public class Ladino : Character
    {
        public Ladino() : base(80) { }
        public override int Atacar()
        {
            Console.WriteLine("\nAtaque Stealth");
            return 50;
        }
        public override int Defesa()
        {
            Console.WriteLine("\nAnel de proteção!");
            return 30;
        }
    }

    
    internal class Personagem
    {
        public static void Executar()
        {
            //Seleção de personagem usando dicionário e lambda
            Dictionary<int, Func<Character>> player = new Dictionary<int, Func<Character>>();

            player.Add(1, () => new Mago());
            player.Add(2, () => new Cavaleiro());
            player.Add(3, () => new Arqueiro());
            player.Add(4, () => new Ladino());
            Character inimigo = new Mago();
            inimigo.HP = 100;
            int escolha;
            Character personagem = null;
            while (personagem == null)
            {
                Console.WriteLine("Escolha sua Classe");

                Console.WriteLine("1- Mago");
                Console.WriteLine("2- Cavaleiro");
                Console.WriteLine("3 - Arqueiro");
                Console.WriteLine("4 - Ladino");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Insira uma opção válida");
                    continue;
                }
                if (!player.ContainsKey(opcao))
                {
                    Console.WriteLine("Classe inexistente"); continue;
                }


                personagem = player[opcao]();

            }
                






                /*switch (opcao)
{
    case 1:
        personagem = new Mago();
        break;
    case 2:

        personagem = new Cavaleiro();
        break;
    case 3:

        personagem = new Arqueiro();
        break;
    case 4:

        personagem = new Ladino();
        break;

    default:
        Console.WriteLine("Classe invalida\nTente novamente"); break;


}*/
            //Seção de ataque e defesa
                while (personagem.HP > 0 && inimigo.HP > 0)
                {
                    Console.WriteLine("Seu HP: {0} || HP inimigo {1}", personagem.HP, inimigo.HP);

                    Console.WriteLine("Atacar -> 1\nDefender -> 2");
                    if (!int.TryParse(Console.ReadLine(), out escolha))
                    {
                        Console.WriteLine("Insira uma opção válida");
                        continue;
                    }


                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("\nVocê:");
                            int dano = personagem.Atacar();
                            inimigo.HP -= dano;
                            Console.WriteLine("\nVocê causou {0} de dano ao inimigo", dano);

                            if (inimigo.HP <= 0)
                            {
                                inimigo.HP = 0;
                                Console.WriteLine("\nVocê venceu!");
                                Console.WriteLine("Fim de jogo");
                                return;

                            }

                            Console.WriteLine("\nInimigo:");
                            int danoInimigo = inimigo.Atacar();
                            personagem.HP -= danoInimigo;
                            Console.WriteLine("\nVocê tomou {0} de dano", danoInimigo);


                            if (personagem.HP < 0)
                            {
                                personagem.HP = 0;
                                Console.WriteLine("\nO inimigo era forte demais para você\nVocê Morreu");
                                Console.WriteLine("Fim de jogo");
                                return;
                            }

                            break;
                        case 2:

                            Console.WriteLine("\nInimigo:");
                            int ataqueInimigo = inimigo.Atacar();
                            Console.WriteLine("\nVocê:");
                            int defesaPersonagem = personagem.Defesa();

                            int danoFinal = ataqueInimigo - defesaPersonagem;
                            if (danoFinal < 0)
                            {
                                danoFinal = 0;
                            }
                            personagem.HP -= danoFinal;
                            if (personagem.HP < 0)
                            {
                                personagem.HP = 0;
                                Console.WriteLine("O inimigo era forte demais para você\nVocê Morreu");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Você tomou {0} dano", danoFinal);
                            }
                            break;
                    }
                }
                Console.WriteLine("Fim de jogo");


            }
        }
    }


