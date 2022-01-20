using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CargoBussiness;
using CargoEntity;

namespace CargoManagementSystem
{
    public partial class Cust : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSave_Click(object sender, EventArgs e)
        {
            Customer_Connection connectObj = new Customer_Connection();
            Cust_Info custinfo = new Cust_Info();
            Receive_Connection recConn = new Receive_Connection();
            Receiver_Info recObj = new Receiver_Info();


            custinfo.CustName = txtCustname.Text;
            //custinfo.CustId = Convert.ToInt32(txtCustid.Text);
            custinfo.Address = txtAddress.Text;
            custinfo.City = txtCity.Text;
            custinfo.PinCode = Convert.ToInt32(txtPincode.Text);
            custinfo.PhNo = Convert.ToInt32(txtPhno.Text);

            recObj.ReceiverName = txtReceivername.Text;
            //recObj.ReceiverId = Convert.ToInt32(txtreceiverid.Text);
            recObj.Address = txtRecAddress.Text;
            recObj.City = txtRecCity.Text;
            recObj.PinCode = Convert.ToInt32(txtRecPincode.Text);
            recObj.PhNo = Convert.ToInt32(txtRecPhone.Text);



            connectObj.InsertDetails(custinfo);
            recConn.InsertDetails(recObj);
            
        }
    }
}