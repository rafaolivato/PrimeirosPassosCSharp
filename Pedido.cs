using System;
using System.Collections.Generic;

namespace atv01_rafael
{

    public class Pedido
    {
        private List<ItemPedido> lista;


        public Pedido()
        {
            lista = new List<ItemPedido>();
        }
        public void Adicionar(ItemPedido item)
        {
            lista.Add(item);
        }
        public void Listar()
        {
        foreach (ItemPedido i in lista)
        
            Console.WriteLine("QTD: " + i.quantidadePublico + " ITEM -" +i.descricaoPublico + " TOTAL: " +String.Format("{0:C2}", i.registrar()));
        }
        
        public Double FechamentoConta(){
            double somaitens =0;
            for (int i =0; i<lista.Count;i++)
                somaitens = somaitens + lista[i].registrar();
            
            return somaitens;

            
        }
       
            
    }

}