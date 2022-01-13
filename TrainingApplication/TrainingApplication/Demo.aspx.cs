using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainingApplication.EmployeeFolder;
using System.Data;

namespace TrainingApplication
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            EmployeeConncet ecObj = new EmployeeConncet();
            DetailsMode dmObj = new DetailsMode();
            dmObj.EmpId = Convert.ToInt32(txtEmpId.Text);
            dmObj.EmpName = txtEmpName.Text;
            dmObj.EmpJob = txtEmpJob.Text;
            dmObj.EmpSal = txtEmpSal.Text;
            dmObj.EmpDeptNo = Convert.ToInt32(txtEmpDeptNo.Text);
            dmObj.Location = txtLocation.Text;

           string msg = ecObj.InsertOp(dmObj);
            lblResult.Text = msg;

            DataTable dtObj = ecObj.SelectOp();
            gvEmployeeDetails.DataSource = dtObj;
            gvEmployeeDetails.DataBind();
        }
    }
}