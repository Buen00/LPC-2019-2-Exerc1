namespace contabanco
{
    public class gerente
    {
        public string nome;
        public double salario;

        public void aumentaSalario(){

           this.salario += this.salario * 0.1;
        }

        public void AumentaSalario ( double taxa ){

            this.salario += this.salario * taxa ;
        }
 
    }
}