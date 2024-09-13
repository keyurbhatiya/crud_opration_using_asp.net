using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True"); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDetailsView();
        }
    }

    private void BindDetailsView()
    {
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Table01", con))
            {
                con.Open();
                DetailsView1.DataSource = cmd.ExecuteReader();
                DetailsView1.DataBind();
            }
        }
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        BindDetailsView();
    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        BindDetailsView();
    }

    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        BindDetailsView();
    }

    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        DetailsView1.ChangeMode(e.NewMode);
        BindDetailsView();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        // Implement search functionality based on your requirements
        // You may need to modify the SQL query and rebind the DetailsView
    }

}