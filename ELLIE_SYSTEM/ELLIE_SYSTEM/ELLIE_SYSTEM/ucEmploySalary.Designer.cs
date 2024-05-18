namespace ELLIE_SYSTEM
{
    partial class ucEmploySalary
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.cbx_employee = new System.Windows.Forms.ComboBox();
            this.lbMassageA = new System.Windows.Forms.Label();
            this.lbMassage = new System.Windows.Forms.Label();
            this.labelMA = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.lbRelaxIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRelaxN = new System.Windows.Forms.Label();
            this.lbtrainN = new System.Windows.Forms.Label();
            this.lbsalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalaryCnt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSalaryCnt);
            this.splitContainer1.Size = new System.Drawing.Size(662, 457);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dtp_end);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.dtp_start);
            this.splitContainer2.Panel1.Controls.Add(this.cbx_employee);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbMassageA);
            this.splitContainer2.Panel2.Controls.Add(this.lbMassage);
            this.splitContainer2.Panel2.Controls.Add(this.labelMA);
            this.splitContainer2.Panel2.Controls.Add(this.labelM);
            this.splitContainer2.Panel2.Controls.Add(this.lbRelaxIncome);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.lbRelaxN);
            this.splitContainer2.Panel2.Controls.Add(this.lbtrainN);
            this.splitContainer2.Panel2.Controls.Add(this.lbsalary);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(662, 192);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 4;
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "yyyy-MM-dd";
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(237, 66);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(185, 30);
            this.dtp_end.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "結算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "yyyy-MM-dd";
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(237, 30);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(185, 30);
            this.dtp_start.TabIndex = 2;
            // 
            // cbx_employee
            // 
            this.cbx_employee.FormattingEnabled = true;
            this.cbx_employee.Location = new System.Drawing.Point(26, 30);
            this.cbx_employee.Name = "cbx_employee";
            this.cbx_employee.Size = new System.Drawing.Size(182, 31);
            this.cbx_employee.TabIndex = 0;
            this.cbx_employee.SelectedIndexChanged += new System.EventHandler(this.cbx_employee_SelectedIndexChanged);
            // 
            // lbMassageA
            // 
            this.lbMassageA.AutoSize = true;
            this.lbMassageA.Location = new System.Drawing.Point(106, 157);
            this.lbMassageA.Name = "lbMassageA";
            this.lbMassageA.Size = new System.Drawing.Size(20, 23);
            this.lbMassageA.TabIndex = 9;
            this.lbMassageA.Text = "1";
            // 
            // lbMassage
            // 
            this.lbMassage.AutoSize = true;
            this.lbMassage.Location = new System.Drawing.Point(106, 87);
            this.lbMassage.Name = "lbMassage";
            this.lbMassage.Size = new System.Drawing.Size(20, 23);
            this.lbMassage.TabIndex = 8;
            this.lbMassage.Text = "1";
            // 
            // labelMA
            // 
            this.labelMA.AutoSize = true;
            this.labelMA.Location = new System.Drawing.Point(18, 157);
            this.labelMA.Name = "labelMA";
            this.labelMA.Size = new System.Drawing.Size(82, 23);
            this.labelMA.TabIndex = 7;
            this.labelMA.Text = "淋巴總額";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(18, 87);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(82, 23);
            this.labelM.TabIndex = 6;
            this.labelM.Text = "淋巴堂數";
            // 
            // lbRelaxIncome
            // 
            this.lbRelaxIncome.AutoSize = true;
            this.lbRelaxIncome.Location = new System.Drawing.Point(106, 124);
            this.lbRelaxIncome.Name = "lbRelaxIncome";
            this.lbRelaxIncome.Size = new System.Drawing.Size(20, 23);
            this.lbRelaxIncome.TabIndex = 5;
            this.lbRelaxIncome.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "放鬆總額";
            // 
            // lbRelaxN
            // 
            this.lbRelaxN.AutoSize = true;
            this.lbRelaxN.Location = new System.Drawing.Point(106, 53);
            this.lbRelaxN.Name = "lbRelaxN";
            this.lbRelaxN.Size = new System.Drawing.Size(20, 23);
            this.lbRelaxN.TabIndex = 3;
            this.lbRelaxN.Text = "1";
            // 
            // lbtrainN
            // 
            this.lbtrainN.AutoSize = true;
            this.lbtrainN.Location = new System.Drawing.Point(106, 18);
            this.lbtrainN.Name = "lbtrainN";
            this.lbtrainN.Size = new System.Drawing.Size(20, 23);
            this.lbtrainN.TabIndex = 2;
            this.lbtrainN.Text = "1";
            // 
            // lbsalary
            // 
            this.lbsalary.AutoSize = true;
            this.lbsalary.Location = new System.Drawing.Point(18, 53);
            this.lbsalary.Name = "lbsalary";
            this.lbsalary.Size = new System.Drawing.Size(82, 23);
            this.lbsalary.TabIndex = 1;
            this.lbsalary.Text = "放鬆堂數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "訓練堂數";
            // 
            // dgvSalaryCnt
            // 
            this.dgvSalaryCnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalaryCnt.Location = new System.Drawing.Point(0, 0);
            this.dgvSalaryCnt.Name = "dgvSalaryCnt";
            this.dgvSalaryCnt.RowHeadersWidth = 62;
            this.dgvSalaryCnt.RowTemplate.Height = 32;
            this.dgvSalaryCnt.Size = new System.Drawing.Size(662, 261);
            this.dgvSalaryCnt.TabIndex = 0;
            // 
            // ucEmploySalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucEmploySalary";
            this.Size = new System.Drawing.Size(662, 457);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryCnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cbx_employee;
        private DataGridView dgvSalaryCnt;
        private Button button1;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private SplitContainer splitContainer2;
        private Label lbRelaxN;
        private Label lbtrainN;
        private Label lbsalary;
        private Label label1;
        private Label lbRelaxIncome;
        private Label label2;
        private Label lbMassageA;
        private Label lbMassage;
        private Label labelMA;
        private Label labelM;
    }
}
