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
    public class BillingDetails
    {
        string sqlConnectionStr = "Data Source=LAPTOP-HNLA2RU1;Initial Catalog=Sprint1;Integrated Security=True";
        public void InsertBill(Bill_Info billObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("insert into BillingDetails values(" + billObj.BillNo + ","+billObj.CustId+",'" + billObj.Date + "'," + billObj.AmountPaid + " )", sqlConnectionObj);
            adp.Fill(dt);
        }
        public void UpdateBill(Bill_Info billObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("update BillingDetails set Date = '" + billObj.Date + "', AmountPaid = " + billObj.AmountPaid + ", where BillNo = " + billObj.BillNo + " ", sqlConnectionObj);
            adp.Fill(dt);
        }
        
        public DataTable SelectBill()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("select * from BillingDetails", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
        
    }
}

