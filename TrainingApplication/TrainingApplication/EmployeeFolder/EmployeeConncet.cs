using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TrainingApplication.EmployeeFolder
{
    public class EmployeeConncet
    {
        string sqlConnectionstr = "Data Source = LAPTOP-HNLA2RU1; Initial Catalog = TutorialDB ; Integrated Security = True";
        //string sqlConnectionStr = "Data Source=W10JQQGN13;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertOp(DetailsMode detailsMode)
        {
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCmd = new SqlCommand("insert into EmployeeDetails values("+detailsMode.EmpId+",'"+detailsMode.EmpName+"','"+detailsMode.EmpJob+"','"+detailsMode.EmpSal+ "',"+detailsMode.EmpDeptNo+ ",'" + detailsMode.EmpId+"')", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            return "Employee Details Saved Successfully";
        }
        public void UpdateOp(DetailsMode detailsMode)
        {

        }
        public void DeletebyId(int EmpId)
        {

        }
        public DataTable SelectOp()
        {
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCmdObj = new SqlCommand("select * from EmployeeDetails", sqlObj);
            sqlObj.Open();
            SqlDataReader sqlReaderObj = sqlCmdObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlReaderObj);
            sqlObj.Close();
            return dt;
        }
        public void EditbyId(int EmpId)
        {

        }

    }
}