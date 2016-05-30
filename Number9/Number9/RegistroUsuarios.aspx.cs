using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Number9
{
    
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        Random rnd = new Random();
        private string strcon = WebConfigurationManager.ConnectionStrings["Numero9ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = rnd.Next(11,1000);
            string p;
            string b = "Registro realizado satisfactoriamente";
            string m = "Las contraseñas no coinciden";
            string n = "Debes de llenar todos los campos";
            if ((TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0) || ((TextBox3.Text.Length == 0 || TextBox4.Text.Length == 0)) || (TextBox5.Text.Length == 0 || TextBox6.Text.Length == 0) || (TextBox7.Text.Length == 0 && TextBox8.Text.Length == 0))
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + n + "');", true);
            else
            {
                if (TextBox7.Text == TextBox8.Text)
                {
                    p = TextBox8.Text;
                    SqlConnection con = new SqlConnection(strcon);
                    SqlConnection con2 = new SqlConnection(strcon);
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "AUD_datos_usuarios";
                    cmd.Parameters.AddWithValue("@id_datos_usuarios", i);
                    cmd.Parameters.AddWithValue("@nombre", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Ap_pat", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Ap_mat", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Correo", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@fechan", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@StatementType", "Insertar");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd2.Connection = con2;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "AUD_login";
                    cmd2.Parameters.AddWithValue("@Id_usuario", i);
                    cmd2.Parameters.AddWithValue("@usuario", TextBox6.Text);
                    cmd2.Parameters.AddWithValue("@pass", p);
                    cmd2.Parameters.AddWithValue("@id_tipo_usuario", 1);
                    cmd2.Parameters.AddWithValue("@id_datos_usuarios", i);
                    cmd2.Parameters.AddWithValue("@StatementType", "Insertar");
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    con2.Close();
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + b+ "');", true);
                    Response.Write("<script type='text/javascript'> window.open('login.aspx','_self'); </script>");
                    }
                   
                else { ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + m + "');", true); }
             
            }
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = ""; TextBox6.Text = ""; TextBox7.Text = ""; TextBox8.Text = "";
        }

        
    }
}