using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            this.Velocidade += 20;
            if (this.Velocidade > 262)
            {
                Console.WriteLine("O carro bateu e explodiu");
            }
            else
            {
                Console.WriteLine("A velocidade Atual é: " + this.Velocidade + "km/h");
            }

        }
        public void Desacelerar()
        {
            this.Velocidade -= 20;
            if (this.Velocidade <= 0)
            {
                Console.WriteLine("O carro parou");
            }
            else
            {
                Console.WriteLine("A velocidade Atual é: " + this.Velocidade + "km/h");
            }
        }
    }

}
