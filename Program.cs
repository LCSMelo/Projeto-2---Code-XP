using System;

namespace Projeto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifique sua placa no rodízio.");

            Console.WriteLine("Digite o final da sua placa.");
            string placa = Console.ReadLine();
            
            string nomes = ("Seu veículo estará no rodízio na ");
            
            if (placa == "1" || placa == "2")
           
            Console.WriteLine(nomes + "Segunda-feira.");
           
            else if (placa == "3" || placa == "4")
           
            Console.WriteLine(nomes + "Terça-feira.");

            else if (placa == "5" || placa == "6")
           
            Console.WriteLine(nomes + "Quarta-feira.");

            else if (placa == "7" || placa == "8")
           
            Console.WriteLine(nomes + "Quinta-feira.");

            else if (placa == "9" || placa == "0")
           
            Console.WriteLine(nomes + "Sexta-feira.");

        }   
        
    }
 }
