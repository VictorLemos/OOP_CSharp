using Oop.CaixaEletronico.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.CaixaEletronico.Contas
{
    //Abstract proibo que seja instanciada
    abstract class Conta
    {
        public int Numero { get; set; }

        // protected deixa com que as classes filhas acessem 
        public double Saldo { get; protected set; }

        public Cliente Titular { get; set; }

        // Toda classe filha é obrigada implementar o metodo..
        public abstract void Saca(double valor);

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }

}
