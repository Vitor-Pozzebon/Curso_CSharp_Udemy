using System;
using System.Globalization;

namespace Construtores {
    class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5;
        }

        public override string ToString() {
            return "Conta: " + NumeroConta +
                ", Titular: " + Titular +
                ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
