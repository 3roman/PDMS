namespace PDMSAddin
{
    partial class PdmsControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageMTO = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetNozzMTO = new System.Windows.Forms.Button();
            this.btnUnsetNozzMTO = new System.Windows.Forms.Button();
            this.btnSetTubeMTO = new System.Windows.Forms.Button();
            this.btnUnsetTubeMTO = new System.Windows.Forms.Button();
            this.btnUnsetPipeMTO = new System.Windows.Forms.Button();
            this.btnSetPipeMTO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstElements1 = new System.Windows.Forms.ListBox();
            this.btnAddCE = new System.Windows.Forms.Button();
            this.txtCE = new System.Windows.Forms.TextBox();
            this.aaaaa = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnManualsetMTO = new System.Windows.Forms.Button();
            this.btnManualUnSetMTO = new System.Windows.Forms.Button();
            this.pageInclude = new System.Windows.Forms.TabPage();
            this.btnAddCE2 = new System.Windows.Forms.Button();
            this.lstElements2 = new System.Windows.Forms.ListBox();
            this.btnSetOwner2 = new System.Windows.Forms.Button();
            this.txtOwner2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSort = new System.Windows.Forms.TabPage();
            this.btnMoveDown3 = new System.Windows.Forms.Button();
            this.btnMoveUp3 = new System.Windows.Forms.Button();
            this.lstElements3 = new System.Windows.Forms.ListBox();
            this.btnSetOwner3 = new System.Windows.Forms.Button();
            this.txtOwner3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pageMTO.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pageInclude.SuspendLayout();
            this.pageSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageMTO);
            this.tabControl1.Controls.Add(this.pageInclude);
            this.tabControl1.Controls.Add(this.pageSort);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 414);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // pageMTO
            // 
            this.pageMTO.Controls.Add(this.groupBox2);
            this.pageMTO.Controls.Add(this.groupBox1);
            this.pageMTO.Location = new System.Drawing.Point(4, 22);
            this.pageMTO.Name = "pageMTO";
            this.pageMTO.Padding = new System.Windows.Forms.Padding(3);
            this.pageMTO.Size = new System.Drawing.Size(258, 388);
            this.pageMTO.TabIndex = 0;
            this.pageMTO.Text = "出料设置";
            this.pageMTO.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetNozzMTO);
            this.groupBox2.Controls.Add(this.btnUnsetNozzMTO);
            this.groupBox2.Controls.Add(this.btnSetTubeMTO);
            this.groupBox2.Controls.Add(this.btnUnsetTubeMTO);
            this.groupBox2.Controls.Add(this.btnUnsetPipeMTO);
            this.groupBox2.Controls.Add(this.btnSetPipeMTO);
            this.groupBox2.Location = new System.Drawing.Point(6, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其它出料设置";
            // 
            // btnSetNozzMTO
            // 
            this.btnSetNozzMTO.Location = new System.Drawing.Point(125, 82);
            this.btnSetNozzMTO.Name = "btnSetNozzMTO";
            this.btnSetNozzMTO.Size = new System.Drawing.Size(103, 23);
            this.btnSetNozzMTO.TabIndex = 13;
            this.btnSetNozzMTO.Text = "管口法兰出料";
            this.btnSetNozzMTO.UseVisualStyleBackColor = true;
            this.btnSetNozzMTO.Click += new System.EventHandler(this.BtnSetNozzMTO_Click);
            // 
            // btnUnsetNozzMTO
            // 
            this.btnUnsetNozzMTO.Location = new System.Drawing.Point(11, 82);
            this.btnUnsetNozzMTO.Name = "btnUnsetNozzMTO";
            this.btnUnsetNozzMTO.Size = new System.Drawing.Size(103, 23);
            this.btnUnsetNozzMTO.TabIndex = 12;
            this.btnUnsetNozzMTO.Text = "管口法兰不出料";
            this.btnUnsetNozzMTO.UseVisualStyleBackColor = true;
            this.btnUnsetNozzMTO.Click += new System.EventHandler(this.BtnUnsetNozzMTO_Click);
            // 
            // btnSetTubeMTO
            // 
            this.btnSetTubeMTO.Location = new System.Drawing.Point(125, 51);
            this.btnSetTubeMTO.Name = "btnSetTubeMTO";
            this.btnSetTubeMTO.Size = new System.Drawing.Size(103, 23);
            this.btnSetTubeMTO.TabIndex = 11;
            this.btnSetTubeMTO.Text = "下游管子出料";
            this.btnSetTubeMTO.UseVisualStyleBackColor = true;
            this.btnSetTubeMTO.Click += new System.EventHandler(this.BtnSetTubeMTO_Click);
            // 
            // btnUnsetTubeMTO
            // 
            this.btnUnsetTubeMTO.Location = new System.Drawing.Point(11, 52);
            this.btnUnsetTubeMTO.Name = "btnUnsetTubeMTO";
            this.btnUnsetTubeMTO.Size = new System.Drawing.Size(103, 23);
            this.btnUnsetTubeMTO.TabIndex = 7;
            this.btnUnsetTubeMTO.Text = "下游管子不出料";
            this.btnUnsetTubeMTO.UseVisualStyleBackColor = true;
            this.btnUnsetTubeMTO.Click += new System.EventHandler(this.BtnUnsetTubeMTO_Click);
            // 
            // btnUnsetPipeMTO
            // 
            this.btnUnsetPipeMTO.Location = new System.Drawing.Point(11, 22);
            this.btnUnsetPipeMTO.Name = "btnUnsetPipeMTO";
            this.btnUnsetPipeMTO.Size = new System.Drawing.Size(103, 23);
            this.btnUnsetPipeMTO.TabIndex = 10;
            this.btnUnsetPipeMTO.Text = "管线不出料";
            this.btnUnsetPipeMTO.UseVisualStyleBackColor = true;
            this.btnUnsetPipeMTO.Click += new System.EventHandler(this.BtnUnsetPipeMTO_Click);
            // 
            // btnSetPipeMTO
            // 
            this.btnSetPipeMTO.Location = new System.Drawing.Point(125, 20);
            this.btnSetPipeMTO.Name = "btnSetPipeMTO";
            this.btnSetPipeMTO.Size = new System.Drawing.Size(103, 23);
            this.btnSetPipeMTO.TabIndex = 10;
            this.btnSetPipeMTO.Text = "管线出料";
            this.btnSetPipeMTO.UseVisualStyleBackColor = true;
            this.btnSetPipeMTO.Click += new System.EventHandler(this.BtnSetPipeMTO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstElements1);
            this.groupBox1.Controls.Add(this.btnAddCE);
            this.groupBox1.Controls.Add(this.txtCE);
            this.groupBox1.Controls.Add(this.aaaaa);
            this.groupBox1.Controls.Add(this.btnClearList);
            this.groupBox1.Controls.Add(this.btnManualsetMTO);
            this.groupBox1.Controls.Add(this.btnManualUnSetMTO);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "元件出料设置";
            // 
            // lstElements1
            // 
            this.lstElements1.FormattingEnabled = true;
            this.lstElements1.ItemHeight = 12;
            this.lstElements1.Location = new System.Drawing.Point(8, 46);
            this.lstElements1.Name = "lstElements1";
            this.lstElements1.Size = new System.Drawing.Size(220, 160);
            this.lstElements1.TabIndex = 9;
            this.lstElements1.DoubleClick += new System.EventHandler(this.LstElements1_DoubleClick);
            // 
            // btnAddCE
            // 
            this.btnAddCE.Location = new System.Drawing.Point(166, 18);
            this.btnAddCE.Name = "btnAddCE";
            this.btnAddCE.Size = new System.Drawing.Size(62, 23);
            this.btnAddCE.TabIndex = 8;
            this.btnAddCE.Text = "增加";
            this.btnAddCE.UseVisualStyleBackColor = true;
            this.btnAddCE.Click += new System.EventHandler(this.BtnAddCE_Click);
            // 
            // txtCE
            // 
            this.txtCE.Location = new System.Drawing.Point(30, 19);
            this.txtCE.Name = "txtCE";
            this.txtCE.ReadOnly = true;
            this.txtCE.Size = new System.Drawing.Size(130, 21);
            this.txtCE.TabIndex = 7;
            // 
            // aaaaa
            // 
            this.aaaaa.AutoSize = true;
            this.aaaaa.Location = new System.Drawing.Point(6, 23);
            this.aaaaa.Name = "aaaaa";
            this.aaaaa.Size = new System.Drawing.Size(17, 12);
            this.aaaaa.TabIndex = 6;
            this.aaaaa.Text = "CE";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(161, 214);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(67, 23);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "清空列表";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // btnManualsetMTO
            // 
            this.btnManualsetMTO.Location = new System.Drawing.Point(86, 214);
            this.btnManualsetMTO.Name = "btnManualsetMTO";
            this.btnManualsetMTO.Size = new System.Drawing.Size(67, 23);
            this.btnManualsetMTO.TabIndex = 4;
            this.btnManualsetMTO.Text = "出料";
            this.btnManualsetMTO.UseVisualStyleBackColor = true;
            this.btnManualsetMTO.Click += new System.EventHandler(this.BtnManualSetMTO_Click);
            // 
            // btnManualUnSetMTO
            // 
            this.btnManualUnSetMTO.Location = new System.Drawing.Point(11, 214);
            this.btnManualUnSetMTO.Name = "btnManualUnSetMTO";
            this.btnManualUnSetMTO.Size = new System.Drawing.Size(67, 23);
            this.btnManualUnSetMTO.TabIndex = 3;
            this.btnManualUnSetMTO.Text = "不出料";
            this.btnManualUnSetMTO.UseVisualStyleBackColor = true;
            this.btnManualUnSetMTO.Click += new System.EventHandler(this.BtnManualUnsetMTO_Click);
            // 
            // pageInclude
            // 
            this.pageInclude.Controls.Add(this.btnAddCE2);
            this.pageInclude.Controls.Add(this.lstElements2);
            this.pageInclude.Controls.Add(this.btnSetOwner2);
            this.pageInclude.Controls.Add(this.txtOwner2);
            this.pageInclude.Controls.Add(this.label2);
            this.pageInclude.Location = new System.Drawing.Point(4, 22);
            this.pageInclude.Name = "pageInclude";
            this.pageInclude.Padding = new System.Windows.Forms.Padding(3);
            this.pageInclude.Size = new System.Drawing.Size(258, 388);
            this.pageInclude.TabIndex = 1;
            this.pageInclude.Text = "元素包含";
            this.pageInclude.UseVisualStyleBackColor = true;
            // 
            // btnAddCE2
            // 
            this.btnAddCE2.Location = new System.Drawing.Point(8, 199);
            this.btnAddCE2.Name = "btnAddCE2";
            this.btnAddCE2.Size = new System.Drawing.Size(74, 23);
            this.btnAddCE2.TabIndex = 14;
            this.btnAddCE2.Text = "添加CE";
            this.btnAddCE2.UseVisualStyleBackColor = true;
            this.btnAddCE2.Click += new System.EventHandler(this.BtnAddCE2_Click);
            // 
            // lstElements2
            // 
            this.lstElements2.FormattingEnabled = true;
            this.lstElements2.ItemHeight = 12;
            this.lstElements2.Location = new System.Drawing.Point(8, 33);
            this.lstElements2.Name = "lstElements2";
            this.lstElements2.Size = new System.Drawing.Size(239, 160);
            this.lstElements2.TabIndex = 13;
            // 
            // btnSetOwner2
            // 
            this.btnSetOwner2.Location = new System.Drawing.Point(162, 5);
            this.btnSetOwner2.Name = "btnSetOwner2";
            this.btnSetOwner2.Size = new System.Drawing.Size(85, 23);
            this.btnSetOwner2.TabIndex = 12;
            this.btnSetOwner2.Text = "选择父元素";
            this.btnSetOwner2.UseVisualStyleBackColor = true;
            this.btnSetOwner2.Click += new System.EventHandler(this.BtnSetOwner2_Click);
            // 
            // txtOwner2
            // 
            this.txtOwner2.Location = new System.Drawing.Point(27, 6);
            this.txtOwner2.Name = "txtOwner2";
            this.txtOwner2.ReadOnly = true;
            this.txtOwner2.Size = new System.Drawing.Size(129, 21);
            this.txtOwner2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "CE";
            // 
            // pageSort
            // 
            this.pageSort.Controls.Add(this.btnMoveDown3);
            this.pageSort.Controls.Add(this.btnMoveUp3);
            this.pageSort.Controls.Add(this.lstElements3);
            this.pageSort.Controls.Add(this.btnSetOwner3);
            this.pageSort.Controls.Add(this.txtOwner3);
            this.pageSort.Controls.Add(this.label3);
            this.pageSort.Location = new System.Drawing.Point(4, 22);
            this.pageSort.Name = "pageSort";
            this.pageSort.Size = new System.Drawing.Size(258, 388);
            this.pageSort.TabIndex = 2;
            this.pageSort.Text = "元素排序";
            this.pageSort.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown3
            // 
            this.btnMoveDown3.Location = new System.Drawing.Point(93, 358);
            this.btnMoveDown3.Name = "btnMoveDown3";
            this.btnMoveDown3.Size = new System.Drawing.Size(74, 23);
            this.btnMoveDown3.TabIndex = 18;
            this.btnMoveDown3.Text = "元素下移";
            this.btnMoveDown3.UseVisualStyleBackColor = true;
            this.btnMoveDown3.Click += new System.EventHandler(this.BtnMoveDown3_Click);
            // 
            // btnMoveUp3
            // 
            this.btnMoveUp3.Location = new System.Drawing.Point(11, 358);
            this.btnMoveUp3.Name = "btnMoveUp3";
            this.btnMoveUp3.Size = new System.Drawing.Size(74, 23);
            this.btnMoveUp3.TabIndex = 18;
            this.btnMoveUp3.Text = "元素上移";
            this.btnMoveUp3.UseVisualStyleBackColor = true;
            this.btnMoveUp3.Click += new System.EventHandler(this.BtnMoveUp3_Click);
            // 
            // lstElements3
            // 
            this.lstElements3.FormattingEnabled = true;
            this.lstElements3.ItemHeight = 12;
            this.lstElements3.Location = new System.Drawing.Point(11, 36);
            this.lstElements3.Name = "lstElements3";
            this.lstElements3.Size = new System.Drawing.Size(239, 316);
            this.lstElements3.TabIndex = 17;
            // 
            // btnSetOwner3
            // 
            this.btnSetOwner3.Location = new System.Drawing.Point(165, 8);
            this.btnSetOwner3.Name = "btnSetOwner3";
            this.btnSetOwner3.Size = new System.Drawing.Size(85, 23);
            this.btnSetOwner3.TabIndex = 16;
            this.btnSetOwner3.Text = "选择父元素";
            this.btnSetOwner3.UseVisualStyleBackColor = true;
            this.btnSetOwner3.Click += new System.EventHandler(this.BtnSetOwner3_Click);
            // 
            // txtOwner3
            // 
            this.txtOwner3.Location = new System.Drawing.Point(30, 9);
            this.txtOwner3.Name = "txtOwner3";
            this.txtOwner3.ReadOnly = true;
            this.txtOwner3.Size = new System.Drawing.Size(129, 21);
            this.txtOwner3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "CE";
            // 
            // PdmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "PdmsControl";
            this.Size = new System.Drawing.Size(257, 447);
            this.tabControl1.ResumeLayout(false);
            this.pageMTO.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pageInclude.ResumeLayout(false);
            this.pageInclude.PerformLayout();
            this.pageSort.ResumeLayout(false);
            this.pageSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageMTO;
        private System.Windows.Forms.TabPage pageInclude;
        private System.Windows.Forms.Button btnManualUnSetMTO;
        private System.Windows.Forms.Button btnManualsetMTO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnAddCE;
        private System.Windows.Forms.TextBox txtCE;
        private System.Windows.Forms.Label aaaaa;
        private System.Windows.Forms.ListBox lstElements1;
        private System.Windows.Forms.Button btnSetPipeMTO;
        private System.Windows.Forms.Button btnUnsetPipeMTO;
        private System.Windows.Forms.Button btnUnsetTubeMTO;
        private System.Windows.Forms.Button btnSetTubeMTO;
        private System.Windows.Forms.Button btnUnsetNozzMTO;
        private System.Windows.Forms.Button btnSetNozzMTO;
        private System.Windows.Forms.ListBox lstElements2;
        private System.Windows.Forms.Button btnSetOwner2;
        private System.Windows.Forms.TextBox txtOwner2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCE2;
        private System.Windows.Forms.TabPage pageSort;
        private System.Windows.Forms.ListBox lstElements3;
        private System.Windows.Forms.Button btnSetOwner3;
        private System.Windows.Forms.TextBox txtOwner3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMoveUp3;
        private System.Windows.Forms.Button btnMoveDown3;
    }
}
