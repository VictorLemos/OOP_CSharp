using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.CaixaEletronico.Contas
{
    class ContaInvestimento : Conta, Tributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        //Regra de negocio onde a cada ano Conta Investimento e Conta poupança pagam tributo ao governo, que não acontece na conta corrente
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

    }
}
