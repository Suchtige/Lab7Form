using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class customer
    {
        public int customerID { get; set; }
        public pass passID { get; set; }
        public string customerList { get; set; }

        public customer(int customerID, pass passID, string customerList)
        {
            this.customerID = customerID;
            this.customerList = customerList;
            this.passID = passID;
        }
    }
}
