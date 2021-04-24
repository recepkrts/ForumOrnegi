using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    Fonksiyon fonk = new Fonksiyon();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            fonk.islem("insert into uye(isim,EPosta,Sifre,Cinsiyet,DogumTarihi)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + TextBox5.Text + TextBox6.Text + "')");
            Response.Redirect("enter.aspx");  
    }
}