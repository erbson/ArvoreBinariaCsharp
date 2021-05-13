using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    public class No
    {
        public No NoEsquerdo { get; set; }
        public No NoDireito { get; set; }
        public int Valor { get; set; }
        public No(int valor)
        {

            
            this.Valor = valor;


        }
        



    }
}
