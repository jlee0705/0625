using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    class ReceiptVO
    {
        private string indate;
        private int totalprice;
        private string custName;
        private string staffName;

        public ReceiptVO(string indate, int totalprice, string custName, string staffName)
        {
            this.indate = indate;
            this.totalprice = totalprice;
            this.custName = custName;
            this.staffName = staffName;
        }

        public string Indate { get => indate; set => indate = value; }
        public int Totalprice { get => totalprice; set => totalprice = value; }
        public string CustName { get => custName; set => custName = value; }
        public string StaffName { get => staffName; set => staffName = value; }
    }
}
