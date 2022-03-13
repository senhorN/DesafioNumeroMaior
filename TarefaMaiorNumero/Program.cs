using System;

namespace TarefaMaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             20220222 - Postar exercício maior número.

             Instruções
             Crie um algoritmo que peça 10 números acima de zero para o usuário e ano final mostre o maior número digitado.
             Postar um print do código e do app em execução.  
            */


            //Variáveis;
            int x = 0;
            int maior = 0;
            int aux;
            int contador = 1; 
             
            int[] numeral = new int[11];
            for (int i = 1; i < 11; i++)
            {
                //informando um número;
                Console.Write("Informe um número"+ i +"º...:");
                aux = Convert.ToInt32(Console.ReadLine());
                numeral[contador] = aux;
                contador++;

                if (maior < aux)
                {
                    maior = aux; 

                }
            }
            //LimpaTela;
            Console.Clear();

            //Impressão do número;
            Console.WriteLine("Impressão dos números abaixo");
            while (x < 11)
            {              
                Console.WriteLine(numeral[x]);
                x++;
            }
            //impressão do maior número;
            Console.WriteLine();
            Console.WriteLine($"O maior número foi : {maior}" );
            Console.ReadKey();

            



      
            

           







        }
    }
}
