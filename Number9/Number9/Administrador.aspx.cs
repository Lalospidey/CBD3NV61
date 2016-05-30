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
    public partial class Administrador : System.Web.UI.Page
    {
        private string strcon = WebConfigurationManager.ConnectionStrings["Numero9ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = login.idusu;
            string Query = "select * from login where Id_usuario ='" + x + "'";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Label1.Text = dr.GetString(1);
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "AUD_evento";
            cmd.Parameters.AddWithValue("@id_evento",);
        }
    }
}