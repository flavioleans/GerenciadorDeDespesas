using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.ViewModels
{
    public class EstatisticasViewModel
    {
        public int QuantidadeDespesa { get; set; }
        public double MenorDespesa { get; set; }
        public double MaiorDespesa { get; set; }
    }
}
