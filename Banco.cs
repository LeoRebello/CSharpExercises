using System;
using bytebank;
using bytebank.titular;
class Banco

{   static void Main(string[] args)
    {
       
        ContaCorrente cliente1 = new ContaCorrente();
        cliente1.titular = new Cliente();
        cliente1.titular.Nome = "André Silva";
        cliente1.titular.Cpf = "15824104-31";
        cliente1.titular.Profissao = "Programador";
        cliente1.Conta = "10123-X";
        cliente1.Numero_agencia = 23;
        cliente1.Nome_agencia = "Agência Central";
        cliente1.Saldo = 100;

        ContaCorrente cliente2 = new ContaCorrente();
        cliente2.titular = new Cliente();
        cliente2.titular.Nome = "Amanda Santos";
        cliente2.titular.Cpf = "748392112-21";
        cliente2.titular.Profissao = "Médica";   
        cliente2.Conta = "10106-X";
        cliente2.Numero_agencia = 23;
        cliente2.Nome_agencia = "Agência Central";
        cliente2.Saldo = 100;

        cliente1.ExibirDados();
        Console.WriteLine();

        Console.WriteLine("Saldo de André pré transferência: " + cliente1.Saldo);
        Console.WriteLine("Saldo de Amanda pré transferência: "+ cliente2.Saldo);
        cliente1.Transferir(50, cliente2);
        Console.WriteLine("Saldo de André após transferência: "+ cliente1.Saldo);
        Console.WriteLine("Saldo de Amanda após transferência: " + cliente2.Saldo);


        Console.ReadKey();


    }
}
