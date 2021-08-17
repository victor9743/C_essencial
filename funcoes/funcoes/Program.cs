using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             chamada de metodo
             mensagem();
            */
            /* chamada com retorno exemplo */

            Console.WriteLine("Digite o salário");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Novo Salário é de: " + calculo(salario));

        }
        /* Método sem retorno
        static void mensagem()
        {
            Console.WriteLine("Hello Wolrd");
            return;
        }
            método com retorno
        */
        static float calculo(float valor){

            float aumento = 5;
            float salarioCalculo =+ (valor * aumento) / 100;
            float novoSalario = salarioCalculo + valor;
            return novoSalario;


           
        }
    }
}
