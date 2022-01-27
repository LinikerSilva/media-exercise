using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Insira o nome do aluno: ");
            name = Console.ReadLine();
            Console.WriteLine("Digite agora a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite agora a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite agora a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite agora a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine();

            if (media >= 3.00)
            {
                Console.WriteLine("Dados do Aluno:");
                Console.WriteLine("Nome: " + name);
                Console.WriteLine("Nota 1: " + nota1);
                Console.WriteLine("Nota 1: " + nota2);
                Console.WriteLine("Nota 1: " + nota3);
                Console.WriteLine("Nota 1: " + nota4);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Menção: Reprovado");
            }
            else if (media >= 5.00)
            {
                Console.WriteLine("Dados do Aluno:");
                Console.WriteLine("Nome: " + name);
                Console.WriteLine("Nota 1: " + nota1);
                Console.WriteLine("Nota 1: " + nota2);
                Console.WriteLine("Nota 1: " + nota3);
                Console.WriteLine("Nota 1: " + nota4);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Menção: Recuperação");
            }
            else if (media >= 7.00)
            {
                Console.WriteLine("Dados do Aluno:");
                Console.WriteLine("Nome: " + name);
                Console.WriteLine("Nota 1: " + nota1);
                Console.WriteLine("Nota 1: " + nota2);
                Console.WriteLine("Nota 1: " + nota3);
                Console.WriteLine("Nota 1: " + nota4);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Menção: Bom");
            }
            else if (media >= 10.00)
            {
                Console.WriteLine("Dados do Aluno:");
                Console.WriteLine("Nome: " + name);
                Console.WriteLine("Nota 1: " + nota1);
                Console.WriteLine("Nota 1: " + nota2);
                Console.WriteLine("Nota 1: " + nota3);
                Console.WriteLine("Nota 1: " + nota4);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Menção: Ótimo");
            }

            Console.ReadKey();
        }
    }
}
