using Oop.CaixaEletronico.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oop.CaixaEletronico
{
    // Responsavel por receber todas essas contas e acumular valor total desses Tributos
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }

        internal void Acumula(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
