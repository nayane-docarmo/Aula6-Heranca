using System;

namespace Aula6_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Nayane";
            System.Console.WriteLine( cpf.Saudar() );
        }
    }
}
