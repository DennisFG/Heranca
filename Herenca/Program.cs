using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(20);
            var novaConta = ConverteConta<ContaCorrente, ContaInvestimento>(conta);
            Console.WriteLine($"{novaConta.Saldo}");

                        //var conta1 = new ContaCorrente(10);

            //Console.WriteLine($"{conta.Saldo}");
            //Console.WriteLine($"{conta1.Saldo}");

            //Transferencia(10, conta, conta1);

            //Console.WriteLine($"{conta.Saldo}");
            //Console.WriteLine($"{conta1.Saldo}");
            //Console.WriteLine($"{conta.Saldo}");
        }

        public static T2 ConverteConta<T1, T2>(T1 contaATransformar) where T1 : Conta where T2 : Conta
        {
            T2 novaConta = Activator.CreateInstance<T2>();
            novaConta.Depositar(contaATransformar.Saldo);
            contaATransformar = null;
            return novaConta;
        }

        public static void Transferencia(int valor, ContaCorrente contaOrigem, ContaCorrente contaDestino)
        {
            contaOrigem.Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
