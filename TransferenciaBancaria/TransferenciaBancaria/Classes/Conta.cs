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
    }
}
