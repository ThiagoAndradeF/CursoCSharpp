using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
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


            });

            central.SelecionarEExecutar();
        }
    }
}