using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCS.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "test";// Dynamic é um tipo de dado que pode armazenar qualquer tipo de valor, e o tipo do valor é determinado em tempo
                                       // de execução. Isso significa que o tipo do valor pode ser alterado durante a execução do programa, e o compilador
                                       // não irá verificar se as operações realizadas com o valor são válidas para o tipo atual do valor. O uso de dynamic pode ser útil em situações
                                       // onde o tipo do valor não é conhecido em tempo de compilação, ou quando se deseja realizar operações que não são suportadas pelo tipo estático
                                       // do valor.
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();// ExpandoObject é uma classe que implementa a interface IDynamicMetaObjectProvider
                                                               // e permite criar objetos dinâmicos que podem ter propriedades e métodos adicionados
                                                               // em tempo de execução. Isso significa que é possível adicionar propriedades e métodos
                                                               // a um objeto ExpandoObject sem precisar definir uma classe para ele, e o tipo do objeto
                                                               // pode ser alterado durante a execução do programa.

            aluno.Nome = "Pedro";
            aluno.nota = 10.0;
            aluno.Idade = 25;
        }
    }
}
