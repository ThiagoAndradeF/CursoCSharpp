﻿using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
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


            });

            central.SelecionarEExecutar();
        }
    }
}