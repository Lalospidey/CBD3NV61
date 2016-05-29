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
            int i, j;
            string p;
            string m = "Las contraseñas no coinciden";
            if (TextBox7.Text == TextBox8.Text)
            {
                p = TextBox8.Text;
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AUD_datos_usuarios";
                cmd2.CommandText = "AUD_login";
                cmd.Parameters.AddWithValue("@id_datos_usuarios", i = rnd.Next(11, 101));
                cmd2.Parameters.AddWithValue("@Id_usuario", i);
                cmd2.Parameters.AddWithValue("@usuario", TextBox6.Text);
                cmd2.Parameters.AddWithValue("@pass", p);
                cmd.Parameters.AddWithValue("@nombre", TextBox1.Text);
                cmd2.Parameters.AddWithValue("@id_tipo_usuario",1);
                cmd2.Parameters.AddWithValue("@id_datos_usuarios", i);
                cmd.Parameters.AddWithValue("@Ap_pat", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Ap_mat", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Correo", TextBox4.Text);
                cmd.Parameters.AddWithValue("@fechan", TextBox5.Text);
                cmd.Parameters.AddWithValue("@StatementType", "Insertar");
                cmd2.Parameters.AddWithValue("@StatementType", "Insertar");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script type='text/javascript'> window.open('login.aspx','_self'); </script>");
            }
            else { ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + m + "');", true); }
        }
    }
}