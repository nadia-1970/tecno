using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SVU_ITE_Bwp401_F23_c3
{
    
     public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\SVU_ITE_Bwp401_F23_c3\SVU_ITE_Bwp401_F23_c3\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rep.DataSource = dt;
            rep.DataBind();

            con.Close();
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}