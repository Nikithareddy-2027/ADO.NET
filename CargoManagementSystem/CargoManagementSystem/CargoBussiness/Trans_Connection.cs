using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoEntity;
using CargoData;
using System.Data;

namespace CargoBussiness
{
   public class Trans_Connection
    {
        public void InsertDetails(Trans_Info transObj)
        {
            TransactionDetails transConn = new TransactionDetails();
            transConn.InsertTrans(transObj);
           
        }
        public DataTable GetDetails()
        {
            TransactionDetails transConn = new TransactionDetails();
            DataTable dtObj = transConn.SelectTrans();

            return dtObj;


        }
    }
}
