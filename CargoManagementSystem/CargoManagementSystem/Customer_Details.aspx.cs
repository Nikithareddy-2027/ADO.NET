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
    public partial class Customer_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer_Connection custObj = new Customer_Connection();
            Receive_Connection recObj = new Receive_Connection();
            Cust_Info custinfo = new Cust_Info();
            Receiver_Info recinfo = new Receiver_Info();

            custinfo.CustName = txtCustname.Text;
            //billinfo.CustId = Convert.ToInt32(txtCustid.Text);
            custinfo.Address = txtAddress.Text;
            custinfo.City = txtCity.Text;
            custinfo.PinCode = Convert.ToInt32(txtPincode.Text);
            custinfo.PhNo = Convert.ToInt32(txtPhno.Text);


            recinfo.ReceiverName = txtCustname.Text;
            //recinfo.ReceiverId = Convert.ToInt32(txtCustid.Text);
            recinfo.Address = txtAddress.Text;
            recinfo.City = txtCity.Text;
            recinfo.PinCode = Convert.ToInt32(txtPincode.Text);
            recinfo.PhNo = Convert.ToInt32(txtPhno.Text);

            custObj.InsertDetails(custinfo);
            recObj.InsertDetails(recinfo);
        }
    }
}