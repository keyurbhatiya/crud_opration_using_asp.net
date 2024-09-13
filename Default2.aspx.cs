using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        disp_data();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            // INSERT DATA

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table01 values (@Id,@Name,@Age,@Address,@MobileNo,@Regd)", con);

            cmd.Parameters.AddWithValue("@Id", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
            cmd.Parameters.AddWithValue("@MobileNo", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Regd", System.DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Write("<script> alert('DATA INSERT SUCCESSFULLY') </script>");
            TextBox1.Text = "";
            Blank_Textbox();
            disp_data();
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An error occurred: " + ex.Message + "') </script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {

        
        //UPDATE DATA


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("UPDATE Table01 SET Name=@Name,Age=@Age,Address=@Address,MobileNo=@MobileNo WHERE Id=@Id", con);

        cmd.Parameters.AddWithValue("@Id", int.Parse(TextBox1.Text));
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Age", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
        cmd.Parameters.AddWithValue("@MobileNo", TextBox5.Text);
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script> alert('DATA UPDATE SUCCESSFULLY') </script>");
        TextBox1.Text = "";
        Blank_Textbox();
        disp_data();
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An error occurred: " + ex.Message + "') </script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {

      
        //DELETE DATA


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("DELETE Table01 WHERE Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id",int.Parse(TextBox1.Text));
       
        cmd.ExecuteNonQuery();
        con.Close();


        Response.Write("<script> alert('DATA DELETE SUCCESSFULLY') </script>");
        TextBox1.Text = "";
        Blank_Textbox();
        disp_data();

          }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An error occurred: " + ex.Message + "') </script>");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        try
        {

        //SEARCH DATA

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Table01 WHERE Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", int.Parse(TextBox1.Text));
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        //da.Fill(dt);
        //dataGridView1.Data = dt;
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An error occurred: " + ex.Message + "') </script>");
        }
    }

    public void disp_data()
    {
        //SHOW DATA ON GRIDVIEW


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Table01", con);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }

     public void Blank_Textbox()
    {
        //TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }

     protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
     {

     }
}