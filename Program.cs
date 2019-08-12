using System;

namespace contabanco
{
    class Program
    {
        static void Main(string[] args)
        {
            conta cliente = new conta (20,"Andre");
            conta cliente1 = new conta (60,"Paula");

            cartaoCredito cartao = new cartaoCredito(6684268426,new DateTime(2021,05,02));
            cartaoCredito cartao1 = new cartaoCredito(265956256,new DateTime(2025,10,15));

            nomeBanco nome = new nomeBanco("Banco do Brasil", 01);
            nomeBanco nome1 = new nomeBanco("Banrisul",041);

            contasBanco banco = new contasBanco(56,3500);
            contasBanco banco1 = new contasBanco(20,6000);

            Console.WriteLine($"Titular da conta {cliente.nome} e o seu codigo {cliente.codigo}");
            Console.WriteLine($"Titular da conta {cliente1.nome} e o seu codigo {cliente1.codigo}");

            Console.WriteLine($"Numero do cartao {cartao.numero} validade {cartao.data.ToString("MM/yyyy")}");
            Console.WriteLine($"Numero do cartao {cartao1.numero} validade {cartao1.data.ToString("MM/yyyy")}");

            Console.WriteLine($"{nome.nome} seu numero e {nome.agencia}");
            Console.WriteLine($"{nome1.nome} seu numero e {nome1.agencia}");

            Console.WriteLine($"Numero da conta{banco.numero}, saldo {banco.saldo} e seu limite e {banco.limite}");
            Console.WriteLine($"Numero da conta{banco1.numero}, saldo {banco1.saldo} e seu limite e {banco1.limite}");
        }
    }
}
