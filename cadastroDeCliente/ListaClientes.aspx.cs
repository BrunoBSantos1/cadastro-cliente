using cadastroDeCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cadastroDeCliente
{
    public partial class ListaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            viwResultado.DataSource = Cliente.Lista;
            viwResultado.DataBind();
            Response.Write(Request.Form.Get("tNome"));

            Response.Write(this.Page.Request.Cookies["clientes"]);
        }
    }
}