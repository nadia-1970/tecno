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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\SVU_ITE_Bwp401_F23_c3\SVU_ITE_Bwp401_F23_c3\App_Data\Database1.mdf;Integrated Security=True");
        int id;
        string name, price, desc, image;
        protected void addtocart_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products where Id=" + id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                name = dr["name"].ToString();
                price = dr["price"].ToString();
                desc = dr["desc"].ToString();
                image = dr["image"].ToString();
            }

            con.Close();
            if (Request.Cookies["svu"] == null)
            {
                Response.Cookies["svu"].Value = name.ToString() + "," + price.ToString() + "," + desc.ToString() + "," + image.ToString();
                Response.Cookies["svu"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                Response.Cookies["svu"].Value = Request.Cookies["yy"].Value + "|" + name.ToString() + "," + price.ToString() + "," + desc.ToString() + "," + image.ToString();
                Response.Cookies["svu"].Expires = DateTime.Now.AddDays(1);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from products where Id =" + id;
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
        