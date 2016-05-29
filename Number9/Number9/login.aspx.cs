using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Number9
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<script type='text/javascript'> window.open('Cliente.aspx','_self'); </script>");
            Response.Write("<script type='text/javascript'> window.open('Administrador.aspx','_self'); </script>");
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("<script type='text/javascript'> window.open('RegistroUsuarios.aspx','_self'); </script>");
        }
    }
}