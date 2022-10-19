using System;
using System.Drawing;
using bytebank.titular;


namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        
        public string Conta { get; set; }
        public int Numero_agencia { get; set; }
        public string Nome_agencia { get; set; }
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = value;
                }
            }
        }

        public bool Sacar(double valor)
        {
            if (valor < saldo)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > saldo)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }

        }

        public void ExibirDados()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número Agencia: " + Numero_agencia);
            Console.WriteLine("Nome da Agencia: " + Nome_agencia);
            Console.WriteLine("Saldo: " + Saldo);

        }

    }
}
     
