using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* --- Código da Segunda Aula ---
            
            int numeroConta;
            numeroConta = 1;
            double saldo = 100.00;
            double valor = 10.00;
            double saldoAposSaque = saldo - valor;

            MessageBox.Show("O saldo atual é: R$"+saldoAposSaque);
            
             */

            /* --- Código da Terceira Aula ---
            
            double saldo = 100.00;
            double valor = -3.00;
            bool podeSacar = (valor <= saldo) && (valor > 0);
            bool valorInvalido = (valor == 0 || valor < 0);

            if(podeSacar)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else if (valorInvalido)
            {
                MessageBox.Show("Informe um valor válido!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }

            */

            /* --- Código da Quarta Aula ---
            
            double valorInvestido = 2000.00;
            int cont = 1;

            while(cont <= 12)
            {
                valorInvestido *= 1.01;
                cont += 1;
            }
            MessageBox.Show("Valor investido agora é: R$"+valorInvestido);

            */

            /* --- Código da Quinta Aula ---
            
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim José";
            umaConta.saldo = 2000.00;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva Xavier";
            outraConta.saldo = 1500.00;

            MessageBox.Show("O titular da conta "+umaConta.numero+" é: "+umaConta.titular);

            */

            /* --- Código da Sexta Aula --- 
            
            Conta guilherme = new Conta();
            Conta mauricio = new Conta();
            guilherme.saldo = 1500.00;
            guilherme.titular = "Guilherme Silva";
            mauricio.saldo = 2000.00;
            mauricio.titular = "Maurício Nunes";

            guilherme.Transfere(200.00, mauricio);

            MessageBox.Show("O saldo do "+guilherme.titular+" é: R$"+guilherme.saldo);
            MessageBox.Show("O saldo do " + mauricio.titular + " é: R$" + mauricio.saldo);

            */

            /* --- Código da Sétima Aula --- 
            
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.cliente = cliente;
            cliente.nome = "Victor";
            conta.cliente.rg = "12345678-9";

            MessageBox.Show(cliente.rg);

            */

            Conta conta = new Conta();
            conta.Deposita(1000.00);

            conta.Saca(200.00);
            conta.Saca(100.00);
            conta.Titular = new Cliente();
            conta.Titular.nome = "Tiago";
            MessageBox.Show("O saldo atual é: R$"+conta.Saldo);
        }
    }
}