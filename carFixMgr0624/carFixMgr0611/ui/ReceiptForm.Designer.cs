﻿
namespace carFixMgr0611.ui
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.custTelH = new Sunny.UI.UIComboBox();
            this.custTelB = new Sunny.UI.UITextBox();
            this.custYear = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custMonth = new Sunny.UI.UIComboBox();
            this.custDay = new Sunny.UI.UIComboBox();
            this.carModel = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.carNum = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.carCC = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.carYear = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.chk1 = new Sunny.UI.UICheckBox();
            this.chk2 = new Sunny.UI.UICheckBox();
            this.chk3 = new Sunny.UI.UICheckBox();
            this.chk6 = new Sunny.UI.UICheckBox();
            this.chk5 = new Sunny.UI.UICheckBox();
            this.chk4 = new Sunny.UI.UICheckBox();
            this.chk10 = new Sunny.UI.UICheckBox();
            this.receiptSave = new Sunny.UI.UISymbolButton();
            this.receiptClose = new Sunny.UI.UISymbolButton();
            this.chk9 = new Sunny.UI.UICheckBox();
            this.chk8 = new Sunny.UI.UICheckBox();
            this.chk7 = new Sunny.UI.UICheckBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.staffName = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(74, 87);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.SkyBlue;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "이 름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custName
            // 
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(215, 87);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(5);
            this.custName.Size = new System.Drawing.Size(130, 36);
            this.custName.Style = Sunny.UI.UIStyle.Custom;
            this.custName.TabIndex = 1;
            this.custName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(74, 130);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.SkyBlue;
            this.uiSymbolLabel2.TabIndex = 2;
            this.uiSymbolLabel2.Text = "전 화";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelH
            // 
            this.custTelH.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custTelH.FillColor = System.Drawing.Color.White;
            this.custTelH.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTelH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.custTelH.Items.AddRange(new object[] {
            "010",
            "011"});
            this.custTelH.Location = new System.Drawing.Point(215, 133);
            this.custTelH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTelH.MinimumSize = new System.Drawing.Size(63, 0);
            this.custTelH.Name = "custTelH";
            this.custTelH.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custTelH.Size = new System.Drawing.Size(80, 29);
            this.custTelH.TabIndex = 3;
            this.custTelH.Text = "선택";
            this.custTelH.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelB
            // 
            this.custTelB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTelB.FillColor = System.Drawing.Color.White;
            this.custTelB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTelB.Location = new System.Drawing.Point(303, 130);
            this.custTelB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTelB.Maximum = 2147483647D;
            this.custTelB.Minimum = -2147483648D;
            this.custTelB.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTelB.Name = "custTelB";
            this.custTelB.Padding = new System.Windows.Forms.Padding(5);
            this.custTelB.Size = new System.Drawing.Size(168, 36);
            this.custTelB.TabIndex = 2;
            this.custTelB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custYear
            // 
            this.custYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custYear.FillColor = System.Drawing.Color.White;
            this.custYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custYear.Items.AddRange(new object[] {
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.custYear.Location = new System.Drawing.Point(215, 172);
            this.custYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.custYear.Name = "custYear";
            this.custYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custYear.Size = new System.Drawing.Size(80, 29);
            this.custYear.TabIndex = 5;
            this.custYear.Text = "선택";
            this.custYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(74, 169);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel3.Symbol = 61949;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.SkyBlue;
            this.uiSymbolLabel3.TabIndex = 4;
            this.uiSymbolLabel3.Text = "생년월일";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custMonth
            // 
            this.custMonth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custMonth.FillColor = System.Drawing.Color.White;
            this.custMonth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.custMonth.Location = new System.Drawing.Point(303, 172);
            this.custMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custMonth.MinimumSize = new System.Drawing.Size(63, 0);
            this.custMonth.Name = "custMonth";
            this.custMonth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custMonth.Size = new System.Drawing.Size(80, 29);
            this.custMonth.TabIndex = 6;
            this.custMonth.Text = "선택";
            this.custMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custDay
            // 
            this.custDay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custDay.FillColor = System.Drawing.Color.White;
            this.custDay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.custDay.Location = new System.Drawing.Point(391, 172);
            this.custDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custDay.MinimumSize = new System.Drawing.Size(63, 0);
            this.custDay.Name = "custDay";
            this.custDay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custDay.Size = new System.Drawing.Size(80, 29);
            this.custDay.TabIndex = 6;
            this.custDay.Text = "선택";
            this.custDay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carModel
            // 
            this.carModel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carModel.FillColor = System.Drawing.Color.White;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carModel.Items.AddRange(new object[] {
            "아반떼",
            "벨로스터",
            "아이오닉",
            "소나타",
            "그랜저",
            "제네시스",
            "투싼",
            "싼타페",
            "펠리세이드",
            "스타렉스",
            "모닝",
            "레이",
            "K3",
            "K5",
            "K7",
            "K8",
            "K9",
            "스팅어"});
            this.carModel.Location = new System.Drawing.Point(215, 237);
            this.carModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.carModel.Name = "carModel";
            this.carModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carModel.Size = new System.Drawing.Size(130, 29);
            this.carModel.TabIndex = 8;
            this.carModel.Text = "선택";
            this.carModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(74, 234);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel4.Symbol = 61881;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel4.TabIndex = 7;
            this.uiSymbolLabel4.Text = "차량모델";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carNum
            // 
            this.carNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carNum.FillColor = System.Drawing.Color.White;
            this.carNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carNum.Location = new System.Drawing.Point(215, 276);
            this.carNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carNum.Maximum = 2147483647D;
            this.carNum.Minimum = -2147483648D;
            this.carNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.carNum.Name = "carNum";
            this.carNum.Padding = new System.Windows.Forms.Padding(5);
            this.carNum.Size = new System.Drawing.Size(130, 36);
            this.carNum.TabIndex = 10;
            this.carNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(74, 276);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel5.Symbol = 61881;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel5.TabIndex = 9;
            this.uiSymbolLabel5.Text = "차량번호";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carCC
            // 
            this.carCC.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carCC.FillColor = System.Drawing.Color.White;
            this.carCC.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCC.Items.AddRange(new object[] {
            "1000cc 이하",
            "1600cc 이하",
            "2000cc 이하",
            "2500cc 이하",
            "2500cc 초과"});
            this.carCC.Location = new System.Drawing.Point(215, 321);
            this.carCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carCC.MinimumSize = new System.Drawing.Size(63, 0);
            this.carCC.Name = "carCC";
            this.carCC.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carCC.Size = new System.Drawing.Size(130, 29);
            this.carCC.TabIndex = 12;
            this.carCC.Text = "선택";
            this.carCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(74, 318);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel6.Symbol = 61881;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel6.TabIndex = 11;
            this.uiSymbolLabel6.Text = "배 기 량";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carYear
            // 
            this.carYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carYear.FillColor = System.Drawing.Color.White;
            this.carYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carYear.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.carYear.Location = new System.Drawing.Point(215, 363);
            this.carYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.carYear.Name = "carYear";
            this.carYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carYear.Size = new System.Drawing.Size(130, 29);
            this.carYear.TabIndex = 14;
            this.carYear.Text = "선택";
            this.carYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(74, 360);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel7.Symbol = 61881;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel7.TabIndex = 13;
            this.uiSymbolLabel7.Text = "차량연식";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.Location = new System.Drawing.Point(74, 429);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel8.Symbol = 62142;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.PaleVioletRed;
            this.uiSymbolLabel8.TabIndex = 15;
            this.uiSymbolLabel8.Text = "담 당 자";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel9.Location = new System.Drawing.Point(74, 470);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(106, 36);
            this.uiSymbolLabel9.Symbol = 61613;
            this.uiSymbolLabel9.SymbolColor = System.Drawing.Color.PaleVioletRed;
            this.uiSymbolLabel9.TabIndex = 17;
            this.uiSymbolLabel9.Text = "수리항목";
            this.uiSymbolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk1
            // 
            this.chk1.BackColor = System.Drawing.Color.Transparent;
            this.chk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk1.Location = new System.Drawing.Point(215, 473);
            this.chk1.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk1.Name = "chk1";
            this.chk1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk1.Size = new System.Drawing.Size(146, 33);
            this.chk1.TabIndex = 20;
            this.chk1.Text = "엔진오일";
            // 
            // chk2
            // 
            this.chk2.BackColor = System.Drawing.Color.Transparent;
            this.chk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk2.Location = new System.Drawing.Point(357, 470);
            this.chk2.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk2.Name = "chk2";
            this.chk2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk2.Size = new System.Drawing.Size(146, 33);
            this.chk2.TabIndex = 21;
            this.chk2.Text = "에어컨 필터";
            // 
            // chk3
            // 
            this.chk3.BackColor = System.Drawing.Color.Transparent;
            this.chk3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk3.Location = new System.Drawing.Point(509, 470);
            this.chk3.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk3.Name = "chk3";
            this.chk3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk3.Size = new System.Drawing.Size(146, 33);
            this.chk3.TabIndex = 22;
            this.chk3.Text = "타이어 교체";
            // 
            // chk6
            // 
            this.chk6.BackColor = System.Drawing.Color.Transparent;
            this.chk6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk6.Location = new System.Drawing.Point(509, 509);
            this.chk6.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk6.Name = "chk6";
            this.chk6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk6.Size = new System.Drawing.Size(146, 33);
            this.chk6.TabIndex = 25;
            this.chk6.Text = "브레이크 오일";
            // 
            // chk5
            // 
            this.chk5.BackColor = System.Drawing.Color.Transparent;
            this.chk5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk5.Location = new System.Drawing.Point(357, 509);
            this.chk5.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk5.Name = "chk5";
            this.chk5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk5.Size = new System.Drawing.Size(146, 33);
            this.chk5.TabIndex = 24;
            this.chk5.Text = "휠 밸런스";
            // 
            // chk4
            // 
            this.chk4.BackColor = System.Drawing.Color.Transparent;
            this.chk4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk4.Location = new System.Drawing.Point(215, 508);
            this.chk4.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk4.Name = "chk4";
            this.chk4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk4.Size = new System.Drawing.Size(146, 33);
            this.chk4.TabIndex = 23;
            this.chk4.Text = "와이퍼 교체";
            // 
            // chk10
            // 
            this.chk10.BackColor = System.Drawing.Color.Transparent;
            this.chk10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk10.Location = new System.Drawing.Point(215, 583);
            this.chk10.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk10.Name = "chk10";
            this.chk10.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk10.Size = new System.Drawing.Size(146, 33);
            this.chk10.TabIndex = 26;
            this.chk10.Text = "기타 공임비";
            // 
            // receiptSave
            // 
            this.receiptSave.BackColor = System.Drawing.Color.Transparent;
            this.receiptSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptSave.Location = new System.Drawing.Point(199, 649);
            this.receiptSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.receiptSave.Name = "receiptSave";
            this.receiptSave.Radius = 30;
            this.receiptSave.Size = new System.Drawing.Size(132, 57);
            this.receiptSave.Style = Sunny.UI.UIStyle.Custom;
            this.receiptSave.Symbol = 61639;
            this.receiptSave.TabIndex = 27;
            this.receiptSave.Text = "저 장";
            this.receiptSave.Click += new System.EventHandler(this.receiptSave_Click);
            // 
            // receiptClose
            // 
            this.receiptClose.BackColor = System.Drawing.Color.Transparent;
            this.receiptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.receiptClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptClose.Location = new System.Drawing.Point(357, 649);
            this.receiptClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.receiptClose.Name = "receiptClose";
            this.receiptClose.Radius = 30;
            this.receiptClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.receiptClose.Size = new System.Drawing.Size(132, 57);
            this.receiptClose.Style = Sunny.UI.UIStyle.Custom;
            this.receiptClose.Symbol = 61457;
            this.receiptClose.TabIndex = 28;
            this.receiptClose.Text = "닫 기";
            this.receiptClose.Click += new System.EventHandler(this.receiptClose_Click);
            // 
            // chk9
            // 
            this.chk9.BackColor = System.Drawing.Color.Transparent;
            this.chk9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk9.Location = new System.Drawing.Point(509, 547);
            this.chk9.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk9.Name = "chk9";
            this.chk9.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk9.Size = new System.Drawing.Size(146, 33);
            this.chk9.TabIndex = 31;
            this.chk9.Text = "부동액";
            // 
            // chk8
            // 
            this.chk8.BackColor = System.Drawing.Color.Transparent;
            this.chk8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk8.Location = new System.Drawing.Point(357, 547);
            this.chk8.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk8.Name = "chk8";
            this.chk8.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk8.Size = new System.Drawing.Size(146, 33);
            this.chk8.TabIndex = 30;
            this.chk8.Text = "정기 검진";
            // 
            // chk7
            // 
            this.chk7.BackColor = System.Drawing.Color.Transparent;
            this.chk7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk7.Location = new System.Drawing.Point(215, 547);
            this.chk7.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk7.Name = "chk7";
            this.chk7.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk7.Size = new System.Drawing.Size(146, 33);
            this.chk7.TabIndex = 29;
            this.chk7.Text = "에어컨 가스";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Silver;
            this.uiLine1.Location = new System.Drawing.Point(74, 217);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(538, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 32;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Silver;
            this.uiLine2.Location = new System.Drawing.Point(74, 408);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(538, 2);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 33;
            // 
            // staffName
            // 
            this.staffName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.staffName.FillColor = System.Drawing.Color.White;
            this.staffName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.staffName.Items.AddRange(new object[] {
            "전우치",
            "김우치",
            "박우치",
            "이우치"});
            this.staffName.Location = new System.Drawing.Point(215, 429);
            this.staffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffName.MinimumSize = new System.Drawing.Size(63, 0);
            this.staffName.Name = "staffName";
            this.staffName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.staffName.Size = new System.Drawing.Size(130, 29);
            this.staffName.TabIndex = 15;
            this.staffName.Text = "선택";
            this.staffName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 718);
            this.ControlBox = false;
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.chk9);
            this.Controls.Add(this.chk8);
            this.Controls.Add(this.chk7);
            this.Controls.Add(this.receiptClose);
            this.Controls.Add(this.receiptSave);
            this.Controls.Add(this.chk10);
            this.Controls.Add(this.chk6);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.carCC);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.carNum);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.custDay);
            this.Controls.Add(this.custMonth);
            this.Controls.Add(this.custYear);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custTelB);
            this.Controls.Add(this.custTelH);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 정보 등록";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIComboBox custTelH;
        private Sunny.UI.UITextBox custTelB;
        private Sunny.UI.UIComboBox custYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIComboBox custMonth;
        private Sunny.UI.UIComboBox custDay;
        private Sunny.UI.UIComboBox carModel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox carNum;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIComboBox carCC;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UIComboBox carYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UICheckBox chk1;
        private Sunny.UI.UICheckBox chk2;
        private Sunny.UI.UICheckBox chk3;
        private Sunny.UI.UICheckBox chk6;
        private Sunny.UI.UICheckBox chk5;
        private Sunny.UI.UICheckBox chk4;
        private Sunny.UI.UICheckBox chk10;
        private Sunny.UI.UISymbolButton receiptSave;
        private Sunny.UI.UISymbolButton receiptClose;
        private Sunny.UI.UICheckBox chk9;
        private Sunny.UI.UICheckBox chk8;
        private Sunny.UI.UICheckBox chk7;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIComboBox staffName;
    }
}