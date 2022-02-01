using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CargoEntity;
using CargoBussiness;

namespace CargoManagementSystem
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            Reg_Info regInfo = new Reg_Info();
            register_Connection regConn = new register_Connection();
            regInfo.FirstName = txtFName.Text;
            regInfo.Lastname = txtLName.Text;
            regInfo.Email = txtEmail.Text;
            regInfo.PhoneNumber = Convert.ToInt32(txtPhNo.Text);
            regInfo.Password = txtPwd.Text;
            regInfo.Re_enterPassword = txtRepwd.Text;

            regConn.InsertDetails(regInfo);// Business Layer InsertDetails Function
            DataTable dtRegInfo = regConn.GetDetails();//Business Layer GetDetails Function
        }
    }
}