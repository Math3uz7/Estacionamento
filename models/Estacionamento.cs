using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_C_1.models
{
    public class Estacionamento
    {
        public void hello(string inicial, string hora, string opcao, string placa)
        {
            Console.WriteLine("Bem vindo ao nosso estacionamento");
            Console.WriteLine("Digite preco inical: ");
            inicial = Console.ReadLine();

            Console.WriteLine("Digite quantas horas");
            hora = Console.ReadLine();

            List<string> carro = new List<string>();

            while (true)
            {
                Console.WriteLine("Digite sua opcao desejada: ");
                Console.WriteLine("1- Cadastrar veiculo");
                Console.WriteLine("2- listar veiculos");
                Console.WriteLine("3- Remover veiculo");
                Console.WriteLine("4- Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite a placa so seu veiculo");
                        placa = Console.ReadLine();
                        carro.Add(placa);
                        Console.WriteLine("Precione qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Os veiculos estacionados sao: ");
                        int contador = 0;
                        foreach (string valor in carro)
                        {
                            Console.WriteLine($"Placas: {valor}");
                            contador++;
                        }
                        Console.WriteLine("Precione qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        carro.Remove(placa);
                        Console.WriteLine($"Itens da lista: {carro.Count}");
                        Console.WriteLine("Item removido");
                        Console.WriteLine("Precione qualquer tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                };
            }
        }
    }
}