using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace c_.models
{
    public class Estacionamento
    {
        private List<Veiculo> listaVeiculos = new List<Veiculo>();

        
        public void CadastrarVeiculo(string placa)
        {
            var veiculo = new Veiculo(placa);
            listaVeiculos.Add(veiculo);
            Console.WriteLine($"{veiculo.Placa} cadastrado com sucesso!");
        }

        
        public void RemoverVeiculo(string placa, int horas)
        {
            var veiculo = listaVeiculos.Find(v => v.Placa == placa.ToUpper());

            if (veiculo == null)
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }

            double valor = CalcularValorEstacionamento(horas);
            listaVeiculos.Remove(veiculo);

            Console.WriteLine($"{veiculo.Placa} removido com sucesso!");
            Console.WriteLine($"Tempo de permanência: {horas} hora(s)");
            Console.WriteLine($"Valor do estacionamento: R$ {valor:F2}");
        }

        
        private double CalcularValorEstacionamento(int horas)
        {
            double valor = 5.0; 
            if (horas > 1)
            {
                valor += (horas - 1) * 2; 
            }
            return valor;
        }

        
        public void ListarVeiculos()
        {
            if (listaVeiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine("Veículos cadastrados:");
            foreach (var veiculo in listaVeiculos)
            {
                Console.WriteLine($"- {veiculo.Placa}");
            }
        }
    }
}
