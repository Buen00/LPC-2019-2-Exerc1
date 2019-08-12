using System;

namespace contabanco
{
    public class cartaoCredito
    {
        public long numero;
        public DateTime data;
        conta conta;

        public cartaoCredito(   long numero,
                                DateTime data
        )
        {
            this.numero = numero;
            this.data = data;
        }
    }
}