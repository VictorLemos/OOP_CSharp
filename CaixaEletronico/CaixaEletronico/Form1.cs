using Oop.CaixaEletronico.Contas;
using Oop.CaixaEletronico.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop.CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            //Criando uma lista para armazenar as contas..
            var contas = new List<Conta>();

            var cc = new ContaCorrente();
            var cp = new ContaPoupanca();
            var ci = new ContaInvestimento();

            //Passo ao Titular um Cliente..
            cc.Titular = new Cliente("Victor", "43.922.933-2", "Rua: O loco", 25, "399.233.982-11");
            cc.Deposita(20);
            cc.Saca(10);
            //adicionando uma Conta Corrente a lista...
            contas.Add(cc);

            cp.Titular = new Cliente("Rosana", "22.932.823-8", "Rua: Das Rosas", 21, "219.823.992-66");
            cp.Deposita(100);
            cp.Saca(60);
            contas.Add(cp);

            ci.Titular = new Cliente("Rogério", "33.256.653-1", "Rua: Garcia", 17, "333.222.555-55");
            contas.Add(ci);

            foreach (Conta conta in contas)
            {
                if (conta.Titular.PodeAbrirConta())
                {
                    MessageBox.Show("Pode abrir uma Conta\n"

                            + conta.Titular.ToString()
                            + "\nSaldo da conta: " + conta + " R$" + conta.Saldo);
                }
                else
                {
                    MessageBox.Show("Nao pode abrir Conta: ");
                }
            }
        }
    }
}
