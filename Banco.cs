using System;
using bytebank;
using bytebank.titular;
class Banco

{   static void Main(string[] args)
    {
       
        ContaCorrente cliente1 = new ContaCorrente();
        cliente1.titular = new Cliente();
        cliente1.titular.nome = "André Silva";
        cliente1.titular.cpf = "15824104-31";
        cliente1.titular.profissao = "Programador";
        cliente1.conta = "10123-X";
        cliente1.numero_agencia = 23;
        cliente1.nome_agencia = "Agência Central";
        cliente1.saldo = 100;

        ContaCorrente cliente2 = new ContaCorrente();
        cliente2.titular = new Cliente();
        cliente2.titular.nome = "Amanda Santos";
        cliente2.titular.cpf = "748392112-21";
        cliente2.titular.profissao = "Médica";   
        cliente2.conta = "10106-X";
        cliente2.numero_agencia = 23;
        cliente2.nome_agencia = "Agência Central";
        cliente2.saldo = 100;

        cliente1.ExibirDados();
        Console.WriteLine();

        Console.WriteLine("Saldo de André pré transferência: " + cliente1.saldo);
        Console.WriteLine("Saldo de Amanda pré transferência: "+ cliente2.saldo);
        cliente1.Transferir(50, cliente2);
        Console.WriteLine("Saldo de André após transferência: "+ cliente1.saldo);
        Console.WriteLine("Saldo de Amanda após transferência: " + cliente2.saldo);

        Console.ReadKey();


    }
}
