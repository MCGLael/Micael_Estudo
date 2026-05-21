using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Iniciante
{
	public class Converte
	{
		double X;
		public Converte(double x)
		{
			X = x;

		}
		
		public double CelsiusParaFahrenheit()
        {
			double valor = X * 1.8 + 32;
			return valor;
		}
        public double FahrenheitParaCelsius()
        {
			double valor = (X - 32) * (5.0 / 9.0);
			return valor;
        }
    }
	public class ConversorTemperatura
	{
        public static void Executar()
        {
			Console.WriteLine("O que deseja converter?\n1: Celsius -> Farenheit\n2: Farenheit -> Celsius");
			int.TryParse(Console.ReadLine(), out int opc);
			switch (opc)
			{
				case 1:
					Console.Write("Insira o valor em Celsius: ");
                    if (!double.TryParse(Console.ReadLine(), out double v))
                    {
                        Console.WriteLine("Valor Invalido, encerrando programa...");
                        return;
                    }
                    Converte c = new Converte(v);
                    Console.WriteLine($"O valor {v}ºCelsius convertido em Fahrenheit é: {c.CelsiusParaFahrenheit()} ");
                    break;
				case 2:
					Console.Write("insira o valor em Farenheit: ");
					if(!double.TryParse(Console.ReadLine(), out double valor))
					{
						Console.WriteLine("Valor Invalido, encerrando programa...");
						Console.ReadKey();
						return;
					}
					Converte f = new Converte(valor);
					Console.WriteLine($"O Valor {valor}º Fahrenheit convertido em Celsius é: {f.FahrenheitParaCelsius()} ");
					break;
					default:
					Console.WriteLine("Valor Invalido, encerrando programa...");
					Console.ReadKey();
					return;
            }
			
			
			
			
		}
	}
}