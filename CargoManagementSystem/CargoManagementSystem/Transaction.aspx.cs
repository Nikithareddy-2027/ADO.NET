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
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSave_Click(object sender, EventArgs e)
        {
            Trans_Connection transObj = new Trans_Connection();
            Trans_Info transinfo = new Trans_Info();



            transinfo.TransId = Convert.ToInt32(txtTransId.Text);
            transinfo.TotalAmount = Convert.ToInt32(txtTotalAmount.Text);
            transinfo.Date = txtDate.Text;
            transinfo.BankAccNo = Convert.ToInt32(txtBankaccno.Text);

            transObj.InsertDetails(transinfo);
        }

        protected void txtExit_Click(object sender, EventArgs e)
        {

        }
    }
}