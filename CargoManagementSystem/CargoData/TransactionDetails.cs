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
    public class TransactionDetails
    {
        string sqlConnectionStr = "Data Source=LAPTOP-HNLA2RU1;Initial Catalog=Sprint1;Integrated Security=True";
        public void InsertTrans(Trans_Info transObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("insert into TransactionDetails values(" + transObj.TransId + ",'" + transObj.TotalAmount + "','" + transObj.Date + "','" + transObj.BankAccNo + "' ", sqlConnectionObj);
            adp.Fill(dt);
        }
        public void UpdateTrans(Trans_Info transObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("update TransactionDetails set TotalAmount = '" + transObj.TotalAmount + "', Date = '" + transObj.Date + "',BankAccNo = '" + transObj.BankAccNo + "' where TransId = " + transObj.TransId + " ", sqlConnectionObj);
            adp.Fill(dt);
        }
       
        public DataTable SelectTrans()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("select * from TransactionDetails", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
        
    }
}

