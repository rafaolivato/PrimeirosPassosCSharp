using System;
using System.Collections.Generic;

namespace atv01_rafael
{
    public class ItemPedido{   
        public double valor_unitario, quantidade; 
        public string descricao;
          
        public String descricaoPublico{
            set {descricao = value; }
            get{ return descricao;}

        }
        public double valor_unitarioPublico{
            set {valor_unitario = value; }
            get{ return valor_unitario;}

        }
        public double quantidadePublico{
            set {quantidade = value; }
            get{ return quantidade;}

        }
         public double registrar(){
            double calculo;

            calculo = quantidadePublico * valor_unitarioPublico;
            return calculo;
        }
        
        

        

            

    }
        
}