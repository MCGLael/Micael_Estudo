using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //Importando a biblioteca para realizar conversão de padrão para diferentes moedas com o 'CultureInfo.InvariantCulture'

namespace CursoCS.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            //Formantando numeros
            double Valor = 75.937980819;
            //F1 serve para formatar o numero com uma casa decimal, o 'F' é para formatar o numero e o '1' é para dizer quantas casas decimais eu quero
            Console.WriteLine(Valor.ToString("F1"));
            //C corresponde a Currency, ou seja, moeda, o 'C' é para formatar o numero como moeda e o '2' é para dizer quantas casas decimais eu quero
            Console.WriteLine(Valor.ToString("C2"));
            //P corresponde a Percentual, ou seja, porcentagem, o 'P' é para formatar o numero como porcentagem e o '2' é para dizer quantas casas decimais eu quero
            Console.WriteLine(Valor.ToString("P2"));
            //colocando #.## tambem formata a quantidade de casas decimais com o .# correspondendo a quantidade de casas decimais
            Console.WriteLine(Valor.ToString("#.##"));
            //Agora para converter o valor para sua respectiva moeda, utilizando o 'cultureInfo.InvariantCulture'
            CultureInfo Pt = new CultureInfo("pt-BR"); //Criando uma variavel do tipo 'CultureInfo' e passando o parametro "pt-BR" para dizer que quero a moeda do Brasil
            Console.WriteLine(Valor.ToString("C3", Pt));
            //Agora para Ingles
            CultureInfo En = new CultureInfo("en-US"); //Criando uma variavel do tipo 'CultureInfo' e passando o parametro "en-US" para dizer que quero a moeda dos estados unidos
            Console.WriteLine(Valor.ToString("C2", En));
            //Agora vamos adicionar zeros a esquerda utilizando o 'D' mais a quantidade de digitos, o Console vai adicionar zeros a esquerda até completar a quantidade de digitos que eu quero
            int Val2 = 256;
            Console.WriteLine(Val2.ToString("D10"), En);

        }
    }
}
