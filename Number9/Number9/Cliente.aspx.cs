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
            if (!Page.IsPostBack)
            {
                int x = login.idusu;
                string Query = "select nombre from datos_usuarios where id_datos_usuarios ='" + x + "'";
                string eve = "select nombre_evento from evento ";
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand even = new SqlCommand(eve);
                SqlCommand cmd = new SqlCommand(Query);
                cmd.Connection = con;
                even.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                even.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetString(0);
                }
                dr.Close();
                SqlDataReader evento = even.ExecuteReader();

                while (evento.Read())
                {
                    DropDownList1.DataSource = evento;
                    DropDownList1.DataValueField = "nombre_evento";
                    DropDownList1.DataTextField = "nombre_evento";
                    DropDownList1.DataBind();
                }
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
            
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "select nombre_evento as Evento ,zonas as Zona_Disponible ,precio,localidades, vendidos from zonas inner join precios on zonas.id_zonas=precios.id_zonas inner join evento on evento.id_precios=precios.id_precios where nombre_evento='" + DropDownList1.SelectedItem.ToString() + "'";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            panel_principal.DataSource = dt;
            panel_principal.DataBind();
        
        }
    }
}