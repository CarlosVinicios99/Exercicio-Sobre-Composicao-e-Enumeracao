using System;
using ExercicioResolvido.Entities;
using ExercicioResolvido.Entities.Enums;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do Departamento: ");
            string nomeDept = Console.ReadLine();

            Console.WriteLine("\nInsira os dados do trabalhador: ");

            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nivel Nivel (Junior/Pleno/Senior): ");
            Nivel nivel = Enum.Parse<Nivel>(Console.ReadLine());

            Console.Write("Digite o salario base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento departamento = new Departamento(nomeDept);
            Trabalhador trabalhador = new Trabalhador(nome, salarioBase, nivel, departamento);

            Console.Write("Quantos contratos serao cadastrados: ");
            int qtdContratos = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdContratos; i++)
            {

                Console.Write($"\nContrato #{i + 1} Digite os dados: ");

                Console.Write("\nData (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor Por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());

                Console.Write("Digite a Duracao total do contrato (em horas): ");
                int horasTotais = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, valorPorHora, horasTotais);     
                trabalhador.AdicionarContrato(contrato);  
            }

            Console.Write("\nDigite o mes e o ano para calcular o ganho neste periodo (MM/AAAA): ");
            string periodo = Console.ReadLine();

            int mes = int.Parse(periodo.Substring(0, 2));
            int ano = int.Parse(periodo.Substring(3, 4));

            Console.WriteLine("\nNome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Ganhos em " + periodo + ": R$" + trabalhador.Ganho(mes, ano).ToString("F2"));
        }
    }
}
