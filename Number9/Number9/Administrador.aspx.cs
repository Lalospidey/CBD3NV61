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
        Random rnd = new Random();
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
            int ida=rnd.Next(0,1000);
            int idp=rnd.Next(0,ida);
            int iddr=rnd.Next(50,2000);
            int idr=rnd.Next(50,iddr);
            int ide = rnd.Next(45, 1500);
            SqlConnection co = new SqlConnection(strcon);
            SqlCommand cmde = new SqlCommand();
            SqlCommand cmdz= new SqlCommand();
            SqlCommand cmdp= new SqlCommand();
            SqlCommand cmddr= new SqlCommand();
            SqlCommand cmdr= new SqlCommand();
             cmde.Connection = co;
             cmdz.Connection=co;
             cmdp.Connection=co;
             cmddr.Connection=co;
             cmdr.Connection=co;
             cmdz.CommandType=CommandType.StoredProcedure;
             cmdz.CommandText="AUD_zonas";
             cmdz.Parameters.AddWithValue("@id_zonas",ida);
             cmdz.Parameters.AddWithValue("@zonas",TextBox2.Text);
             cmdz.Parameters.AddWithValue("@StatementType","Insertar");
             cmdp.CommandType=CommandType.StoredProcedure;
             cmdp.CommandText="AUD_precios";
             cmdp.Parameters.AddWithValue("@id_precios",idp);
             cmdp.Parameters.AddWithValue("@id_zonas",ida);
             cmdp.Parameters.AddWithValue("@precio",Int32.Parse(TextBox3.Text));
             cmdp.Parameters.AddWithValue("@StatementType","Insertar");
             cmddr.CommandType=CommandType.StoredProcedure;
             cmddr.CommandText="AUD_drecinto";
             cmddr.Parameters.AddWithValue("@id_direccion_recinto",iddr);
             cmddr.Parameters.AddWithValue("@Calle",TextBox4.Text);
             cmddr.Parameters.AddWithValue("@Colonia",TextBox5.Text);
             cmddr.Parameters.AddWithValue("@Delegacion",TextBox6.Text);
             cmddr.Parameters.AddWithValue("@StatementType","Insertar");
             cmdr.CommandType=CommandType.StoredProcedure;
             cmdr.CommandText="AUD_Recinto";
            cmdr.Parameters.AddWithValue("@id_recinto",idr);
            cmdr.Parameters.AddWithValue("@nombrerecinto",TextBox7.Text);
            cmdr.Parameters.AddWithValue("@capacidad",Int32.Parse(TextBox8.Text));
            cmdr.Parameters.AddWithValue("@id_direccion_recinto",iddr);
            cmdr.Parameters.AddWithValue("@StatementType","Insertar");
            cmde.CommandType= CommandType.StoredProcedure;
            cmde.CommandText = "AUD_evento";
            cmde.Parameters.AddWithValue("@id_evento",ide);
            cmde.Parameters.AddWithValue("@nombre_evento",TextBox9.Text);
            cmde.Parameters.AddWithValue("@id_recinto",idr);
            cmde.Parameters.AddWithValue("@id_precios",idp);
            cmde.Parameters.AddWithValue("@fecha",TextBox10.Text);
            cmde.Parameters.AddWithValue("@vendidos",Int32.Parse(TextBox11.Text));
            cmde.Parameters.AddWithValue("@localidades", Int32.Parse(TextBox8.Text));
            cmde.Parameters.AddWithValue("@StatementType","Insertar");
            co.Open();
            cmdz.ExecuteNonQuery();
            cmdp.ExecuteNonQuery();
            cmddr.ExecuteNonQuery();
            cmdr.ExecuteNonQuery();
            cmde.ExecuteNonQuery();
             co.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string query = "select (nombre+' '+Ap_pater+' '+' '+Ap_mater) as Nombre,DATEDIFF(hour,fechan,GETDATE())/8766 AS Edad,Correo ,usuario from datos_usuarios inner join login on login.id_datos_usuarios=datos_usuarios.id_datos_usuarios";//order by '"+this.Tipo.Text +"'";
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