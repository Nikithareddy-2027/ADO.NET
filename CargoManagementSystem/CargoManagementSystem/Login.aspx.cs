using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CargoEntity;
using CargoBussiness;
using System.Data;

namespace CargoManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSignIn_Click(object sender, EventArgs e)
        {
            register_Connection regConn = new register_Connection();
            DataTable dtLogin = regConn.LoginCheck(txtEmail.Text, txtPwd.Text);
            if (dtLogin.Rows.Count > 0)
            {
                Response.Redirect("Customer_Details.aspx");
            }
            else
            {
                lblResult.Text = "Email id or password wrong! Go to Register.";

            }
        }
    }
}