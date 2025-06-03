using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAnimeFast.Models
{
    public class Evento
    {
        public Camarim CamarimSelecionado { get; set; }
        public int QntAdulto { get; set; }
        public int QntCrianca { get; set; }
        public DateTime Datainicial { get; set; }
        public DateTime Datafinal { get; set; }

        public int Estadia 
        {
            get => Datafinal.Subtract(Datainicial).Days;
        }

        
        public double ValorAdultoIndividual
        {
            get => CamarimSelecionado.ValorDiariaAdulto;
        }

        public double GetValorCriancaIndividual()
        {
            return CamarimSelecionado.ValorDiariaCrianca;
        }

        public double ValorTotal 
        {
            get 
            {
                double valor_adulto = QntAdulto * ValorAdultoIndividual;
                double valor_crianca = QntCrianca * GetValorCriancaIndividual();

                double total = (valor_adulto + valor_crianca) * Estadia;

                return total;
            }
        }
    }
}
