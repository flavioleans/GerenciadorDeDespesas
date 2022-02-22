using GerenciadorDespesas.Models;
using GerenciadorDespesas.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.ViewComponents
{
    public class EstatisticasViewComponent : ViewComponent
    {
        private readonly Contexto _context;
        public EstatisticasViewComponent(Contexto context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            EstatisticasViewModel estatisticas = new EstatisticasViewModel();
            estatisticas.MenorDespesa = _context.Despesas_1.Min(x => x.Valor);
            estatisticas.MaiorDespesa = _context.Despesas_1.Max(x => x.Valor);
            estatisticas.QuantidadeDespesa = _context.Despesas_1.Count();

            return  View( estatisticas);
        }
    }
}
