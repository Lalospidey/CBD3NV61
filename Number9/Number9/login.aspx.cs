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
            
            
            con.Close();
            
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