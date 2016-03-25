using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_004_colecao
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Crianda uma propriedade list da classe Estado
        public List<Estado> TabelaEstados {
            //Get da propriedade Estado
            get {
                //Se a sessão for uma váriavel nula.
                if (Session["tblEstado"] == null)
                    //Atribue a ela uma lista da Classe estados
                    Session["tblEstado"] = new List<Estado>();
                //Retorna a lista de estados.
                return (List<Estado>)Session["tblEstado"];
            }
          
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //
            AtualizarGrid(); 

        }
       
        protected void ButtonAtualizar_Click(object sender, EventArgs e)
        {
            //Instancia um novo objeto da classe Estado.
            Estado es = new Estado();
            //Pega os dados dos input text e add na propriedade.
            es.Sigla = TxtSigla.Text;
            es.Nome = TxtNome.Text;
            //Incluir o objeto na propriedade Tabela estado que é uma Lista da classe Estado.
            TabelaEstados.Add(es);
            //Altualiza o grid de com os dados
            AtualizarGrid();
            //Limpa dados no input text
            TxtNome.Text = string.Empty;
            TxtSigla.Text = string.Empty; 

        }

        //Metodo que atualiza o grid
        private void AtualizarGrid() {
            //Add valores na Grid Vier com a id gvEstados.
            gvEstados.DataSource = TabelaEstados;
            //Mostra os dados atualizado na Grid Vier com a id gvEstados.
            gvEstados.DataBind();
      
        }
    }
}