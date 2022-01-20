using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoData;
using CargoEntity;

namespace CargoBussiness
{
    public class Customer_Connection
    {
        public void InsertDetails(Cust_Info custObj)
        {
            CustomerDetails custConn = new CustomerDetails();
            custConn.InsertCustomer(custObj);

        }
        public DataTable GetDetails()
        {
            CustomerDetails custConn = new CustomerDetails();
            DataTable dtObj = custConn.SelectCustomer();

            return dtObj;


        }
    }
}
