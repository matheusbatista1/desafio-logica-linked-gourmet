using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_B
{
    internal class Resultado
    {
        public int quantidadeTestes {  get; set; }
        public List<string> trechos { get; set; } = new List<string>();
        public bool Sucesso { get; set; }
        public int quantidadeVogais { get; set; }
        public int quantidadeConsoantes { get; set; }
    }
}
