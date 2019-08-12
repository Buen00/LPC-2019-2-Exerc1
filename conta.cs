using System;

namespace contabanco
{
    public class conta
    {
        public int codigo;
        public string nome;


        public conta(   int codigo,
                        string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }
    }
}