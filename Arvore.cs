using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
   public  class Arvore
    {
        public No Raiz { get; set; }

     
       public void Add(int valor)
        {

            if (Raiz == null)
            {
                Raiz = new No(valor);
            }else
            {
                No novo = new No(valor);
                Add(Raiz, novo);

            }


        }

        private void Add(No no, No novo)
        {
            if (novo.Valor > no.Valor)
            {
                if (no.NoDireito == null)
                {
                    no.NoDireito = novo;
                }
                else
                {
                    Add(no.NoDireito, novo);
                }
            }
            else
            {
                if (no.NoEsquerdo == null)
                {
                    no.NoEsquerdo = novo;
                }
                else
                {
                    Add(no.NoEsquerdo, novo);
                }
            }
            
        }

        public No MenorValor(No no)
        {
            if (no.NoEsquerdo == null)
            {
                return no;
            }
            return MenorValor(no.NoEsquerdo);
        }

        public No RemoveNo(No no,int valor)
        {
            if (no == null) return null;

            if(no.Valor > valor)
            {

                 no.NoEsquerdo = RemoveNo(no.NoEsquerdo, valor);
            }
            else if(no.Valor < valor){

                no.NoDireito = RemoveNo(no.NoDireito, valor);

            }
            else
            {
                if (no.NoEsquerdo != null && no.NoDireito != null)
                {
                    No temp = no;
                    No no_menor = MenorValor(temp.NoDireito);
                    no.Valor = no_menor.Valor;
                    no.NoDireito = RemoveNo(no.NoDireito, no_menor.Valor);


                }
                else if (no.NoEsquerdo != null)
                {

                    no = no.NoEsquerdo;
                }
                else if (no.NoDireito != null)
                {

                    no = no.NoDireito;
                }
                else
                    no = null;


            }



            return no;
        }



        public void ImprimeArvoreEmOrdem(No no)
        {

            if (Raiz != null)
            {
                ImprimeArvoreEmOrdem(no.NoEsquerdo);
                Console.WriteLine("*" + Raiz.Valor + "*");

                ImprimeArvoreEmOrdem(no.NoDireito);


            }

        }


        public void PreOrdem(No no)
        {
            if (no != null)
            {
                Console.Write(no.Valor + " ");
                PreOrdem(no.NoEsquerdo);
                PreOrdem(no.NoDireito);
            }
        }

        public void EmOrdem(No no)
        {

             if(no != null) {

                EmOrdem(no.NoEsquerdo);
                Console.WriteLine(no.Valor);
                EmOrdem(no.NoDireito);
            
                   }


        }

        public void PosOrdem(No no)
        {
            if (no != null)
            {
                
                PosOrdem(no.NoEsquerdo);
                PosOrdem(no.NoDireito);
                Console.Write(no.Valor + " ");
            }
        }

        public int Contagem(No no)
        {

            return (no == null) ? 0 : 1 + Contagem(no.NoEsquerdo) + Contagem(no.NoDireito);  

        }



        public int RetornaAlturaDaArvore(No no)
        {

            if (no == null)

                return -1;
            else
                return 1 + Math.Max(RetornaAlturaDaArvore(no.NoEsquerdo), RetornaAlturaDaArvore(no.NoDireito));

        }


        public int RetornaMaiorElemento(No root)
        {

            if (root == null)
            {

                return 0;

            } if(root.NoDireito== null) { return root.Valor; }
                return RetornaMaiorElemento(root.NoDireito);





        }


        public void NivelTransversal(No root)
        {
            int nivel = 1;
            while (ImprimeNivel(root, nivel))
            {
                nivel++;



            }

        }


        public bool ImprimeNivel(No root,int indice)
        {

            if(root == null)
            {

                return false;

            }if(indice == 1)
            {
                Console.WriteLine(root.Valor+ " ");
                return true;



            }

            bool noEquerdo = ImprimeNivel(root.NoEsquerdo, indice - 1);
            bool noDireito = ImprimeNivel(root.NoDireito, indice - 1);

            return noEquerdo || noDireito;



        }



        public override string ToString()
        {
            return Raiz == null ? "*" : Raiz.ToString();

        }
       






    }
}
