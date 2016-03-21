using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_001
{
    //Classe Cliente
	public class Cliente{
        //Declaração de atributos.
        private string cpf;
        private string nome;
        private string endereco;

        //Declaração de metodos getter e setter.
        public string getCpf() { 
            return cpf;
        }

        public void setCpf(string valor) {
            cpf = valor;
        }

        public string getNome() {
            return nome;
        }

        public void setNome(string valor) {
            nome = valor;
        }

        public string getEndereco() {
            return endereco;
        }

        public void setEndereco(string valor) {
            endereco = valor;
        }
	}
}