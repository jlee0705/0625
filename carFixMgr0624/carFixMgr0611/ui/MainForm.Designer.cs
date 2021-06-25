
namespace carFixMgr0611
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custFixView = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdmin = new CxFlatUI.CxFlatRoundButton();
            this.custFixRand = new CxFlatUI.CxFlatRoundButton();
            this.custfixInfo = new CxFlatUI.CxFlatRoundButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custFixAdd = new CxFlatUI.CxFlatRoundButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // custFixView
            // 
            this.custFixView.BackColor = System.Drawing.Color.Black;
            this.custFixView.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixView.Location = new System.Drawing.Point(473, 179);
            this.custFixView.Name = "custFixView";
            this.custFixView.Size = new System.Drawing.Size(223, 46);
            this.custFixView.TabIndex = 2;
            this.custFixView.Text = "수리 내역";
            this.custFixView.TextColor = System.Drawing.Color.White;
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.ButtonType = CxFlatUI.ButtonType.Waring;
            this.custFixAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(533, 268);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(223, 46);
            this.custFixAdmin.TabIndex = 3;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.TextColor = System.Drawing.Color.White;
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custFixRand
            // 
            this.custFixRand.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixRand.Location = new System.Drawing.Point(463, 357);
            this.custFixRand.Name = "custFixRand";
            this.custFixRand.Size = new System.Drawing.Size(223, 46);
            this.custFixRand.TabIndex = 4;
            this.custFixRand.Text = "랜덤 데이터 추가";
            this.custFixRand.TextColor = System.Drawing.Color.White;
            this.custFixRand.Click += new System.EventHandler(this.custFixRand_Click);
            // 
            // custfixInfo
            // 
            this.custfixInfo.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custfixInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custfixInfo.Location = new System.Drawing.Point(417, 446);
            this.custfixInfo.Name = "custfixInfo";
            this.custfixInfo.Size = new System.Drawing.Size(223, 46);
            this.custfixInfo.TabIndex = 5;
            this.custfixInfo.Text = "앱 정보";
            this.custfixInfo.TextColor = System.Drawing.Color.White;
            this.custfixInfo.Click += new System.EventHandler(this.custfixInfo_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeColor = System.Drawing.Color.Red;
            this.mainExit.Location = new System.Drawing.Point(743, 19);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Red;
            this.mainExit.Size = new System.Drawing.Size(40, 30);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 6);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(186, 43);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Yellow;
            this.uiSymbolLabel1.SymbolSize = 36;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // custFixAdd
            // 
            this.custFixAdd.BackColor = System.Drawing.Color.Black;
            this.custFixAdd.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(417, 89);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.Size = new System.Drawing.Size(223, 46);
            this.custFixAdd.TabIndex = 9;
            this.custFixAdd.Text = "고객정보 접수";
            this.custFixAdd.TextColor = System.Drawing.Color.White;
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.ForeColor = System.Drawing.Color.Red;
            this.mainMin.Location = new System.Drawing.Point(697, 19);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Red;
            this.mainMin.Size = new System.Drawing.Size(40, 30);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.TabIndex = 10;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 534);
            this.ControlBox = false;
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custfixInfo);
            this.Controls.Add(this.custFixRand);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CxFlatUI.CxFlatRoundButton custFixView;
        private CxFlatUI.CxFlatRoundButton custFixAdmin;
        private CxFlatUI.CxFlatRoundButton custFixRand;
        private CxFlatUI.CxFlatRoundButton custfixInfo;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatRoundButton custFixAdd;
        private Sunny.UI.UISymbolButton mainMin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

