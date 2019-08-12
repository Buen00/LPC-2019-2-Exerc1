namespace contabanco
{
    public class contasBanco
    {
        public int numero;
        public double saldo;
        public float limite;
        public int agencia;

        public contasBanco( int  numero,
                            double saldo,
                            float limite = 100
                        )
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = 100;
        }

       public void depositar (double valor){
            this.saldo += valor;
        }

        double saldoDisponivel(){
            return this.saldo + this.limite;
        }

        public void sacar(double valor){
            this.saldo += valor;
        }

        public void tranferencia(string cliente, double valor){

            if(this.saldo >= valor){
                this.saldo -= valor;
                cliente += valor;
            }
        }

        public contasBanco(int agencia){
            this.agencia = agencia;
        }

    }
}