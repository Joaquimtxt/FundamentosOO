using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Cavaleiro : Personagem
    {


        public override void Apresentar()
        {
            Console.WriteLine("Olá eu sou o " + this.Nome + ", sou da classe " + this.Categoria + ", estou no nível " + this.Nivel);
            Console.WriteLine(this.Nome + " Status: \nVida: " + this.Vida + "\nForça: " + this.Forca + "\n Agilidade: " + this.Agilidade + "\nInteligência: " + this.Inteligencia);
        }

    }
}
