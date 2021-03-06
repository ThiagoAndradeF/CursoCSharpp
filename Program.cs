using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CentralDeExercicios central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência- Fundamentos", Inferencia.Executar},
                {"Interpolação- Fundamentos", Interpolacao.Executar},
                {"Notação Ponto- Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados do Console- Fundamentos", LendoDados.Executar},
                {"Formatando Número- Fundamentos", FormatandoNumeros.Executar},
                {"Converter números- Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição- Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios- Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário- Fundamentos", OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", IfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Construtores- Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno- Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos-Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos- Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo -Classes e Metodos", DesafioAtributo.Executar},
                {"Params -Classes e Metodos", Params.Executar},
                {"Parametros Nomeados-Classes e Metodos", ParametrosNomeados.Executar},
                {"GetSet-Classes e Metodos", GetSet.Executar},
                {"Props -Classes e Metodos", Props.Executar},
                {"Readonly -Classes e Metodos", Readonly.Executar},
                {"Exemplo Enum -Classes e Metodos", ExemploEnum.Executar},
                {"Struct -Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classe -Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs Referência -Classes e Metodos", ValorVsReferencia.Executar},
                {"Parâmetros por referência -Classes e Metodos",ParametrosPorReferencia.Executar},
                {"Parâmetr Padrão-Classes e Metodos",ParametroPadrao.Executar},

                //Coleções

                {"Arrays - Coleções ", Colecoes.Array.Executar},
                {"ArrayList - Coleções ", Colecoes.ColecoesArrayList.Executar},
                {"List - Coleções ", Colecoes.List.Executar},
                {"Set - Coleções ", Colecoes.Set.Executar},
                {"Queue - Coleções ", Colecoes.Queue.Executar},
                {"Igualdade Equals e GetHashCode - Coleções ", Colecoes.IgualdadeEqualsEGetHashCode.Executar},
                {"Stack - Coleções ", Colecoes.ColecoesStack.Executar},
                {"Dictionary - Coleções ", Colecoes.ColecoesDictionary.Executar},

                //Orientação a Objeto


                {"Herança - OO ", Herança.Executar},
                {"Contrutor this - OO ", ConstrutorThis.Executar},
                //{"Contrutor this - OO ", Encapsulamentoo.Executar},
                {"Polimorfismo - OO ", Polimorfismo.Executar},
                {"Abstract - OO ", Abstract.Executar},
                {"Interface - OO ", Interface.Executar},
                {"Sealed - OO ", Sealed.Executar},
                
                //Metodos e Funções
                {"Exemplo Lambda - Métodos e Funcoes ", ExemploLambda.Executar},
                {"Lambda Delegate - Métodos e Funcoes ", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funcoes ", UsandoDelegate.Executar},
                





            });

            central.SelecionarEExecutar();
        }
    }
}