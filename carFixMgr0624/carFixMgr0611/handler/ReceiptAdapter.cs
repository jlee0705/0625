using carFixMgr0611.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList =
            new List<Receipt>();
        private OraHandler ora;
        
        public ReceiptAdapter(OraHandler ora)
        {
            this.ora = ora;
        }

        public void addReceipt(Receipt receipt)
        {
            receiptList.Add(receipt);
        }

        public void addReceiptDb()
        {
            for (int i=0; i<receiptList.Count; i++)
            {
                ora.insertDb(receiptList[i]);
            }
            receiptList.Clear();
        }

        public void viewReceipt()
        {
            for (int i=0; i<receiptList.Count; i++)
            {
                Customer cust = receiptList[i].Cust;
                Console.WriteLine("고객명: " + cust.Name);
                Console.WriteLine("고객전화: " + cust.Tel);
                Console.WriteLine("생년월일: " + cust.Birth);

                Car car = receiptList[i].Car;
                Console.WriteLine("모델명: " + car.Model);
                Console.WriteLine("차량번호: " + car.Number);
                Console.WriteLine("배기량: " + car.Cc);
                Console.WriteLine("차량연식: " + car.Year);

                Console.WriteLine("담당자: " + 
                    receiptList[i].StaffName);
                Console.WriteLine("접수날짜: " +
                    receiptList[i].InDate);

                List<RepairItem> itemList =
                    receiptList[i].ItemList;
                for (int j=0; j<itemList.Count; j++)
                {
                    Console.WriteLine("수리번호: " +
                        itemList[j].Idx);
                    Console.WriteLine("수리항목: " +
                        itemList[j].Repair);
                    Console.WriteLine("수리비용: " +
                        itemList[j].Price);
                }
                // 총결제금액 처리
            }
        }

        public void viewReceiptDb()
        {
            ora.showDB();
        }

        public List<ReceiptVO> GetReceiptDb()
        {
            List<ReceiptVO> list = ora.getReceipt();
            return list;
        }


        public List<RepairItem> GetRepairItemsDb(string name)
        {
            return ora.GetRepairItem(name);
        }
    }
}
