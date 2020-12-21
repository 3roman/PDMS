namespace PdmsAddin
{
    partial class FrmAutoSortElement
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbxPrimaryField = new System.Windows.Forms.ComboBox();
            this.cbxSecondaryField = new System.Windows.Forms.ComboBox();
            this.cbxSeparator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(14, 85);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(55, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // cbxPrimaryField
            // 
            this.cbxPrimaryField.FormattingEnabled = true;
            this.cbxPrimaryField.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxPrimaryField.Location = new System.Drawing.Point(73, 32);
            this.cbxPrimaryField.Name = "cbxPrimaryField";
            this.cbxPrimaryField.Size = new System.Drawing.Size(66, 20);
            this.cbxPrimaryField.TabIndex = 15;
            this.cbxPrimaryField.Text = "2";
            // 
            // cbxSecondaryField
            // 
            this.cbxSecondaryField.FormattingEnabled = true;
            this.cbxSecondaryField.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxSecondaryField.Location = new System.Drawing.Point(73, 59);
            this.cbxSecondaryField.Name = "cbxSecondaryField";
            this.cbxSecondaryField.Size = new System.Drawing.Size(66, 20);
            this.cbxSecondaryField.TabIndex = 14;
            this.cbxSecondaryField.Text = "3";
            // 
            // cbxSeparator
            // 
            this.cbxSeparator.FormattingEnabled = true;
            this.cbxSeparator.Items.AddRange(new object[] {
            "-",
            "/"});
            this.cbxSeparator.Location = new System.Drawing.Point(73, 5);
            this.cbxSeparator.Name = "cbxSeparator";
            this.cbxSeparator.Size = new System.Drawing.Size(66, 20);
            this.cbxSeparator.TabIndex = 13;
            this.cbxSeparator.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "次要字段";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "首要字段";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "分隔符";
            // 
            // frmAutoSortElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 115);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbxPrimaryField);
            this.Controls.Add(this.cbxSecondaryField);
            this.Controls.Add(this.cbxSeparator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAutoSortElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "排序规则";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbxPrimaryField;
        private System.Windows.Forms.ComboBox cbxSecondaryField;
        private System.Windows.Forms.ComboBox cbxSeparator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}