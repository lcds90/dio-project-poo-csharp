using System;

namespace dio_project_poo
{
    public class Conta
    {
        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
        }
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                this.SaldoAtual();
                return false;
            }

            this.Saldo -= valorSaque;
            this.SaldoAtual();
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            this.SaldoAtual();
        }

        public void SaldoAtual()
        {
            Console.WriteLine("Saldo atual da conta de {0} é R$ {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
                Console.WriteLine("Foi transferido: R$ {0} de {1} para {2}", valorTransferencia, this.Nome, contaDestino.Nome);

            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Tipo de Conta: " + this.TipoConta + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito;
            return retorno;
        }
    }
}