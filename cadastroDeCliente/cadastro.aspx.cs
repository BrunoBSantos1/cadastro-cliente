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
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e) 
        {
            cookie = Request.Cookies["clientes"];
        }

        private void Mostrar()
        {
            viwResultado.DataSource = Cliente.Lista;
            viwResultado.DataBind();

            panelResultado.Visible = true;
            Response.Write("teste");
            Response.Write( Page.Request.Cookies["clientes"]);

        }

        public bool ValidarCampos()
        {
            if (Request.Form["tNome"] == " " || Request.Form["tNome"].Length > 6) 
            {
                //throw new ArgumentException("o tamanho do nome foi ultrapasso a caracteres");
                Response.Write("Campo nome está fora dos requisitos");
                return false;
            }
            if (Request.Form["tSexo"] == "")
            {
                Response.Write("Campo sexo precisa ser preenchido");
                return false;
            }
            if (Request.Form["tCpf"] == "")
            {
                Response.Write("Campo CPF precisa ser preenchido");
                return false;
            }
            if (Request.Form["tRg"] == "")
            {
                Response.Write("Campo RG precisa ser preenchido");
                return false;
            }
            if (Request.Form["tDataNascimento"] == " ")
            {
                Response.Write("Campo Data de nascimento precisa ser preenchido");
                return false;
            }
            if(Request.Form["tEndereco"] == " ")
            {
                Response.Write("Campo Endereço precisa ser preenchido");
                return false;
            }
            return true;
        }

        protected void Salvar(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nome = Request.Form.Get("tNome"),
                Sexo = Request.Form["tSexo"],
                Cpf = Request.Form["tCpf"],
                Rg = Request.Form["tRg"],
                DataNascimento = Request.Form["tDataNascimento"],
                Endereco = Request.Form["tEndereco"],
            };
                if (ValidarCampos())
                {
                    GravarKokies(cliente);
                    cliente.Salvar();
                }
            Response.Write("teste");
            //Response.Write(Page.Request.Cookies["clientes"].Name);
           
            Response.AppendToLog("testando");
            Response.Write("Resultado normal");
            Mostrar();
            Obter();
        }

        private void GravarKokies(Cliente cliente)
        {
            
            cookie = new HttpCookie("clientes");
            cookie.Values.Add("Nome", cliente.Nome);
            Response.Write(Request.Form.Get("clientes").ToList());
        }

        private HttpCookie Obter()
        {
            return this.Page.Request.Cookies["clientes"];
        }
    }
}