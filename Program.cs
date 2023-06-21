using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> vagas = new List <string> { "BCL258" };

            string estacionar = "1";
            string retirar = "2";
            string listalo = "3";
            string placas;
            
          

            Console.WriteLine("Olá, seja bem-vindo!");
            Console.WriteLine("Podemos estacionar seu carro, retirar ele e lista-lo");
            Console.WriteLine("Digite uma opção:");
            string opcao = Console.ReadLine();
            while (true)
            {
                if (opcao == "1")
                {
                    Console.WriteLine("estamos verificando se esta vaga esta disponivel!");
                    Console.WriteLine("poderia informar a placa, para adicionarmos ele ao estacionamento");
                    string placa = Console.ReadLine();
                    placa = (placa.ToUpper());
                    Console.WriteLine("Estacionamos seu veiculo, fique tranquilo e aproveite o passeio!");
                    Main(null);
                }
               

                if (opcao == "2")
                {
                    
                    Console.WriteLine("Qual a placa do veiculo?");
                    string placa = Console.ReadLine();
                    placa = (placa.ToUpper());
                    vagas.Add(placa);
                    Console.WriteLine("Seu veiculo esta liberado!");


                    if (vagas.Contains(placa))
                    {
                        Console.WriteLine("Opa, parece que já temos um carro com essa placa!");
                        Main(null);
                        return;
                    }
                }
                string texto = "";
                if (opcao =="3")
                {
                    Console.WriteLine("temos essas vagas disponiveis:");
                    placas = (Console.ReadLine());
                     int quant = vagas.Count();
                    string nomes_dentro = string.Join(", ", vagas);
                    Console.WriteLine($"Existe uma quantidade de placa {quant}, onde elas são: {nomes_dentro}");


                }
                
                

            }

            

            Console.ReadKey();
        }
    }
}
