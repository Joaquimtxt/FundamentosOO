using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        public virtual void Apresentar() { }
        public virtual void Evoluir() { }

        public virtual int Atacar()
        {
            int pontosAtaque = 0;

            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Vida) / 5;
            return pontosAtaque;


        }
        public virtual int Defender()
        {
            int pontosDefesa = 0;

            pontosDefesa = (this.Inteligencia + (this.Agilidade * 2) + this.Vida + this.Forca) / 5;
            return pontosDefesa;
        }

        public void Confronto(Personagem p)

        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.Atacar();
                int valorDefesaInimigo = p.Defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 5;
                }

                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano recebido por: " + p.Nome + " Foi de " + danoDeVida);
                Console.WriteLine("Sua vida agora é de:" + p.Vida);

                int valorAtaqueInimigo = p.Atacar();
                int valorDefesa = this.Defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 5;
                }

                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano recebido por: " + this.Nome + " Foi de " + danoDeVida2);
                Console.WriteLine("Sua vida agora é de:" + this.Vida);

                if (p.Vida <= 0)
                {

                    Console.WriteLine("O " + this.Nome + " venceu!");
                    this.Evoluir();
                    Console.WriteLine("Nível " + this.Nivel);
                    vencedor = true;

                }
                if (this.Vida <= 0)
                {
                    Console.WriteLine("O " + p.Nome + " venceu!");
                    p.Evoluir();
                    Console.WriteLine("Nível" + p.Nivel);
                    vencedor = true;
                }
            }
        }
    }
}
