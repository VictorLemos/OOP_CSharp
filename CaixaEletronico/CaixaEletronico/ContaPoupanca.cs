using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.CaixaEletronico.Contas
{
    // : Herança 
    class ContaPoupanca : Conta, Tributavel
    {

        //sobrescrita de metodos override
        public override void Saca(double valor)
        {  
            this.Saldo -= valor;
        }

        //Regra de negocio onde a cada ano Conta Investimento e Conta poupança pagam tributo ao governo, que não acontece na conta corrente
        public double CalculaTributo()
        {
            return this.Saldo *  0.02;
        }
    }
}
