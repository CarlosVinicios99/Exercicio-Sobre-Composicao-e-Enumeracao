using System;

namespace ExercicioResolvido
{
    class Contrato
    {
        public DateTime Data {get; set;}
        public double ValorPorHora {get; set;}
        public int HorasTotais {get; set;}

        public Contrato()
        {

        }
        public Contrato(DateTime data, double valorPorHora, int horasTotais)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            HorasTotais = horasTotais;
        }

        public double ValorTotal()
        {
            return HorasTotais * ValorPorHora;
        }

    }
}