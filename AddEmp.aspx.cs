using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            conn = new SqlConnection(cs);
            conn.Open();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            double Salary = double.Parse(TextBox2.Text);

            string q = $"exec sp_SaveEmp '{Name}','{Salary}'";
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();

            Response.Write("<script> alert('Emp Saved Successfully') </script>");
        }
    }
}