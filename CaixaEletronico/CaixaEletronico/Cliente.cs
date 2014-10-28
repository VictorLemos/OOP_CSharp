using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.CaixaEletronico.Usuario
{
    class Cliente
    {
        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Endereco { get; set; }

        public int Idade { get; set; }


        public string Cpf { get; set; }

        //Aqui forço no momento da Instancia que um objeto não seja criado sem nome..
        //Garantem a passagem de valores para a classe!
        //Usar sempre que um parametro é obrigatorio para aquela calsse..
        public Cliente(string nome, string rg, string endereco, int idade, string cpf)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Endereco = endereco;
            this.Idade = idade;
            this.Cpf = cpf;
        }

        public bool PodeAbrirConta()
        {
            bool maiorDeIdade = (this.Idade >= 18);
            bool temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade  && temCpf);
        }

        //Transforma uma Instancia de um objeto em uma String..
        public override string ToString()
        {
            return  "Nome do titular da conta: " + this.Nome
                     + "\nRG: " + this.Rg
                     + "\nEndereco: " + this.Endereco
                     + "\nIdade: " + this.Idade
                     + "\nCPF: " + this.Cpf;
                           
        }
    }
}
