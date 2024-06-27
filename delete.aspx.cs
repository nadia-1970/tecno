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
    public partial class delete : System.Web.UI.Page
    {
        string s, t;
        string[] a= new string[4];
        int id;
        string name, price, desc, image;
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("name"), new DataColumn("price"), new DataColumn("desc"), new DataColumn("image"), new DataColumn("id") });
            if (Request.Cookies["svu"] != null)
            {
                s = Request.Cookies["svu"].Value.ToString();
                string[] arr = s.Split('|');
                for (int i = 0; i < arr.Length; i++)
                {
                    t = arr[i].ToString();
                    string[] arr1 = t.Split(',');
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        a[j] = arr1[j].ToString();

                    }
                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), i.ToString()); ;

                }

            }
            dt.Rows.RemoveAt(id);
            Response.Cookies["svu"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["svu"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["svu"].Expires = DateTime.Now.AddDays(-1);

            foreach (DataRow dr in dt.Rows)
            {
                name = dr["name"].ToString();
                price = dr["price"].ToString();
                desc = dr["desc"].ToString();
                image = dr["image"].ToString();
                count++;

                if (count == 1)
                {
                    Response.Cookies["svu"].Value = name.ToString() + "," + price.ToString() + "," + desc.ToString() + "," + image.ToString();
                    Response.Cookies["svu"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["svu"].Value = Request.Cookies["svu"].Value + "|" + name.ToString() + "," + price.ToString() + "," + desc.ToString() + "," + image.ToString();
                    Response.Cookies["svu"].Expires = DateTime.Now.AddDays(1);
                }
            }
            Response.Redirect("viewcart.aspx");


        }
    }
}