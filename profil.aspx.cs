using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profil : System.Web.UI.Page
{
    Fonksiyon fonk = new Fonksiyon();
    void GridDoldur()
    {
        SqlConnection baglan = fonk.baglan();
        SqlCommand komut = new SqlCommand("select * from uye", baglan);
        SqlDataReader dr = komut.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        baglan.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        GridDoldur();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        fonk.islem("update uye set Sifre='" + TextBox2.Text + "' where Sifre='" + TextBox1.Text + "'");
        GridDoldur();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        fonk.islem("update uye set DogumTarihi='" + DropDownList1.SelectedItem.Text +TextBox5.Text+TextBox6.Text+ "' where DogumTarihi='"+DropDownList2.SelectedItem.Text+TextBox7.Text + TextBox8.Text + "'");
        GridDoldur();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        fonk.islem("delete from uye where id='" + TextBox9.Text + "'");
        GridDoldur();
    }
}