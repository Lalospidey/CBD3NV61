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
    public partial class Cliente : System.Web.UI.Page
    {
        private string strcon = WebConfigurationManager.ConnectionStrings["Numero9ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = login.idusu;
            string Query = "select nombre from datos_usuarios where id_datos_usuarios ='" + x +  "'";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Label1.Text = dr.GetString(0);
            }
            
   }
    }
}