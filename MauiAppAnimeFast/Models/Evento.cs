using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAnimeFast.Models
{
    public class Evento
    {
        // nome do evento
        public string NomeEvento { get; set; }
        public Camarim CamarimSelecionado { get; set; }

        //Quantidade de adultos e crianças
        public int QntAdulto { get; set; }
        public int QntCrianca { get; set; }

        //Datas contradas no evento
        public DateTime Datainicial { get; set; }
        public DateTime Datafinal { get; set; }

        //Local do evento com base no camarim que for selecionado
        public string LocalEvento 
        {
            get => CamarimSelecionado?.Descricao ?? "Local não definido";
        }

        //número de participantes (adultos + crianças)
        public int NumeroParticipantes 
        {
            get => QntAdulto + QntCrianca;  
        }

        //total dos dias de estadia
        public int Estadia 
        {
            get => Datainicial < Datafinal ? Datafinal.Subtract(Datainicial).Days : 1;
        }

        //valor diária por adulto e criança
        public double ValorAdultoIndividual
        {
            get => CamarimSelecionado?.ValorDiariaAdulto ?? 0;
        }
        public double ValorCriancaIndividual
        {
            get => CamarimSelecionado?.ValorDiariaCrianca ?? 0;
        }

        //custo individual adulto e custo individual criança com base na estadia
        //custo para o adulto
        public double CustoIndividualAdulto 
        {
            get => ValorAdultoIndividual * Estadia;
        }

        //custo para a criança
        public double CustoIndividualCrianca 
        {
            get => ValorCriancaIndividual * Estadia;
        }

        //cálculo total do evento
        public double ValorTotal 
        {
            get => (CustoIndividualAdulto * QntAdulto) + (CustoIndividualCrianca * QntCrianca); 
        }
    }
}
