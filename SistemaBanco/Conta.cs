using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaBanco {
    internal class Conta {
        public string Nome { get; set; }
        public string SNome { get; set; }
        public double Money { get; set; }


        public Conta(string nome, string snome) {
            Nome = nome;
            SNome= snome; 
        }
        public Conta(string nome, string snome, double depositoInicial) : this (nome, snome) {
            Deposito(depositoInicial);
            
        }

        public void Deposito(double money) {
           Money += money;
        }
        public void Saque (double money) {
            Money -= money + 5.0;
        }

        public override string ToString() {
            return "Nome: "+ Nome
                +"\nSobrenome: "+ SNome
                +"\nSaldo da conta: "
                +Money.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
