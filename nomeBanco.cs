namespace contabanco
{
    public class nomeBanco
    {
        public string nome;
        public int agencia;
        public int numero;

       public nomeBanco(  string nome, 
                            int agencia
        )
        {
            this.nome = nome;
            this.agencia = agencia;
        }      
        public nomeBanco(int numero){
            this.numero = numero;
        }

    }
}