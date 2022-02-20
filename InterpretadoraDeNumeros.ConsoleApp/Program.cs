using System;

/*
 Você trabalha para um banco, que recentemente comprou uma máquina muito engenhosa para auxiliar na leitura de cartas e faxes enviados para o escritório-central. Esta máquina escaneia os documentos em papel e produz um arquivo com um grande número de entradas, sendo que cada uma tem este formato:

     __  __        __   __  __   __   __   __ 
  |  __| __| |__| |__  |__    | |__| |__| |  |
  | |__  __|    |  __| |__|   | |__|  __| |__|

Cada entrada possui 4 linhas, e cada linha possui 40 caracteres. 

As 3 primeiras linhas contém o número da conta, utilizando pipes e underscores, e a quarta linha é vazia. 

Cada número de conta possui nove dígitos (entre 0 e 9). Cada arquivo pode conter até 500 registros. 

Sua tarefa é desenvolver um programa que obtenha esse arquivo e devolva a lista de contas.

 */

namespace InterpretadoraDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada :");
            string texto = "     __  __      __  __  __  __  __  __ " + Environment.NewLine+
                           " |   __| __||__||__ |__    ||__||__||  |" + Environment.NewLine+
                           " |  |__  __|   | __||__|   ||__| __||__|";

            Console.Write(texto); 

            System.IO.StringReader entrada = new System.IO.StringReader(texto);

            string primeiraLinha = entrada.ReadLine();

            char[] primeiraChar = primeiraLinha.ToCharArray();

            string segundaLinha = entrada.ReadLine();

            char[] segundaChar = primeiraLinha.ToCharArray();

            string terceiraLinha = entrada.ReadLine();

            char[] terceiraChar = primeiraLinha.ToCharArray();

            string linha1 = "";
            string linha2 = "";
            string linha3 = "";

            int contador = 0;

            for (int i = 0; i <= 39; i++)
            {

                linha1 = linha1 + primeiraChar[i];
                linha2 = linha2 + segundaChar[i];
                linha3 = linha3 + terceiraChar[i];


                if (linha1 == "    " && linha2 == " |  " && linha3 == " |  ")  
                    Console.Write("1");
                
                if (linha1 == " __ " && linha2 == " __|" && linha3 == "|__ ")
                    Console.Write("2");

                if (linha1 == " __ " && linha2 == " __|" && linha3 == "__|")
                    Console.Write("3");

                if (linha1 == "    " && linha2 == "|__|" && linha3 == "   |")
                    Console.Write("4");

                if (linha1 == " __ " && linha2 == "|__ " && linha3 == " __|")
                    Console.Write("5");

                if (linha1 == " __ " && linha2 == "|__ " && linha3 == "|__|")
                    Console.Write("6");

                if (linha1 == " __ " && linha2 == "   |" && linha3 == "   |")
                    Console.Write("7");
                
                if (linha1 == " __ " && linha2 == "|__|" && linha3 == "|__|")
                    Console.Write("8");


                if (linha1 == " __ " && linha2 == "|__|" && linha3 == " __|")
                    Console.Write("9");

                if (linha1 == " __ " && linha2 == "|  |" && linha3 == "|__|")
                    Console.Write("0");

                contador = contador + 1;

                

                if (contador == 4)
                {
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                    contador = 0;
                }

                
            }
            Console.ReadLine();
        }
    }
}
