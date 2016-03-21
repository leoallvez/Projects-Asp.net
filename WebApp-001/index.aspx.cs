using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_001
{
	public partial class index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            /*postback é o processo que acontece quando você clica 
             * em algum botão ou link de um web form fazendo que os 
             * dados sejam enviados para o servidor e a página seja 
             * então remontada após o processamento.*/
            if (!IsPostBack) {
                /*O controle de sessão de uma aplicação web está diretamente ligado ao 
                 * gerenciamento de estado da aplicação. De forma simplificada, podemos 
                 * definir que o estado de uma página web é composto, basicamente, por todas 
                 * as informações de uma página e seus controles ou campos de formulário*/
                Session["cliente"] = new Cliente(); /*<- Uma variavel de sessão será um objeto da classe Cliente*/
            }
		}
        //Botão Buscar
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            //Fazendo o cast da classe salva na sessão para uma nova classe.
            Cliente c = (Cliente)Session["cliente"];
            //atribuindo os valores da nova Classe nos input Text.
            TextBoxCpf.Text = c.getCpf();
            TextBoxNome.Text = c.getNome();
            TextBoxEndereco.Text = c.getEndereco();

        }
        //Botão Gravar
        protected void ButtonGravar_Click(object sender, EventArgs e)
        {
            //Fazendo o cast da classe salva na sessão para uma nova classe.
            Cliente c = (Cliente)Session["cliente"];
            //atribuindo os valores dos input Text na nova Classe.
            c.setCpf(TextBoxCpf.Text);
            c.setNome(TextBoxNome.Text);
            c.setEndereco(TextBoxEndereco.Text);
        }
        //Botão Limpar
        protected void ButtonLimpar_Click(object sender, EventArgs e)
        {
            //string.Empty O valor desse campo é a cadeia de caracteres de comprimento zero.
            TextBoxCpf.Text = string.Empty;
            TextBoxNome.Text = string.Empty;
            TextBoxEndereco.Text = string.Empty;
        }
	}
}