using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoEntity
{
    public class Bill_Info
    {
        public int BillNo { get; set; }
        public int CustId { get; set; }
        public int TransId { get; set; }
        public string Date { get; set; }
        public int AmountPaid { get; set; }
    }
}
