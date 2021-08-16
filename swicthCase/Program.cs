using System;

namespace swicthCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = { "Opção 1", "Opção 2", "Opção 3", "Opção 4" };
            int op;

           
                op = Convert.ToInt32(Console.ReadLine());

                switch(op)
                {

                    case 1:
                        Console.WriteLine(vet[op]);
                    break;
                    case 2:
                        Console.WriteLine(vet[op]);
                    break;
                    case 3:
                        Console.WriteLine(vet[op]);
                    break;
                    case 4:
                        Console.WriteLine(vet[op]);
                    break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;




                }
            

        }
    }
}
