using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CargoEntity;
using CargoBussiness;

namespace CargoManagementSystem
{
    public partial class Bill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSave_Click(object sender, EventArgs e)
        {

            Bill_Connection billObj = new Bill_Connection();
            Bill_Info billinfo = new Bill_Info();



            billinfo.BillNo = Convert.ToInt32(txtBillNo.Text);
            //billinfo.CustId = Convert.ToInt32(txtCustId.Text);
            billinfo.TransId = Convert.ToInt32(txttransId.Text);
            billinfo.Date = txtDate.Text;
            billinfo.AmountPaid = Convert.ToInt32(txtAmountPaid.Text);

            billObj.InsertDetails(billinfo);
        }

        
    }
}