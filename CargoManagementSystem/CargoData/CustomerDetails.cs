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
    public class CustomerDetails
    {
        string sqlConnectionStr = "Data Source=LAPTOP-HNLA2RU1;Initial Catalog=Sprint1;Integrated Security=True";
        public void InsertCustomer(Cust_Info custObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("insert into CustomerDetails values('" + custObj.CustName + "','" + custObj.Address + "','" + custObj.City + "'," + custObj.PinCode + ",'" + custObj.PhNo + "')", sqlConnectionObj);
            
            adp.Fill(dt);
           
        }
        public void UpdateCustomer(Cust_Info custObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("update CustomerDetails set CustName = '" + custObj.CustName + "', Address = '" + custObj.Address + "', City = '" + custObj.City + "', PinCode = " + custObj.PinCode + ", PhNo = '" + custObj.PhNo + "' where CustId = " + custObj.CustId + " ", sqlConnectionObj);
            
            adp.Fill(dt);
        }
        
        public DataTable SelectCustomer()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("select * from CustomerDetails", sqlConnectionObj);
            
            adp.Fill(dt);
            return dt;
        }
       
    }
}
