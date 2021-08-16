using System;

namespace EstruturaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if / Else / Else if exemplo */
            float nota1, nota2, nota3, media;

            Console.WriteLine("Digite a Primeira Nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira Nota");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if(media >= 7)
            {
       
                Console.WriteLine("Aluno Aprovado Média: " + media);

            }
            else if(media <7 && media >= 4)
            {
                Console.WriteLine("Aluno em Recuperação Média: " + media);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado Média: " + media);
            }





        }
    }
}
