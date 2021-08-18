using System;

namespace ConsoleApp1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* chamada de métodos
            var n1 = new Teste();

            Console.WriteLine(n1.mensagem);
            Console.WriteLine(n1.contador);

            n1.teste();

            var n2 = new Calculo();

            float valor1 = 43245, valor2 = 476347;

            n2.teste(valor1, valor2);

            */

            var jogador = new Jogo();

            jogador.jogar();





        }
    }
    /*
    class Teste
    {
        public String mensagem = "Hello Wolrd";
        public int contador = 3642 + 6345342;
        

        public void teste()
        {
            Console.WriteLine("teste");
        }
   

    }
    class Calculo
    {
        public void teste(float n1, float n2)
        {
            float soma= n1+n2;

            Console.WriteLine("A soma de "+ n1 + " + "+ n2 +"  é de: " +soma);
        }
    }
    */
    class Jogo {
        private int tentativas=10, chute;
        private bool controlador = false;

        public void jogar()
        {

            Random valor = new Random();
            int valorRandom = valor.Next(1, 10);
               
            while(this.controlador == false)
            {
                Console.WriteLine("Digite o Número entre 1 e 10, você possui " + this.tentativas + " tentativas");
                this.chute = Convert.ToInt32(Console.ReadLine());

                if(this.chute < 1 || this.chute > 10)
                {
                    Console.WriteLine("Número Inválido, tente Novamente");
                   
                }
                else
                {
                    if (this.chute == valorRandom)
                    {
                        this.controlador = true;
                        Console.WriteLine("Acertou, o Número é " + valorRandom);

                    }
                    else if (this.chute != valorRandom)
                    {
                        this.tentativas--;

                        if (this.tentativas == 0)
                        {
                            this.controlador = true;

                            Console.WriteLine("Fim de Jogo, Você possui: " + this.tentativas + " tentativas, o Número era: " + valorRandom);
                        }

                    }
                }

       

            }
            
        }

    }


}
