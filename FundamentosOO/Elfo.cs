using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Elfo : Personagem
    {
        public override void Apresentar()
        {
            Console.WriteLine("Olá eu sou o " + this.Nome + ", sou da classe " + this.Categoria + ", estou no nível " + this.Nivel);
            Console.WriteLine(this.Nome + " Status:");
            Console.WriteLine("Vida: " + this.Vida);
            Console.WriteLine("Força: " + this.Forca);
            Console.WriteLine("Agilidade: " + this.Agilidade);
            Console.WriteLine("Inteligência: " + this.Inteligencia);
        }

        public override void Evoluir()
        {
            this.Nivel = this.Nivel + 1;
            this.Vida = this.Vida + 100;
            this.Forca = this.Forca + 25;
            this.Agilidade = this.Agilidade + 25;
            this.Inteligencia = this.Inteligencia + 25;
        }

    }
}
