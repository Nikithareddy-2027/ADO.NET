using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoData;
using CargoEntity;

namespace CargoBussiness
{
   public  class register_Connection
    {
        public void InsertDetails(Reg_Info regObj)
        {
            RegisterDetails regConn = new RegisterDetails();
            regConn.InsertReg(regObj);

        }
        public DataTable GetDetails()
        {
            RegisterDetails regConn = new RegisterDetails();
            DataTable dtObj = regConn.SelectReg();

            return dtObj;


        }
        public DataTable LoginCheck(string Email, string Password)
        {
            RegisterDetails regObj = new RegisterDetails();
            DataTable dt = regObj.LoginCheck(Email, Password);
            return dt;
        }
    }
}
