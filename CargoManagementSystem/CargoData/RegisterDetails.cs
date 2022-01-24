using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoEntity;
//FirstName varchar(50), Lastname varchar(50), Email varchar(100),PhoneNumber numeric, Password varchar(50), Re_enterpassword varchar(50) 
namespace CargoData
{
    public class RegisterDetails
    {
        string sqlConnectionStr = "Data Source=LAPTOP-HNLA2RU1;Initial Catalog=Sprint1;Integrated Security=True";
        public void InsertReg(Reg_Info regObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("insert into RegisterDetails values('" + regObj.FirstName + "','" + regObj.Lastname + "','" + regObj.Email + "'," + regObj.PhoneNumber + " ,'" + regObj.Password + "','" + regObj.Re_enterPassword + "'", sqlConnectionObj);
            adp.Fill(dt);
        }

        public DataTable SelectReg()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlDataAdapter adp = new SqlDataAdapter("select * from RegisterDetails", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
        public DataTable LoginCheck(string Email, string Password)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select FirstName,Lastname,Email,PhoneNumber from RegisterDetails where Email='" + Email + "' and Password='" + Password + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
