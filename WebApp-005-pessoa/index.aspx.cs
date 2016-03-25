using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_005_pessoa
{
    public partial class index : System.Web.UI.Page
    {
        //intranciando a propriedade que ira será uma lista e ira fazer o controle da sesão.
        public List<Pessoa> TabelaPessoas{
            //Declarando apenas o get prpriedade.
            get{
                // Se a variavel de sessão for nula.
                if(Session["pessoas"] == null){
                    //Atribui a variavel de sessão uma lista da Classe pessoa.
                    Session["pessoas"] = new List<Pessoa>();
                }
                //Faz um cast da sessão para retornar-la como pessoa.
                return (List<Pessoa>)Session["pessoas"];
            }
        }
   
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void ButtonEviar_Click(object sender, EventArgs e)
        {
            //Instanciando um novo objeto da classe Pessoa.
            Pessoa person = new Pessoa();
            //Atribuindo os valores dos input[type=text] no novo objeto.
            person.Nome = TxtNome.Text;
            person.Endereco = TxtEndereco.Text;
            //Aqui foi necessario uma conversão de valores.
            person.Cpf = TxtCpf.Text;

            //Incluir o objeto Pessoa na lista em memória
            TabelaPessoas.Add(person);

            atualizaTabela();
            
            //Limpando os dado nos input[type=text]
            TxtNome.Text = string.Empty;
            TxtEndereco.Text = string.Empty;
            TxtCpf.Text = string.Empty;
        }

        private void atualizaTabela() {
            //Atualizar o grid com os dados que estão na lista.
            GvPessoa.DataSource = TabelaPessoas;
            //Mostar a atualização na grid.
            GvPessoa.DataBind();
        }
    }
}