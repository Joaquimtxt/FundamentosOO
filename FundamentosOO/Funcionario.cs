using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + this.Nome + " tenho " + this.Idade + " anos, sou um " + this.Cargo + ", e meu salário é de R$" + this.Salario);
        }
    }
}
