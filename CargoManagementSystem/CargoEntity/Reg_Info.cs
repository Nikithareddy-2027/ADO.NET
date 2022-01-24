using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FirstName varchar(50), Lastname varchar(50), Email varchar(100),PhoneNumber numeric, Password varchar(50), Re_enterpassword varchar(50) 
namespace CargoEntity
{
    public class Reg_Info
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Re_enterPassword { get; set;}
    }
}
