using System;
using System.Collections.Generic;

namespace atv01_rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido solicitar = new Pedido();

            char continua = 'S';
            do{

              ItemPedido produto = new ItemPedido();
              

              Console.WriteLine("Informe o nome do item: ");

              produto.descricaoPublico = Console.ReadLine();

              Console.WriteLine("Informe o valor: ");

              produto.valor_unitarioPublico = double.Parse(Console.ReadLine());


              Console.WriteLine("Informe a quantidade: ");

              produto.quantidadePublico = int.Parse(Console.ReadLine()); 

              Console.WriteLine("A soma total do pedido é " +String.Format("{0:C2}", produto.registrar()));

              solicitar.Adicionar (produto);

              Console.WriteLine("Deseja continuar? (S) SIM (N) NÃO");  

              continua = char.Parse(Console.ReadLine()); 

              Console.Clear();

            } while(continua=='S');

            solicitar.Listar();

            Console.WriteLine( "Total " + String.Format("{0:C2}",solicitar.FechamentoConta()));
       

            



           
            
        }
    }
}