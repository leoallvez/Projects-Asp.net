using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_002_produto
{
    public class Produto
    {
        //Declaração de atributos.
        private int codigo;
        //Declaração de propriedade.
        public int Codigo {
            //Declaração do get da propriedade.
            get { return this.codigo; }
            //Declaração do set da propriedade.
            set { this.codigo = value; }
        }

        private string nome;
        public string Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private double preco;
        public double Preco {
            get { return this.preco; }
            set { this.preco = value; }
        }
    }
}