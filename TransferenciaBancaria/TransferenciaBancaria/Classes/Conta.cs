using TransferenciaBancaria.Enum;

namespace TransferenciaBancaria.Classes
{
    public class Conta
    {
        private TipoConta tipoConta { get; set; }

        public double Saldo { get; set; }
        
        public double Credito { get; set; }

        public string Nome { get; set; }

        public Conta()
        {
        }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.tipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorASacar)
        {
            //Validação de saldo suficente
            if(this.Saldo - valorASacar < (this.Credito * -1))
            {
                System.Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.Saldo -= valorASacar;
            System.Console.WriteLine("O saldo atual da conta {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            System.Console.WriteLine("O saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTrasnferencia, Conta contaDestino)
        {
            if (Sacar(valorTrasnferencia))
            {
                contaDestino.Depositar(valorTrasnferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.tipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + " | ";
            return retorno;
        }
    }
}
