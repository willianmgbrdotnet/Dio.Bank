using System;

namespace Dio.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 1e6, 1e5, "Willian Alves Epifanio");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}