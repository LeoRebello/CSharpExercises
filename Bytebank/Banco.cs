using System;
using bytebank;
using bytebank.titular;
class Banco

{   static void Main(string[] args)
    {
       
        ContaCorrente cliente1 = new ContaCorrente("10123 -X", 23, "Agência Central");
        cliente1.titular = new Cliente("André Silva", "15824104 - 31", "Programador");
        cliente1.Saldo = 100;
        //Como trazer o titular para o método construtor ContaCorrente?

        ContaCorrente cliente2 = new ContaCorrente("10106-X", 23, "Agência Central");
        cliente2.titular = new Cliente("Amanda Santos", "748392112-21", "Médica");
        cliente2.Saldo = 100;

        cliente1.ExibirDados();
        Console.WriteLine();

        Console.WriteLine("Saldo de André pré transferência: " + cliente1.Saldo);
        Console.WriteLine("Saldo de Amanda pré transferência: "+ cliente2.Saldo);
        cliente1.Transferir(50, cliente2);
        Console.WriteLine("Saldo de André após transferência: "+ cliente1.Saldo);
        Console.WriteLine("Saldo de Amanda após transferência: " + cliente2.Saldo);

        Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContas);

        Console.ReadKey();


    }
}
