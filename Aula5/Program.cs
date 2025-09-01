using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {//For para desenhar um triangulo de asteriscos
           for(int i = 0; i <= 9; i++)
            {
                // j é reiniciado a cada nova iteração de i
                for (int j = 0; j <=i ; j++)
                {
                    Console.Write(" *");
                }
                // Pula a linha após o término do for interno
                Console.WriteLine("");

            }
            //for para desenhar um quadrado de asteriscos
            /*for(int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <=9 ; j++)
                {
                    Console.Write(" *");
                }
                // Pula a linha após o término do for interno
                Console.WriteLine("");
               
            }*/
        }

        // O while só aceita uma condição booleana  
        static void WhileFuction()
            {
                int i = 0;
                while (i < 10000)
                {
                    i++;
                    Console.WriteLine(i);
                }
            }
            static void ForFuction()
            {
                for (int i = 10000; i > 0; i--)
                {
                    Console.WriteLine("index " + i);
                }
            }
     }
 }
