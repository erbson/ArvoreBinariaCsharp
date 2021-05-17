using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Arvore arvore = new Arvore();
            // No no = new No(0);
           
            arvore.Add(1);
           
            arvore.Add(2);
           
            arvore.Add(5);
           
            arvore.Add(3);
           
            arvore.Add(6);
           
            arvore.Add(4);
           
           // arvore.Add(13);
           
           // arvore.Add(20);
            
           // arvore.PosOrdem(arvore.Raiz);

            //Console.WriteLine(" Retornando Altura da Arvore");
            //Console.WriteLine(arvore.RetornaAlturaDaArvore(arvore.Raiz));

            //Console.WriteLine("Contagem dos Nós");

            //Console.WriteLine(arvore.Contagem(arvore.Raiz));
            //Console.WriteLine(" removendo umm nó");
            //arvore.RemoveNo(arvore.Raiz,3);
            //arvore.RemoveNo(arvore.Raiz, 1);

            //Console.WriteLine("quantidade de nós "+arvore.Contagem(arvore.Raiz));
           Console.WriteLine("imprimindo em ordem");
          arvore.EmOrdem(arvore.Raiz);
            Console.WriteLine(" --------------------------------------");
            //arvore.RemoveNo(arvore.Raiz, 5);
            //arvore.RemoveNo(arvore.Raiz, 8);
            //arvore.RemoveNo(arvore.Raiz, 9);
            //arvore.RemoveNo(arvore.Raiz, 13);
            //arvore.RemoveNo(arvore.Raiz, 10);
            //arvore.RemoveNo(arvore.Raiz, 7);
            //arvore.RemoveNo(arvore.Raiz, 20) ;
            //arvore.RemoveNo(arvore.Raiz, 18);
            //arvore.RemoveNo(arvore.Raiz, 18);
            // Console.WriteLine(" removendo umm nó");
            // arvore.EmOrdem(arvore.Raiz);
            // Console.WriteLine(" --------------------------------------");
            // Console.WriteLine(arvore.RetornaMaiorElemento(arvore.Raiz));
            //arvore.RetornaMaiorElemento(arvore.Raiz);

            arvore.NivelTransversal(arvore.Raiz);









            Console.ReadKey();

        }
    }
}
