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
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AUD_datos_usuarios";
            cmd.Parameters.AddWithValue("@id_datos_usuarios", rnd.Next(11, 101));
            cmd.Parameters.AddWithValue("@nombre",TextBox1.Text);
            cmd.Parameters.AddWithValue("@Ap_pat", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Ap_mat", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Correo", TextBox4.Text);
            cmd.Parameters.AddWithValue("@fechan",TextBox5.Text);
            cmd.Parameters.AddWithValue("@StatementType","Insertar");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script type='text/javascript'> window.open('login.aspx','_self'); </script>");
        }
    }
}