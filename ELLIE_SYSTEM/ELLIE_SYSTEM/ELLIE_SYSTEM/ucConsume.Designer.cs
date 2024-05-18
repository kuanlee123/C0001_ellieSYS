namespace ELLIE_SYSTEM
{
    partial class ucConsume
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
            this.lbCurUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTeacherList = new System.Windows.Forms.ComboBox();
            this.dgvConsume = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbRemainClass_M = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRemainClass_c = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRemainClass_r = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRemainClass_t = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbc_M = new System.Windows.Forms.RadioButton();
            this.rbc_c = new System.Windows.Forms.RadioButton();
            this.rbc_r = new System.Windows.Forms.RadioButton();
            this.rbc_t = new System.Windows.Forms.RadioButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsumeClass = new System.Windows.Forms.Button();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsume)).BeginInit();
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
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCurUser
            // 
            this.lbCurUser.AutoSize = true;
            this.lbCurUser.Location = new System.Drawing.Point(118, 17);
            this.lbCurUser.Name = "lbCurUser";
            this.lbCurUser.Size = new System.Drawing.Size(61, 23);
            this.lbCurUser.TabIndex = 0;
            this.lbCurUser.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "目前登入者";
            // 
            // cbxTeacherList
            // 
            this.cbxTeacherList.FormattingEnabled = true;
            this.cbxTeacherList.Location = new System.Drawing.Point(6, 29);
            this.cbxTeacherList.Name = "cbxTeacherList";
            this.cbxTeacherList.Size = new System.Drawing.Size(161, 31);
            this.cbxTeacherList.TabIndex = 3;
            this.cbxTeacherList.SelectedIndexChanged += new System.EventHandler(this.cbxTeacherList_SelectedIndexChanged);
            // 
            // dgvConsume
            // 
            this.dgvConsume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsume.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvConsume.Location = new System.Drawing.Point(0, 0);
            this.dgvConsume.Name = "dgvConsume";
            this.dgvConsume.RowHeadersWidth = 62;
            this.dgvConsume.RowTemplate.Height = 32;
            this.dgvConsume.Size = new System.Drawing.Size(641, 331);
            this.dgvConsume.TabIndex = 4;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvConsume);
            this.splitContainer1.Size = new System.Drawing.Size(641, 565);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 5;
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
            this.splitContainer2.Panel1.Controls.Add(this.lbRemainClass_M);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.lbRemainClass_c);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.lbRemainClass_r);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.lbRemainClass_t);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.lbCurUser);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(641, 230);
            this.splitContainer2.SplitterDistance = 84;
            this.splitContainer2.TabIndex = 4;
            // 
            // lbRemainClass_M
            // 
            this.lbRemainClass_M.AutoSize = true;
            this.lbRemainClass_M.Location = new System.Drawing.Point(542, 49);
            this.lbRemainClass_M.Name = "lbRemainClass_M";
            this.lbRemainClass_M.Size = new System.Drawing.Size(61, 23);
            this.lbRemainClass_M.TabIndex = 10;
            this.lbRemainClass_M.Text = "label8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "淋巴";
            // 
            // lbRemainClass_c
            // 
            this.lbRemainClass_c.AutoSize = true;
            this.lbRemainClass_c.Location = new System.Drawing.Point(413, 49);
            this.lbRemainClass_c.Name = "lbRemainClass_c";
            this.lbRemainClass_c.Size = new System.Drawing.Size(61, 23);
            this.lbRemainClass_c.TabIndex = 8;
            this.lbRemainClass_c.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "共同";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbRemainClass_r
            // 
            this.lbRemainClass_r.AutoSize = true;
            this.lbRemainClass_r.Location = new System.Drawing.Point(286, 49);
            this.lbRemainClass_r.Name = "lbRemainClass_r";
            this.lbRemainClass_r.Size = new System.Drawing.Size(61, 23);
            this.lbRemainClass_r.TabIndex = 6;
            this.lbRemainClass_r.Text = "label7";
            this.lbRemainClass_r.Click += new System.EventHandler(this.lbRemainClass_r_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "放鬆";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "訓練";
            // 
            // lbRemainClass_t
            // 
            this.lbRemainClass_t.AutoSize = true;
            this.lbRemainClass_t.Location = new System.Drawing.Point(161, 49);
            this.lbRemainClass_t.Name = "lbRemainClass_t";
            this.lbRemainClass_t.Size = new System.Drawing.Size(61, 23);
            this.lbRemainClass_t.TabIndex = 3;
            this.lbRemainClass_t.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "現有堂數";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gb1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(641, 142);
            this.splitContainer3.SplitterDistance = 116;
            this.splitContainer3.TabIndex = 5;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbc_M);
            this.gb1.Controls.Add(this.rbc_c);
            this.gb1.Controls.Add(this.rbc_r);
            this.gb1.Controls.Add(this.rbc_t);
            this.gb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb1.Location = new System.Drawing.Point(0, 0);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(116, 142);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "課別";
            // 
            // rbc_M
            // 
            this.rbc_M.AutoSize = true;
            this.rbc_M.Location = new System.Drawing.Point(8, 113);
            this.rbc_M.Name = "rbc_M";
            this.rbc_M.Size = new System.Drawing.Size(71, 27);
            this.rbc_M.TabIndex = 3;
            this.rbc_M.TabStop = true;
            this.rbc_M.Text = "淋巴";
            this.rbc_M.UseVisualStyleBackColor = true;
            // 
            // rbc_c
            // 
            this.rbc_c.AutoSize = true;
            this.rbc_c.Location = new System.Drawing.Point(7, 83);
            this.rbc_c.Name = "rbc_c";
            this.rbc_c.Size = new System.Drawing.Size(71, 27);
            this.rbc_c.TabIndex = 2;
            this.rbc_c.Text = "共同";
            this.rbc_c.UseVisualStyleBackColor = true;
            // 
            // rbc_r
            // 
            this.rbc_r.AutoSize = true;
            this.rbc_r.Location = new System.Drawing.Point(7, 55);
            this.rbc_r.Name = "rbc_r";
            this.rbc_r.Size = new System.Drawing.Size(71, 27);
            this.rbc_r.TabIndex = 1;
            this.rbc_r.Text = "放鬆";
            this.rbc_r.UseVisualStyleBackColor = true;
            // 
            // rbc_t
            // 
            this.rbc_t.AutoSize = true;
            this.rbc_t.Checked = true;
            this.rbc_t.Location = new System.Drawing.Point(8, 29);
            this.rbc_t.Name = "rbc_t";
            this.rbc_t.Size = new System.Drawing.Size(71, 27);
            this.rbc_t.TabIndex = 0;
            this.rbc_t.TabStop = true;
            this.rbc_t.Text = "訓練";
            this.rbc_t.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(521, 142);
            this.splitContainer4.SplitterDistance = 173;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsumeClass);
            this.groupBox1.Controls.Add(this.cbxTeacherList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇老師";
            // 
            // btnConsumeClass
            // 
            this.btnConsumeClass.Location = new System.Drawing.Point(29, 66);
            this.btnConsumeClass.Name = "btnConsumeClass";
            this.btnConsumeClass.Size = new System.Drawing.Size(112, 34);
            this.btnConsumeClass.TabIndex = 5;
            this.btnConsumeClass.Text = "上課";
            this.btnConsumeClass.UseVisualStyleBackColor = true;
            this.btnConsumeClass.Click += new System.EventHandler(this.btnConsumeClass_Click);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Size = new System.Drawing.Size(344, 142);
            this.splitContainer5.SplitterDistance = 114;
            this.splitContainer5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 4;
            // 
            // ucConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucConsume";
            this.Size = new System.Drawing.Size(641, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsume)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbCurUser;
        private Label label2;
        private ComboBox cbxTeacherList;
        private DataGridView dgvConsume;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label lbRemainClass_t;
        private Label label3;
        private Button btnConsumeClass;
        private Label label4;
        private SplitContainer splitContainer3;
        private GroupBox gb1;
        private RadioButton rbc_t;
        private RadioButton rbc_c;
        private RadioButton rbc_r;
        private Label label6;
        private Label label5;
        private Label lbRemainClass_c;
        private Label label7;
        private Label lbRemainClass_r;
        private SplitContainer splitContainer4;
        private GroupBox groupBox1;
        private SplitContainer splitContainer5;
        private Label lbRemainClass_M;
        private Label label1;
        private RadioButton rbc_M;
    }
}
