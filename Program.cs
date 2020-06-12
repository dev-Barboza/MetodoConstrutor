using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!!! Bem Vindo a Biblioteca SESI!!");
            System.Console.WriteLine();

            Livro x = new Livro("Star Wars", 45 ,"Livro com 43 paginas da editora abril " , "George lucas" );
            System.Console.WriteLine(x.Nome);
            System.Console.WriteLine(x.Codigo);
            System.Console.WriteLine(x.Descrição);
            System.Console.WriteLine(x.Autor);
            

            
        }
    }
}
