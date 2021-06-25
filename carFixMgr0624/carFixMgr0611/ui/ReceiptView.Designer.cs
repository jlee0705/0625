
namespace carFixMgr0611.ui
{
    partial class ReceiptView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewList = new System.Windows.Forms.ListView();
            this.lCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.gCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.viewSearch = new CxFlatUI.CxFlatTextBox();
            this.vSearch = new Sunny.UI.UISymbolButton();
            this.vSearchAll = new Sunny.UI.UISymbolButton();
            this.vConfirm = new Sunny.UI.UISymbolButton();
            this.vDelete = new Sunny.UI.UISymbolButton();
            this.vEdit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lCount,
            this.linDate,
            this.lTotalPrice,
            this.lStaffName,
            this.lCustName});
            this.viewList.FullRowSelect = true;
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(12, 129);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(688, 145);
            this.viewList.TabIndex = 0;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            this.viewList.SelectedIndexChanged += new System.EventHandler(this.viewList_SelectedIndexChanged);
            // 
            // lCount
            // 
            this.lCount.Text = "번호";
            // 
            // linDate
            // 
            this.linDate.Text = "접수날짜";
            this.linDate.Width = 100;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.Text = "총결제금액";
            this.lTotalPrice.Width = 120;
            // 
            // lStaffName
            // 
            this.lStaffName.Text = "담당자";
            this.lStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lStaffName.Width = 100;
            // 
            // lCustName
            // 
            this.lCustName.Text = "고객명";
            this.lCustName.Width = 100;
            // 
            // viewGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.ColumnHeadersHeight = 32;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gCount,
            this.gRepair,
            this.gPrice});
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(12, 402);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(688, 150);
            this.viewGrid.StyleCustomMode = true;
            this.viewGrid.TabIndex = 1;
            // 
            // gCount
            // 
            this.gCount.HeaderText = "번호";
            this.gCount.Name = "gCount";
            // 
            // gRepair
            // 
            this.gRepair.HeaderText = "수리항목";
            this.gRepair.Name = "gRepair";
            // 
            // gPrice
            // 
            this.gPrice.HeaderText = "수리비용";
            this.gPrice.Name = "gPrice";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 88);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(114, 35);
            this.uiSymbolLabel1.Symbol = 61484;
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "검색항목";
            // 
            // viewSelect
            // 
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Items.AddRange(new object[] {
            "고객명",
            "고객차량번호"});
            this.viewSelect.Location = new System.Drawing.Point(133, 88);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.Size = new System.Drawing.Size(143, 29);
            this.viewSelect.TabIndex = 3;
            this.viewSelect.Text = " 검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewSearch
            // 
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSearch.Hint = "검색어를 입력하세요";
            this.viewSearch.Location = new System.Drawing.Point(292, 83);
            this.viewSearch.MaxLength = 32767;
            this.viewSearch.Multiline = false;
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.PasswordChar = '\0';
            this.viewSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewSearch.SelectedText = "";
            this.viewSearch.SelectionLength = 0;
            this.viewSearch.SelectionStart = 0;
            this.viewSearch.Size = new System.Drawing.Size(174, 38);
            this.viewSearch.TabIndex = 4;
            this.viewSearch.TabStop = false;
            this.viewSearch.UseSystemPasswordChar = false;
            // 
            // vSearch
            // 
            this.vSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearch.FillColor = System.Drawing.Color.Transparent;
            this.vSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSearch.ForeColor = System.Drawing.Color.Black;
            this.vSearch.ForeHoverColor = System.Drawing.Color.RoyalBlue;
            this.vSearch.ForePressColor = System.Drawing.Color.RoyalBlue;
            this.vSearch.ForeSelectedColor = System.Drawing.Color.RoyalBlue;
            this.vSearch.Location = new System.Drawing.Point(485, 88);
            this.vSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearch.Name = "vSearch";
            this.vSearch.Size = new System.Drawing.Size(79, 35);
            this.vSearch.Style = Sunny.UI.UIStyle.Custom;
            this.vSearch.Symbol = 61454;
            this.vSearch.TabIndex = 5;
            this.vSearch.Text = "검색";
            // 
            // vSearchAll
            // 
            this.vSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchAll.FillColor = System.Drawing.Color.Transparent;
            this.vSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchAll.ForeColor = System.Drawing.Color.Black;
            this.vSearchAll.ForeHoverColor = System.Drawing.Color.RoyalBlue;
            this.vSearchAll.ForePressColor = System.Drawing.Color.RoyalBlue;
            this.vSearchAll.ForeSelectedColor = System.Drawing.Color.RoyalBlue;
            this.vSearchAll.Location = new System.Drawing.Point(582, 88);
            this.vSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchAll.Name = "vSearchAll";
            this.vSearchAll.Size = new System.Drawing.Size(118, 35);
            this.vSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.vSearchAll.Symbol = 61442;
            this.vSearchAll.TabIndex = 6;
            this.vSearchAll.Text = "전체 검색";
            // 
            // vConfirm
            // 
            this.vConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vConfirm.ForeColor = System.Drawing.Color.Black;
            this.vConfirm.Location = new System.Drawing.Point(451, 280);
            this.vConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.vConfirm.Name = "vConfirm";
            this.vConfirm.Size = new System.Drawing.Size(79, 35);
            this.vConfirm.Style = Sunny.UI.UIStyle.Custom;
            this.vConfirm.Symbol = 61639;
            this.vConfirm.TabIndex = 7;
            this.vConfirm.Text = "완료";
            // 
            // vDelete
            // 
            this.vDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vDelete.ForeColor = System.Drawing.Color.Black;
            this.vDelete.Location = new System.Drawing.Point(621, 280);
            this.vDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.vDelete.Name = "vDelete";
            this.vDelete.Size = new System.Drawing.Size(79, 35);
            this.vDelete.Style = Sunny.UI.UIStyle.Custom;
            this.vDelete.Symbol = 61453;
            this.vDelete.TabIndex = 8;
            this.vDelete.Text = "삭제";
            // 
            // vEdit
            // 
            this.vEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vEdit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vEdit.ForeColor = System.Drawing.Color.Black;
            this.vEdit.Location = new System.Drawing.Point(536, 280);
            this.vEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.vEdit.Name = "vEdit";
            this.vEdit.Size = new System.Drawing.Size(79, 35);
            this.vEdit.Style = Sunny.UI.UIStyle.Custom;
            this.vEdit.Symbol = 61508;
            this.vEdit.TabIndex = 9;
            this.vEdit.Text = "수정";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(12, 361);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(149, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 61613;
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "상세 수리내역";
            // 
            // viewExit
            // 
            this.viewExit.BackColor = System.Drawing.Color.Transparent;
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.Transparent;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.ForeColor = System.Drawing.Color.Red;
            this.viewExit.Location = new System.Drawing.Point(676, 12);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.RectColor = System.Drawing.Color.Red;
            this.viewExit.Size = new System.Drawing.Size(40, 30);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.Symbol = 61453;
            this.viewExit.TabIndex = 11;
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(280, 12);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(186, 43);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.SeaShell;
            this.uiSymbolLabel3.SymbolSize = 36;
            this.uiSymbolLabel3.TabIndex = 12;
            this.uiSymbolLabel3.Text = "접수 내역";
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 709);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.vEdit);
            this.Controls.Add(this.vDelete);
            this.Controls.Add(this.vConfirm);
            this.Controls.Add(this.vSearchAll);
            this.Controls.Add(this.vSearch);
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.viewList);
            this.Name = "ReceiptView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewList;
        private Sunny.UI.UIDataGridView viewGrid;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox viewSelect;
        private CxFlatUI.CxFlatTextBox viewSearch;
        private Sunny.UI.UISymbolButton vSearch;
        private Sunny.UI.UISymbolButton vSearchAll;
        private Sunny.UI.UISymbolButton vConfirm;
        private Sunny.UI.UISymbolButton vDelete;
        private Sunny.UI.UISymbolButton vEdit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton viewExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ColumnHeader lCount;
        private System.Windows.Forms.ColumnHeader linDate;
        private System.Windows.Forms.ColumnHeader lTotalPrice;
        private System.Windows.Forms.ColumnHeader lStaffName;
        private System.Windows.Forms.ColumnHeader lCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPrice;
    }
}