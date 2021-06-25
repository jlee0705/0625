using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptView : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptView()
        {
            InitializeComponent();
        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void initList()
        {
            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice,
                "김담당", "박고객"
            };
            viewList.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(),"2021년 6월24일","김담당","박고객"
                    }
                    ));
            }
        }

        public void initList(List<ReceiptVO> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice = string.Format("{0:#,0}원", list[i].Totalprice);
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),list[i].Indate,
                        strPrice, list[i].StaffName,
                        list[i].CustName
                    }
                    ));
            }
            CommUtil.setRowColor(viewList, Color.White, Color.LightGray);
            int index = viewList.Items.Count - 1;
            viewList.Items[index].Selected = true;
            viewList.Items[index].Focused = true;
            viewList.EnsureVisible(index);
        }

        public void initGrid()
        {
            string strPrice = string.Format("{0:#,0}원", 80000);
            string[] data = { "1", "엔진오일 교환", strPrice };
            viewGrid.Rows.Add(data);

            for(int i=0; i<50; i++)
            {
                viewGrid.Rows.Add(new string[]
                {
                    (i+2).ToString(), "부동액 교환", strPrice
                });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell = viewGrid.Rows[count - 1].Cells[0];

        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            CommUtil.colorListViewHeader(ref viewList, Color.Indigo, Color.White);
            List<ReceiptVO> list = adapter.GetReceiptDb();
            initList(list);
            initGrid();
        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewList.SelectedItems.Count != 0)
            {
                Console.WriteLine("");
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string cust = viewList.Items[n].SubItems[4].Text;
                Console.WriteLine("번호 : " + num);
                Console.WriteLine("접수날짜: " + date);
                Console.WriteLine("총결제금액: " + price);
                Console.WriteLine("담당자: " + staff);
                Console.WriteLine("고객명: " + cust);

                List<RepairItem> list = adapter.GetRepairItemsDb(cust);
                for(int i=0; i<list.Count; i++)
                {
                    Console.WriteLine("수리항목: " + list[i].Repair);
                    Console.WriteLine("수리비: " + list[i]. Price);
                };
                
            }
        }

        
    }
}