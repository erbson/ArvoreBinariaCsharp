using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Arvore arvore = new Arvore();
            No no = new No(0);
           
            arvore.Add(3);
           
            arvore.Add(5);
           
            arvore.Add(2);
           
            arvore.Add(1);
           
            arvore.Add(3);
           
            arvore.Add(4);
           
            arvore.Add(6);
           
            arvore.Add(7);
            
            arvore.PosOrdem(arvore.Raiz);

            Console.WriteLine(" Retornando Altura da Arvore");
            Console.WriteLine(arvore.RetornaAlturaDaArvore(arvore.Raiz));

            Console.WriteLine("Contagem dos Nós");

            Console.WriteLine(arvore.Contagem(arvore.Raiz));






            Console.ReadKey();

        }
    }
}
