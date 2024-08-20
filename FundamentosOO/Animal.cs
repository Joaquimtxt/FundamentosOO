using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public abstract class Animal
    {
        //Declaração de Atributo
        public string Especie { get; set; }
        public string Nome { get; set; }

        //Declaração de um Método
        public abstract void emitirSom();
    }
}
