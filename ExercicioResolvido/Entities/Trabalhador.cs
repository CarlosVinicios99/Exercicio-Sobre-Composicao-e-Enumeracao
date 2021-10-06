using System.Collections.Generic;
using ExercicioResolvido.Entities.Enums;

namespace ExercicioResolvido.Entities
{
    class Trabalhador
    {
        private List<Contrato> _contratos = new List<Contrato>();
        public string Nome {get; set;}
        public double SalarioBase {get; set;}
        public Nivel NivelExperiencia {get; set;}
        public Departamento Departamento {get; set;}

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, double salarioBase, Nivel nivelExperiencia, Departamento departamento)
        {
            Nome = nome;
            SalarioBase = salarioBase;
            NivelExperiencia = nivelExperiencia;
            Departamento = departamento;
        }


        public void AdicionarContrato(Contrato contrato)
        {
            _contratos.Add(contrato);
        }
        public void RemoveContrato(Contrato contrato)
        {
            _contratos.Remove(contrato);
        }

        public double Ganho(int mes, int ano)
        {
            double ganhoTotal = SalarioBase;
            foreach(Contrato contratoAtual in _contratos)
            {
                bool anoIgual = ano == contratoAtual.Data.Year;
                bool mesIgual = mes == contratoAtual.Data.Month;

                if(anoIgual && mesIgual){
                    ganhoTotal += contratoAtual.ValorTotal();
                }
            }
            return ganhoTotal;
        }
    }
}
