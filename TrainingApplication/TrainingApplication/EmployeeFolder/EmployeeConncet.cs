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
        
        public string InsertOp(DetailsMode detailsMode)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connection Mode
            SqlCommand sqlCmd = new SqlCommand("insert into EmployeeDetails values("+detailsMode.EmpId+",'"+detailsMode.EmpName+"','"+detailsMode.EmpJob+"','"+detailsMode.EmpSal+ "',"+detailsMode.EmpDeptNo+ ",'" + detailsMode.Location+"')", sqlObj);
            //SqlCommand sqlCmd2 = new SqlCommand("insert into EmployeeDetails values(" + detailsMode.EmpId + ",'" + detailsMode.EmpName + "','" + detailsMode.EmpJob + "','" + detailsMode.EmpSal + "'," + detailsMode.EmpDeptNo + ",'" + detailsMode.Location + "')", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCmd2.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

           // #region Disconnected Mode
           // SqlDataAdapter adp = new SqlDataAdapter("insert into EmployeeDetails values(" + detailsMode.EmpId + ",'" + detailsMode.EmpName + "','" + detailsMode.EmpJob + "','" + detailsMode.EmpSal + "'," + detailsMode.EmpDeptNo + ",'" + detailsMode.Location + "')", sqlObj);
           // adp.Fill(dt);
            //#endregion
            return "Employee Details Saved Successfully";
        }
        public string UpdateOp(DetailsMode detailsMode)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmd = new SqlCommand("update EmployeeDetails set EmpName = '" + detailsMode.EmpName + "', EmpJob = '" + detailsMode.EmpJob + "',EmpSal = '" + detailsMode.EmpSal + "', EmpDeptNo = " + detailsMode.EmpDeptNo + ", Location = '" + detailsMode.Location + "' where EmpId = " +detailsMode.EmpId+ " ", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

           // #region DisConnected Mode
           // SqlDataAdapter adp = new SqlDataAdapter("update EmployeeDetails set EmpName = '" + detailsMode.EmpName + "', EmpJob = '" + detailsMode.EmpJob + "',EmpSal = '" + detailsMode.EmpSal + "', EmpDeptNo = " + detailsMode.EmpDeptNo + ", Location = '" + detailsMode.Location + "' where EmpId = " + detailsMode.EmpId + " ", sqlObj);
            //adp.Fill(dt);
           // #endregion
            return "EmpId" + detailsMode.EmpId+ "Employee Details Updated Successfully";
        }
        public string DeletebyId(int EmpId)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmd = new SqlCommand("delete from EmployeeDetails where EmpId = " + EmpId + " ", sqlObj);
            sqlObj.Open();
            sqlCmd.ExecuteNonQuery();
            sqlObj.Close();
            #endregion

           // #region DisConnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("delete from EmployeeDetails where EmpId = " + EmpId + " ", sqlObj);
            //adp.Fill(dt);
            //#endregion
            return "EmpId" + EmpId + "Employee Details Deleted Successfully";
        }
        public DataTable SelectOp()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmdObj = new SqlCommand("select * from EmployeeDetails", sqlObj);
            sqlObj.Open();
            SqlDataReader sqlReaderObj = sqlCmdObj.ExecuteReader();
            dt.Load(sqlReaderObj);
            sqlObj.Close();
            #endregion

           // #region Disconnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("select * from EmployeeDetails", sqlObj);
           // adp.Fill(dt);
            //#endregion
            return dt;
        }
        public DataTable EditbyId(int EmpId)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlObj = new SqlConnection(sqlConnectionstr);
            #region Connected Mode
            SqlCommand sqlCmdObj = new SqlCommand("select * from EmployeeDetails where EmpId = " +EmpId+ " ", sqlObj);
            sqlObj.Open();
            SqlDataReader sqlReaderObj = sqlCmdObj.ExecuteReader();
            dt.Load(sqlReaderObj);
            sqlObj.Close();
            #endregion

           // #region Disconnected Mode
            //SqlDataAdapter adp = new SqlDataAdapter("select * from EmployeeDetails where EmpId = " + EmpId + " ", sqlObj);
           // adp.Fill(dt);
            //#endregion
            return dt;
        }

    }
}