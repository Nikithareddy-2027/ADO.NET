using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoEntity;

namespace CargoData
{
    public class ReceiverDetails
    {
        string sqlConnectionStr = "Data Source=LAPTOP-HNLA2RU1;Initial Catalog=Sprint1;Integrated Security=True";
        public void InsertReceiver( Receiver_Info receiveObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            
            SqlDataAdapter adp = new SqlDataAdapter("insert into ReceiverDetails values(" + receiveObj.ReceiverName + ",'" + receiveObj.Address + "','" + receiveObj.City + "'," + receiveObj.PinCode + ",'" + receiveObj.PhNo + "')", sqlConnectionObj);
            adp.Fill(dt);
          
        }
        public void UpdateReceiver(Receiver_Info receiveObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            
            SqlDataAdapter adp = new SqlDataAdapter("update ReceiverDetails set ReceiverName = '" + receiveObj.ReceiverName + "', Address = '" + receiveObj.Address + "',City = '" + receiveObj.City + "', PinCode = " + receiveObj.PinCode + ", PhNo = '" + receiveObj.PhNo + "' where ReceiverId = " + receiveObj.ReceiverId + " ", sqlConnectionObj);
            adp.Fill(dt);
        }
        
        public DataTable SelectReceiver()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

          
            SqlDataAdapter adp = new SqlDataAdapter("select * from ReceiverDetails", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
       
    }
}
