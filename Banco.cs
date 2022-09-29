using System;
using bytebank;
class Banco

{   static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.titular = "André Silva";
        conta1.conta = "10123-X";
        conta1.numero_agencia = 23;
        conta1.nome_agencia = "Agência Central";
        conta1.saldo = 100;

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = "Amanda Nogueira";
        conta2.conta = "10106-X";
        conta2.numero_agencia = 23;
        conta2.nome_agencia = "Agência Central";
        conta2.saldo = 100;

        conta1.ExibirDados();
        Console.WriteLine();

        Console.WriteLine("Saldo de André pré transferência: " + conta1.saldo);
        Console.WriteLine("Saldo de Amanda pré transferência: "+ conta2.saldo);
        conta1.Transferir(50, conta2);
        Console.WriteLine("Saldo de André após transferência: "+ conta1.saldo);
        Console.WriteLine("Saldo de Amanda após transferência: " + conta2.saldo);

        Console.ReadKey();


    }
}
