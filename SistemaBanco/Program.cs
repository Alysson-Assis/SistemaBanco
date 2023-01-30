using System;
using System.Globalization;

namespace SistemaBanco {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Vou precisar dos seu dados pessoais {Nome, Sobrenome, Data de Nascimento, CPF, RG, Tell ou Cell}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string snome = Console.ReadLine();
           /* Console.Write("Data de Nascimento: ");
            int dn = int.Parse(Console.ReadLine());
            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine());
            Console.Write("RG: ");
            int rg = int.Parse(Console.ReadLine());
            Console.Write("Tell: ");
            int tell = int.Parse(Console.ReadLine());
            Console.Write("Cell: ");
            int cell = int.Parse(Console.ReadLine());
            Console.WriteLine(); */

            Conta cont;

            Console.WriteLine("Deseja efetuar algum saque? S/N");
            string resp = Console.ReadLine();
            if (resp == "N" || resp == "n") {
                cont = new Conta(nome, snome);
                Console.WriteLine(cont);
            }
            else {
                Console.Write("Qual o valor de Deposito? :");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                cont = new Conta(nome, snome,depositoInicial);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cont);

            Console.WriteLine();
            Console.WriteLine("Efetuar um Deposito: ");
            double quant = double.Parse(Console.ReadLine());
            cont.Deposito(quant);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cont);
        }
    }
}

