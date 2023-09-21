using System;

namespace SistemaBancario.Models
{
        public class ContaCorrente
        {
            public string titular;
            private decimal saldo;


        public ContaCorrente(string titular)
        {
            this.titular = titular;
            this.saldo = 0.0M;
        }

        public void ConsultarSaldo()
        {
        Console.WriteLine($"Saldo disponivel na conta de {titular}: R${saldo}");
        }
       
        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Deposito de R${valor:F2} realizado com sucesso");
            ConsultarSaldo();
         }

        public void Sacar(decimal valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
                    ConsultarSaldo();
                }
                else
                {
                    Console.WriteLine("Saque não realizado");
                }
            }
            
        }
        }
}










