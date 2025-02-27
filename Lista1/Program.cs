using System;

namespace Lista1
{
    class Program
    {
        static void Ex1()
        {
            //Escreva um programa que armazene em variáveis o seu nome, sua idade e a cidade onde reside. Na sequência exiba o conteúdo destas variáveis na tela.
            string nome;
            int idade;
            string cidade;
            Console.WriteLine("Digite seu nome abaixo:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade abaixo:");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade abaixo:");
            cidade = Console.ReadLine();

            Console.WriteLine($"Seu nome: {nome}\nSua idade: {idade}\nSua cidade: {cidade}");

        }
        static void Ex2()
        {
            //Escreva um programa que leia um número inteiro, calcule e exiba o resultado do dobro deste número.
            int num;
            Console.WriteLine("Digite um número abaixo:");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"O dobro desse número é {num * 2}");
        }
        static void Ex3()
        {
            //Escreva um programa que leia um número inteiro, calcule e exiba o resultado do quadrado deste número.
            int num;
            Console.WriteLine("Digite um número abaixo:");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"O quadrado desse número é {Math.Pow(num,2)}");
        }
        static void Ex4()
        {
            //Escreva um programa que calcule e exiba o resultado da seguinte expressão matemática: (Dica: O usuário deverá informar os valores para as variáveis A, B e C) 
            //A² *5 – C / (B – A % 4)
            int numA, numB, numC;
            Console.WriteLine("Expressão: A² *5 – C / (B – A % 4) \n");
            Console.WriteLine("Digite o valor de A:");
            numA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            numB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            numC = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da expressão é {(Math.Pow(numA, 2)) * 5 - numC / (numB - numA % 4)}");

        }
        static void Ex5()
        {
            int idade;
            Console.WriteLine("Digite sua idade abaixo:");
            idade = Int32.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade, pode acessar este app :)");
            }
            else
            {
                Console.WriteLine("Você é menor de idade, não pode acessar este app :(");
            }
        }
        static void Ex6()
        {
            //Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar, realize o cálculo da conversão de moeda (de Reais para Dólares) e exiba na tela o resultado.
            double preco = 5.8752;
            Console.WriteLine("Digite o valoe em Reais(R$):");
            double reais = Double.Parse(Console.ReadLine());
            string dolars = (reais / preco).ToString("0.00");
            Console.WriteLine($"O valor R${reais} em dolares é U${dolars}");


        }
        static void Ex7()
        {
            /*Escreva um programa que leia o nome de duas pessoas e ao final exiba: 
            •	O nome das duas pessoas com todos os caracteres maiúsculos 
            •	A quantidade de caracteres de cada nome
            •	Apenas os três primeiros caracteres de cada nome*/
            string nome1;
            string nome2;
            Console.WriteLine("Digite o primeiro nome:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome:");
            nome2 = Console.ReadLine();
            Console.WriteLine($"{nome1.ToUpper()}, {nome2.ToUpper()}\n {nome1.Length}, {nome2.Length}\n{nome1.Substring(0, 3)}, {nome2.Substring(0, 3)}");

        }
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("\nDigite o número correspondente ao exercício:\n\t1-nome, idade, endereço\n\t2-dobro do número\n\t3-quadrado do número\n\t4-A² *5 – C / (B – A % 4)\n\t5-maior de idade\n\t6-reais pra dolar\n\t7-dois nomes\n\t8-sair");
                int sel = Int32.Parse(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        Ex1();
                        break;
                    case 2:
                        Ex2();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 7:
                        Ex7();
                        break;
                    default:
                        continua = false;
                        break;
                }
            }
        }
    }
}
