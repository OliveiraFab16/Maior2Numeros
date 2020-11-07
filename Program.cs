using System;


namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeirovalor;
            int segundovalor = 0;
            
            Console.WriteLine("-----Melhor de Dois-----");

            Console.Write("Digite o Primeiro Valor : ");
            primeirovalor = Convert.ToInt32(Console.ReadLine());

            if ( primeirovalor > segundovalor )
            {
                segundovalor = primeirovalor;
            } 

            Console.Write("Digite o Segundo Valor: ");
            segundovalor = Convert.ToInt32(Console.ReadLine());

             if ( primeirovalor > segundovalor )
             {
                primeirovalor = segundovalor;
             }
             
            Console.WriteLine("O Maior Numero É: {0}", segundovalor);
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
           
            
        }
    }
}
