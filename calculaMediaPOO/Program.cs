using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaMediaPOO
{
    internal class Program
    {

        //Método Main para o programa ser executável 
        static void Main(string[] args)
        {
            Pessoa aluno;

            //Criar um objeto "aluno" e pedir para o usuário introduzir seus dados
            Console.WriteLine("Olá, vamos calcular sua média!!");
            Console.WriteLine("Digite seu nome: ");
            aluno = new Pessoa();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua matricula: ");
            aluno.Matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota da sua Primeira Prova: ");
            aluno.NotaProva1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da sua Segunda Prova: ");
            aluno.NotaProva2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota do seu trabalho: ");
            aluno.NotaTrabalho = Convert.ToDouble(Console.ReadLine());

            double mediaProvas = (aluno.NotaProva1 + aluno.NotaProva2) * 2.5;
            double mediaFinal = (aluno.NotaTrabalho * 2 + mediaProvas) / 7.5;

            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Matricula: " + aluno.Matricula);
            Console.WriteLine($"Media final: {mediaFinal}");

            Console.ReadKey();
        }
    }
}