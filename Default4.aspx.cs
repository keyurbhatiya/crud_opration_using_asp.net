using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
{
    private readonly string connectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True"); // Update with your SQL Server connection string

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFormView();
            }
        }

        private void BindFormView()
        {
            FormView1.ChangeMode(FormViewMode.ReadOnly);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Table01", con))
                {
                    con.Open();
                    FormView1.DataSource = cmd.ExecuteReader();
                    FormView1.DataBind();
                }
            }
        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            HandleFormViewEvent("Data inserted successfully", e);
        }

        protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            HandleFormViewEvent("Data updated successfully", e);
        }

        protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            HandleFormViewEvent("Data deleted successfully", e);
        }

        private void HandleFormViewEvent(string successMessage, EventArgs e)
        {
            try
            {
                if (IsEventSuccessful(e))
                {
                    FormView1.ChangeMode(FormViewMode.ReadOnly);
                    BindFormView();
                    ShowClientMessage(successMessage);
                }
                else
                {
                    HandleEventException((SqlDataSourceStatusEventArgs)e);
                }
            }
            catch (Exception ex)
            {
                ShowClientMessage("An error occurred: " + ex.Message);
            }
        }

        private bool IsEventSuccessful(EventArgs e)
        {
            return (e is FormViewInsertedEventArgs || e is FormViewUpdatedEventArgs || e is FormViewDeletedEventArgs);
        }

        private void HandleEventException(SqlDataSourceStatusEventArgs e)
        {
            e.ExceptionHandled = true;
            ShowClientMessage("An error occurred: " + e.Exception.Message);
        }

        private void ShowClientMessage(string message)
        {
            Response.Write("<script>alert('{message}');</script>");
        }

        protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            FormView1.ChangeMode(e.NewMode);
            BindFormView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Table01 WHERE Id=@Id", con))
                {
                    cmd.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");
                    con.Open();
                    FormView1.DataSource = cmd.ExecuteReader();
                    FormView1.DataBind();
                }
            }
        }
}