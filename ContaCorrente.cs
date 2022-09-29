using System; 

namespace bytebank
{
    public class ContaCorrente
    {
       public string titular;
       public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if(valor < saldo)
            {
                return false;
            }
            if(valor < 0 )
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
            if(valor < 0)
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
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Número Agencia: " + numero_agencia);
            Console.WriteLine("Nome da Agencia: " + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);

        }
    }
}
