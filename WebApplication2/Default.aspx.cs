using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        private int contador;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                contador = (int)Application["Contador"];
                if (contador!= 0)
                {
                    Response.Write("<h1>Hola mundo - Esta pagina ya ha sido visitada " + Application["Contador"] + " veces</h1>");
                    Response.Write("<h1>Cantidad de usuarios que han accedido: " + Application["Sesion"] + " </h1>");
                }
                else
                {
                    Response.Write("<h1>Hola mundo - Es la primera vez que se ha cargado la pagina</h1>");
                    Response.Write("<h1>Cantidad de usuarios que han accedido: " + Application["Sesion"] + " </h1>");
                }
                
                
            }            
        }
        
        protected void btnRecargar_Click(object sender, EventArgs e)
        {
            if (ViewState["Click"]!=null)
            {
                Application["Contador"] = (int)ViewState["Click"] +1;
            }
            else
            {
                Application["Contador"] = (int)Application["Contador"] + 1;
            }
            Response.Write("<h1>Hola mundo - Esta pagina ya ha sido visitada "+ Application["Contador"] + " veces</h1>");
            Response.Write("<h1>Cantidad de usuarios que han accedido: " + Application["Sesion"] + " </h1>");
            ViewState["Click"] = Application["Contador"];
        }
    }
}