using System;
using SistemaBancario.Models;


    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Informe o nome do titular da conta.");
            string nomeTitular = Console.ReadLine();
            ContaCorrente conta = new ContaCorrente(nomeTitular);

            bool sair = false;
            while (!sair)
            {
            Console.WriteLine($"\nEscolha uma opção");
            Console.WriteLine($"1. Consultar saldo");
            Console.WriteLine($"2. Depositar");
            Console.WriteLine($"3. Sacar");
            Console.WriteLine($"4. Sair");

            int opcao;
            opcao = int.Parse(Console.ReadLine()); 
                switch (opcao)
                {
                   case 1:
                   conta.ConsultarSaldo();
                    break;
                   case 2:
                   Console.WriteLine($"Informe o valor de deposito: ");
                   decimal valorDeposito = decimal.Parse(Console.ReadLine());
                   conta.Depositar(valorDeposito);
                  break;
                  
                   case 3:
                   Console.WriteLine($"Informe o valor do saque: ");
                   decimal valorSaque = decimal.Parse(Console.ReadLine());
                   conta.Sacar(valorSaque);
                   break;
                  
                   case 4:
                   sair = true;
                 break;

                   default:
                   Console.WriteLine("Opção invalida");
                  break;
                   }
                }
                   
            }
        }
    





   
  