using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Fonksiyon
/// </summary>
public class Fonksiyon
{
    public Fonksiyon()
    {
    }

    public SqlConnection baglan()
    {
        SqlConnection baglanti = new SqlConnection(WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        baglanti.Open();
        return baglanti;
    }
    public int islem(string sorgu)
    {
        SqlConnection baglan = this.baglan();
        SqlCommand komut = new SqlCommand(sorgu, baglan);
        int sonuc = 0;
        try
        {
            sonuc = komut.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message + "(" + sorgu + ")");
        }
        komut.Dispose();
        baglan.Close();
        baglan.Dispose();
        return sonuc;
    }
}