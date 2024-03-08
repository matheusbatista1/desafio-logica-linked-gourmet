using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_D
{
    internal class Resultado
    {
        public int numeroCompetidores { get; set; }
        public int numeroMinimoCompetidores { get; set; }
        public int classificados { get; set; }
        public List<int> pontuacao { get; set; } = new List<int>();
        public bool Sucesso { get; set; }
    }
}
