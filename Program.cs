using System;

namespace treinando
{
    class Program
    {
        static void Main(string[] args)
        {

            float salario, soma=0,media;
            int cont=0;
            while(cont<3)
            {
              Console.WriteLine("Informe o valor do salário:");
              salario = float.Parse(Console.ReadLine());
              soma = soma + salario; //ACUMULADOR
              cont = cont +1;        //CONTADOR
            }
            media = soma / cont;
            Console.WriteLine("O valor médio dos salários é: {0:N}",media); 
        }
    }
}
