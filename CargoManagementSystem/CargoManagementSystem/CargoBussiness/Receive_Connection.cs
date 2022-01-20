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
    public class Receive_Connection
    {
        public void InsertDetails(Receiver_Info recObj)
        {
            ReceiverDetails recConn = new ReceiverDetails();
            recConn.InsertReceiver(recObj);

        }
        public DataTable GetDetails()
        {
            ReceiverDetails recConn = new ReceiverDetails();
            DataTable dtObj = recConn.SelectReceiver();

            return dtObj;


        }
    }
}
