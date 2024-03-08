using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_C
{
    internal class Resultado
    {
        public int numeroCompetidores { get; set; }
        public List<int> posicoesIniciais { get; set; } = new List<int>();
        public List<int> posicoesFinais { get; set; } = new List<int>();

        public bool Sucesso { get; set; }
    }
}
