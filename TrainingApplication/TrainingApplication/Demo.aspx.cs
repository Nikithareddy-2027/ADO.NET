using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainingApplication.EmployeeFolder;
using System.Data;
//page_preinit(),page_init(),page_load(),page_Click(),page_unload()
//page_init(); TextBox txtTutroialId=new TextBox();

namespace TrainingApplication
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
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

            LoadEmployeeDetails();
        }

        protected void txtUpdate_Click(object sender, EventArgs e)
        {
            EmployeeConncet ecObj = new EmployeeConncet();
            DetailsMode dmObj = new DetailsMode();

            dmObj.EmpId = Convert.ToInt32(txtEmpId.Text);
            dmObj.EmpName = txtEmpName.Text;
            dmObj.EmpJob = txtEmpJob.Text;
            dmObj.EmpSal = txtEmpSal.Text;
            dmObj.EmpDeptNo = Convert.ToInt32(txtEmpDeptNo.Text);
            dmObj.Location = txtLocation.Text;

            string msg = ecObj.UpdateOp(dmObj);
            lblResult.Text = msg;

            LoadEmployeeDetails();
        }

        protected void txtRest_Click(object sender, EventArgs e)
        {

        }

        protected void txtDelete_Click(object sender, EventArgs e)
        {
            EmployeeConncet ecObj = new EmployeeConncet();
            string msg = ecObj.DeletebyId(Convert.ToInt32(txtEmpId.Text));
            lblResult.Text = msg;

            LoadEmployeeDetails();
        }
        protected void txtEdit_Click(object sender, EventArgs e)
        {
            EmployeeConncet ecobj = new EmployeeConncet();
            DataTable dtResult = ecobj.EditbyId(Convert.ToInt32(txtEmpId.Text));
            txtEmpName.Text = dtResult.Rows[0][1].ToString();
            txtEmpJob.Text = dtResult.Rows[0][2].ToString();
            txtEmpSal.Text = dtResult.Rows[0][3].ToString();
            txtEmpDeptNo.Text = dtResult.Rows[0][4].ToString();
            txtLocation.Text = dtResult.Rows[0][5].ToString();
        }
        public void LoadEmployeeDetails()
        {
            EmployeeConncet ecObj = new EmployeeConncet();
            DataTable dtResult = ecObj.SelectOp();
            gvEmployeeDetails.DataSource = dtResult;
            gvEmployeeDetails.DataBind();
        }
    }
}