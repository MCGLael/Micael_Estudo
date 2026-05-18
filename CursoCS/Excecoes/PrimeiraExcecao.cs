using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.Excecoes
{
    public class Conta
    {
        public double Valor;

        public Conta (double valor)
        {
            Valor = valor;
        }
    
    public void Sacar(double saque)
        {
            if (saque > Valor)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }
                    Valor -= saque;
                
                

            }

     }
    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1500.00);

            try{
                conta.Sacar(2500);
                Console.WriteLine("Retirada com sucesso");
            }catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Valor da conta:{0}", conta.Valor);
            }

            
        }
    }
}
