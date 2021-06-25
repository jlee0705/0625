using carFixMgr0611.handler;
using carFixMgr0611.model;
using carFixMgr0611.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptForm : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        #region 고객 정보 저장 메쏘드
        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string number = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staffname = staffName.SelectedText;

            string[] arrData = new string[]
            {
                name, telH, telB, year, month,
                day, model, number, cc, caryear, 
                staffname
            };

            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear,
                custMonth, custDay, carModel, carNum,
                carCC, carYear, staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 선택하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "차량모델을 선택하세요",
                "차량번호를 입력하세요",
                "배기량을 선택하세요",
                "챠량연식을 선택하세요",
                "담당자를 선택하세요"
            };

            /////////////////////////////////////////
            /*
            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("")
                    || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i]);
                    ActiveControl = arrObj[i] as Control;
                    //ActiveControl = (Control)arrObj[i];
                    ActiveControl.Focus();
                    return;
                }
            }
            */
            Dictionary<object, string> dicInput =
                new Dictionary<object, string>();
            for (int i=0; i<arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            foreach(KeyValuePair<object, string> item in
                dicInput)
            {
                if (item.Value.Equals("") ||
                    item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, 
                        arrMsg[cnt]);
                    return;
                }
                cnt++;
            }


            /////////////////////////////////////////
            UICheckBox[] checkBox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5,
                chk6, chk7, chk8, chk9, chk10
            };

            int sum = 0;
            List<RepairItem> itemList = new List<RepairItem>();
            for (int i=RepairTable.ENGINE_OIL;
                i<RepairTable.ETC_COST+1; i++)
            {
                if (checkBox[i].Checked)
                {
                    //Console.WriteLine("수리항목:"+checkBox[i].Text);
                    //Console.WriteLine("수리비"+RepairTable.fixMoney[i]);
                    itemList.Add(new RepairItem(i,
                        checkBox[i].Text, RepairTable.fixMoney[i]));
                    sum += RepairTable.fixMoney[i];
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }

            // 한글 입력 체크
            Regex regex =
                    new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName,
                    Properties.Resources.ERR_NAME_WRONG);
                return;
            }
            /*
            // 자리수 체크
            Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show(Properties.Resources.ERR_NAME_SIZE);
                ActiveControl = custName;
                ActiveControl.Focus();
                custName.Text = "";
                return;
            }
            */

            // 전화번호 체크
            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = 
                    new Regex(@"^01{1}[01]{1}[0-9]{7,8}$");
                Match m2 = regex2.Match(telAll);
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }

#if DEBUG_
            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화: " + (telH + telB));
            Console.WriteLine("생년월일: " + (year+month+day));
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + number);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + caryear);
            Console.WriteLine("담당자: " + staffname);
#endif

            adapter.addReceipt(new Receipt(
                new Customer(name, telH+telB, year+month+day),
                new Car(model, number, cc, caryear),
                DateTime.Now.ToString("yyyy년MM월dd일"),
                staffname, itemList, sum));

            Close();

        }
        #endregion

        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
