using CursoCS.ClassesEMetodos;
using CursoCS.Colecoes;
using CursoCS.EstruturaDeControle;
using CursoCS.Exercitando;
using CursoCS.Fundamentos;
using CursoCS.OO;
using CursoCS.MetodosEFuncoes;
using CursoCS.Excecoes;
using CursoCS.Api;
using CursoCS.TopicosAvancados;
using Encapsulamento;

using System;
using System.Collections.Generic;
using static CursoCS.ClassesEMetodos.Moto;
using static CursoCS.Colecoes.Produto;
using static CursoCS.Exercitando.Character;

namespace CursoCS {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos

                {"Primeirod Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores e Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},

                //Estrutura de Controle

                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura ElseIf - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e Metodos

                {"Membros - ClassesEMetodos", Membros.Executar},
                {"Construtores - ClassesEMetodos", Construtores.Executar},
                {"Metodos Com Retorno - ClassesEMetodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - ClassesEMetodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - ClassesEMetodos", AtributosEstaticos.Executar},
                {"Params - ClassesEMetodos", Params.Executar},
                {"Parametros Nomeados - ClassesEMetodos", ParametrosNomeados.Executar},
                {"Getters e Setters - ClassesEMetodos", GettersESetters.Executar},
                {"Ready Only - ClassesEMetodos", ReadyOnly.Executar},
                {"Exemplo Enum - ClassesEMetodos", ExemploEnum.Executar},
                {"Struct - ClassesEMetodos", Struct.Executar},
                {"Struct VS Classes - ClassesEMetodos", StructVsClasse.Executar},
                {"Valor VS Referencia - ClassesEMetodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - ClassesEMetodos", ParametrosPorReferencia.Executar},
                {"Parametros com valor Padrão - ClassesEMetodos", ParametroPadrao.Executar},


                // Coleções
                {"Arrays - Coleções", Colecoes.Array.Executar},
                {"Colecoes Listas - Coleções", ColecoesListas.Executar},
                {"Colecoes ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Colecoes Sets - Coleções", ColecoesSet.Executar},
                {"Colecoes Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Colecao Stack - Coleções", ColecaoStack.Executar},
                {"Colecao Dictcionary - Coleções", ColecoesDictcionary.Executar},

                //Orientado a Objetos
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", Encapsulament.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas Delegate - Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Metodos e Funções", UsandoDelegate.Executar},
                {"Delegate Com Funcoes Anonimas - Metodos e Funções", DelegateComFuncoesAnonimas.Executar},
                {"Delegates Como Parametros - Metodos e Funções", DelegatesComParametros.Executar},
                {"Metoodos de ESxtensão - Metodos e Funções", MetodosDeExtensao.Executar},

                //Exceçoes
                {"Primeira Excecao - Excecoes", PrimeiraExcecao.Executar},
                {"Execoes Personalizadas - Excecoes", ExcecoesPersonalizadas.Executar},

                //APIs
                {"Primeiro Arquivo - APIs", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - APIs", LendoArquivos.Executar},
                {"Exemplo FileInfo - APIs", ExemploFileInfo.Executar},
                {"Exemplo Diretorios - APIs", Diretorios.Executar},
                {"Exemplo Directory Info - APIs", ExemploDirectoryInfo.Executar},
                {"Exemplo Data Time - APIs", ExemploDataTime.Executar},
                {"Exemplo Time Span- APIs", ExemploTimeSpan.Executar},

                //Topicos Avançados
                {"Exemplo LINQ 1- Assunto Avançado", LINQ1.Executar},
                {"Exemplo LINQ 2- Assunto Avançado", LINQ2.Executar},
                {"Exemplo Nullables- Assunto Avançado", Nullables.Executar},
                {"Exemplo Dynamics- Assunto Avançado", Dynamics.Executar},
                {"Exemplo Generic Avançado", Dynamics.Executar},
                



                //Praticando Exercicios
                {"Exercitando Base de Herança - Exercitando", Base.Executar},
                {"Personagem - Exercitando", Personagem.Executar},
                {"Exercitando Lista - Exercitando", ExercitantoLista.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}