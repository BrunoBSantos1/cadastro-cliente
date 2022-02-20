using cadastroDeCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cadastroDeCliente
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
       
        private void mostrar()
        {
            viwResultado.DataSource = Cliente.Lista;
            viwResultado.DataBind();
        }
        protected void Salvar(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Sexo = txtSexo.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;
            cliente.dataNascimento = txtDataNascimento.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Salvar();

            mostrar();
        }
    }
}