using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_003_calculadora
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                Session["resultado"] = 0;
            }
        }

        protected void ButtonMais_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(TxtResultado.Text);
            double valorTemporario = Convert.ToDouble(Session["resultado"]);
            valorTemporario += valor;
            Session["resultado"] = valorTemporario;

            LabelResulado.Text = Convert.ToString(valorTemporario);
            TxtResultado.Text = string.Empty;
        }

        protected void ButtonMenos_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(TxtResultado.Text);
            double valorTemporario = Convert.ToDouble(Session["resultado"]);
            valorTemporario -= valor;
            Session["resultado"] = valorTemporario;

            LabelResulado.Text = Convert.ToString(valorTemporario);
            TxtResultado.Text = string.Empty;

        }
    }
}