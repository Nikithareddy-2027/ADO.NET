using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoEntity;
using CargoData;

namespace CargoBussiness
{
    public class Bill_Connection
    {
        public void InsertDetails(Bill_Info billObj)
        {
            BillingDetails billConn = new BillingDetails();
            billConn.InsertBill(billObj);

        }
        public DataTable GetDetails()
        {
            BillingDetails billConn = new BillingDetails();
            DataTable dtObj = billConn.SelectBill();

            return dtObj;


        }
    }
}
