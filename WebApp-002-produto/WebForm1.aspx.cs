using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_002_produto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                /*Atribuido a uma variavel de sessão uma 
                 * referencia a um objeto da classe Produto.*/
                Session["produto"] = new Produto();
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Produto p = (Produto)Session["produto"];
            //Convertendo valores int para string;
            TxtCodigo.Text = Convert.ToString(p.Codigo);
            //Aqui não é necessario converter.
            TxtNome.Text = p.Nome;
            //Convertendo valores double para string;
            TxtPreco.Text = Convert.ToString(p.Preco);
        }

        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            Produto p = (Produto)Session["produto"];
            //Convertendo valor string para int.
            p.Codigo = Convert.ToInt32(TxtCodigo.Text);
            //Aqui não é necessario converter.
            p.Nome = TxtNome.Text;
            //Converetendo valor string para double.
            p.Preco = Convert.ToDouble(TxtPreco.Text);

        }

        protected void ButtonLimpar_Click(object sender, EventArgs e)
        {
            //Limpando valores nas inputs text.
            TxtCodigo.Text = string.Empty;
            TxtNome.Text = string.Empty;
            TxtPreco.Text = string.Empty;

        }
    }
}