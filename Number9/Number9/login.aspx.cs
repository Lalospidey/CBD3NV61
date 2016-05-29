using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Number9
{
    
   public partial class login : System.Web.UI.Page
    {
       public static int idusu;
        private string strcon = WebConfigurationManager.ConnectionStrings["Numero9ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Query = "select * from login where usuario ='" + this.TextBox1.Text + "' and pass='" + this.TextBox2.Text + "'";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            
            int contador = 0;
            int x = 0;
            while (dr.Read())
            {
                contador++;
                x = Convert.ToInt32(dr[3]);
                idusu= Convert.ToInt32(dr[0]);
            }
            if (contador == 1 && x == 2)
            {
                Response.Write("<script type='text/javascript'> window.open('Administrador.aspx','_self'); </script>");
            }
            if (contador == 1 && (x == 3 || x == 1))
            {
                Response.Write("<script type='text/javascript'> window.open('Cliente.aspx','_self'); </script>");
            }
            if (contador < 1 && TextBox1.Text.Length == 0 && TextBox2.Text.Length == 0)
            {
                string message = "No haz introducido ningun dato. ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);

            }
            if (contador < 1 && TextBox1.Text.Length == 0 && TextBox2.Text.Length != 0)
            {
                string message = "No haz introducido el nombre de usuario. ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
            }
            if (contador < 1 && TextBox1.Text.Length != 0 && TextBox2.Text.Length == 0)
            {
                string message = "No haz introducido la contraseña. ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
            }
            if (contador < 1 && TextBox1.Text.Length != 0 && TextBox2.Text.Length != 0)
            {
                string message = "Usuario no valido . ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
            }
            con.Close();
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