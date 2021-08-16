using System;

namespace ForEWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            // For

            int contador = 5;
            int[] vetor = {04234, 2341, 54353,6574,5};

            for(int x=0; x<vetor.Length; x++){

                //Console.WriteLine(x);
                Console.WriteLine(vetor[x]);
            }
            */

            // While
            // criando um numero random
            Random numeroRandom = new Random();
            int num = numeroRandom.Next(0, 10);

            int contador = 5;
            bool acertou = false;
            int chute;

            while(acertou == false)
            {
                Console.WriteLine("Digite Um Número Entre 0 e 10");
                chute = Convert.ToInt32(Console.ReadLine());

                if(chute > 10 || chute < 0)
                {
                    Console.WriteLine("Valor Inválido, tente Novamente");
                    Console.ReadKey();
                    Console.Clear();

                    

                }
                else if (chute == num)
                {
                    contador = 0;
                    acertou = true;
                    Console.WriteLine("Acertou !!!, O número é : " + chute);
              

                }
                else if(chute != num)
                {
                    contador --;
                    Console.WriteLine("Errou, Você Possui " + contador + " Tentativas ");

                   
                    if (contador == 0)
                    {
                        acertou = true;
                        Console.WriteLine("Tentativas Esgotadas, O número era " + num);


                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                    }
                    
                }
               


            }






           


        }
    }
}
