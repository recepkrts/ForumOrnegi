using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class enter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=RECEPP;Initial Catalog=kayit;Integrated Security=True");
        con.Open();
        string ad = TextBox1.Text;
        string sifre = TextBox2.Text;

        SqlCommand komut = new SqlCommand("Select * From uye Where EPosta='" + ad + "' and Sifre='" + sifre + "'", con);
        SqlDataReader oku = komut.ExecuteReader();
        if (oku.Read())
        {
            Session.Add("kullanici", ad);
            Response.Redirect("profil.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Giriş Başarısız";

        }
    }
}