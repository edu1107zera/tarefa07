using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa07
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double valor;
            double cafe_ex = 3.00;
            double capu = 4.50;
            double Moca = 6.00;
            double agua = 1.00;

            Console.WriteLine("CARDAPIO DE PRODUTOS:");
            Console.WriteLine("1-Cafe espresso-R$3.00");
            Console.WriteLine("2-capuccino-R$4.50");
            Console.WriteLine("3-Mocaccino-R$6.00");
            Console.WriteLine("4-Agua quente_R$1.00");
           
            Console.Write("Escolha o  produto e digite o numero deles:");
            escolha =int.Parse(Console.ReadLine());
            Console.Write("Insira o valor a pagar: ");
            valor = double.Parse(Console.ReadLine());

            

         
            if (escolha == 1) 
            {

                if (valor == cafe_ex)
                {
                    Console.WriteLine("Seu cafe esta pronto retire-o");
                }
            }
           
            if (escolha == 2)
            {
                if (valor == capu)
                {
                    Console.WriteLine("Seu capuccino esta sendo preparado aguarde e retire-o abaixo");
                }
            }
           

            if (escolha == 3) 
            { 
              if (valor == Moca)
              {
                Console.WriteLine("Moccacino pronto retire-o");
              }
            }
           
            if (escolha == 4)
            {
              if (valor == agua)
              {
                Console.WriteLine("agua quente pronta");
              }
            }
           






            Console.ReadKey();
        }
    }
}
