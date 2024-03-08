using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_A
{
    internal class Resultado
    {
        public int QuantidadeBrinquedo { get; set; }
        public int AlturaPessoa { get; set; }
        public List<int> AlturasPermitidas { get; set; } = new List<int>();

        public bool Sucesso { get; set; }
    }
}
