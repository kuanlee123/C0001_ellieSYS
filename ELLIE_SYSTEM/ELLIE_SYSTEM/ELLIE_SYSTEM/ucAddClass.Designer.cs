namespace ELLIE_SYSTEM
{
    partial class ucAddClass
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
            this.btnRemainClassQuery = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMassage = new System.Windows.Forms.RadioButton();
            this.rbcommon = new System.Windows.Forms.RadioButton();
            this.rbrelax = new System.Windows.Forms.RadioButton();
            this.rbtraining = new System.Windows.Forms.RadioButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAdName = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.dgvRemainClassList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemainClassQuery
            // 
            this.btnRemainClassQuery.Location = new System.Drawing.Point(3, 61);
            this.btnRemainClassQuery.Name = "btnRemainClassQuery";
            this.btnRemainClassQuery.Size = new System.Drawing.Size(119, 33);
            this.btnRemainClassQuery.TabIndex = 0;
            this.btnRemainClassQuery.Text = "查詢";
            this.btnRemainClassQuery.UseVisualStyleBackColor = true;
            this.btnRemainClassQuery.Click += new System.EventHandler(this.button1_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvRemainClassList);
            this.splitContainer1.Size = new System.Drawing.Size(711, 448);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(711, 210);
            this.splitContainer2.SplitterDistance = 37;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(711, 169);
            this.splitContainer3.SplitterDistance = 112;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMassage);
            this.groupBox1.Controls.Add(this.rbcommon);
            this.groupBox1.Controls.Add(this.rbrelax);
            this.groupBox1.Controls.Add(this.rbtraining);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "課別";
            // 
            // rbMassage
            // 
            this.rbMassage.AutoSize = true;
            this.rbMassage.Location = new System.Drawing.Point(11, 128);
            this.rbMassage.Name = "rbMassage";
            this.rbMassage.Size = new System.Drawing.Size(71, 27);
            this.rbMassage.TabIndex = 3;
            this.rbMassage.TabStop = true;
            this.rbMassage.Text = "淋巴";
            this.rbMassage.UseVisualStyleBackColor = true;
            // 
            // rbcommon
            // 
            this.rbcommon.AutoSize = true;
            this.rbcommon.Location = new System.Drawing.Point(9, 92);
            this.rbcommon.Name = "rbcommon";
            this.rbcommon.Size = new System.Drawing.Size(71, 27);
            this.rbcommon.TabIndex = 2;
            this.rbcommon.Text = "共同";
            this.rbcommon.UseVisualStyleBackColor = true;
            // 
            // rbrelax
            // 
            this.rbrelax.AutoSize = true;
            this.rbrelax.Location = new System.Drawing.Point(8, 58);
            this.rbrelax.Name = "rbrelax";
            this.rbrelax.Size = new System.Drawing.Size(71, 27);
            this.rbrelax.TabIndex = 1;
            this.rbrelax.Text = "放鬆";
            this.rbrelax.UseVisualStyleBackColor = true;
            // 
            // rbtraining
            // 
            this.rbtraining.AutoSize = true;
            this.rbtraining.Checked = true;
            this.rbtraining.Location = new System.Drawing.Point(9, 25);
            this.rbtraining.Name = "rbtraining";
            this.rbtraining.Size = new System.Drawing.Size(71, 27);
            this.rbtraining.TabIndex = 0;
            this.rbtraining.TabStop = true;
            this.rbtraining.Text = "訓練";
            this.rbtraining.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(595, 169);
            this.splitContainer4.SplitterDistance = 229;
            this.splitContainer4.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tbxPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxAdName);
            this.groupBox2.Controls.Add(this.tbxAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸入資料";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(61, 96);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(150, 30);
            this.tbxPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "金額";
            // 
            // tbxAdName
            // 
            this.tbxAdName.Location = new System.Drawing.Point(61, 22);
            this.tbxAdName.Name = "tbxAdName";
            this.tbxAdName.Size = new System.Drawing.Size(150, 30);
            this.tbxAdName.TabIndex = 0;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(61, 58);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(150, 30);
            this.tbxAmount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "堂數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "會員";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnPurchase);
            this.splitContainer5.Panel1.Controls.Add(this.btnRemainClassQuery);
            this.splitContainer5.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer5_Panel1_Paint);
            this.splitContainer5.Size = new System.Drawing.Size(362, 169);
            this.splitContainer5.SplitterDistance = 128;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(3, 22);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(119, 33);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "購課";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // dgvRemainClassList
            // 
            this.dgvRemainClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemainClassList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRemainClassList.Location = new System.Drawing.Point(0, 0);
            this.dgvRemainClassList.Name = "dgvRemainClassList";
            this.dgvRemainClassList.RowHeadersWidth = 62;
            this.dgvRemainClassList.RowTemplate.Height = 32;
            this.dgvRemainClassList.Size = new System.Drawing.Size(711, 234);
            this.dgvRemainClassList.TabIndex = 0;
            this.dgvRemainClassList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemainClassList_CellContentClick);
            this.dgvRemainClassList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvRemainClassList_RowPostPaint);
            // 
            // ucAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucAddClass";
            this.Size = new System.Drawing.Size(711, 448);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemainClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRemainClassQuery;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private SplitContainer splitContainer3;
        private GroupBox groupBox1;
        private RadioButton rbcommon;
        private RadioButton rbrelax;
        private RadioButton rbtraining;
        private Button btnPurchase;
        private TextBox tbxAmount;
        private Label label3;
        private Label label2;
        private TextBox tbxAdName;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private GroupBox groupBox2;
        private TextBox tbxPrice;
        private Label label4;
        private DataGridView dgvRemainClassList;
        private RadioButton rbMassage;
    }
}
