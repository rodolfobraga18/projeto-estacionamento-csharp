using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.models
{
    public class Menu
    {
        private Estacionamento estacionamento = new Estacionamento();

        public void Executar()
        {
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\n--- Menu do Estacionamento ---");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a placa do veículo: ");
                        string placaCadastro = Console.ReadLine();
                        estacionamento.CadastrarVeiculo(placaCadastro);
                        break;

                    case "2":
                        Console.Write("Digite a placa do veículo a remover: ");
                        string placaRemover = Console.ReadLine();

                        Console.Write("Quantas horas o carro permaneceu? ");
                        int horas = int.Parse(Console.ReadLine());

                        estacionamento.RemoverVeiculo(placaRemover, horas);
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;

                    case "4":
                        executando = false;
                        Console.WriteLine("Encerrando... Obrigado!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}