
namespace JBankUI
{
    partial class withdrawUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmWithd = new System.Windows.Forms.Button();
            this.enterPass = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.withdAmnt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.withdPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.accBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.withdPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmWithd
            // 
            this.confirmWithd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmWithd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmWithd.FlatAppearance.BorderSize = 0;
            this.confirmWithd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmWithd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmWithd.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmWithd.Location = new System.Drawing.Point(200, 480);
            this.confirmWithd.Name = "confirmWithd";
            this.confirmWithd.Size = new System.Drawing.Size(256, 45);
            this.confirmWithd.TabIndex = 41;
            this.confirmWithd.Text = "Confirm Transaction";
            this.confirmWithd.UseVisualStyleBackColor = false;
            this.confirmWithd.Visible = false;
            this.confirmWithd.Click += new System.EventHandler(this.confirmWithd_Click);
            // 
            // enterPass
            // 
            this.enterPass.BackColor = System.Drawing.SystemColors.Control;
            this.enterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.enterPass.Location = new System.Drawing.Point(163, 407);
            this.enterPass.Name = "enterPass";
            this.enterPass.PlaceholderText = "Enter Password to continue...";
            this.enterPass.Size = new System.Drawing.Size(319, 30);
            this.enterPass.TabIndex = 40;
            this.enterPass.Visible = false;
            this.enterPass.TextChanged += new System.EventHandler(this.enterPass_TextChanged);
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.FlatAppearance.BorderSize = 0;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.verifyBtn.Location = new System.Drawing.Point(261, 337);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(112, 45);
            this.verifyBtn.TabIndex = 39;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Visible = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // withdAmnt
            // 
            this.withdAmnt.BackColor = System.Drawing.SystemColors.Control;
            this.withdAmnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withdAmnt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdAmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.withdAmnt.Location = new System.Drawing.Point(163, 285);
            this.withdAmnt.Name = "withdAmnt";
            this.withdAmnt.PlaceholderText = "Enter Amount to Withdraw Here...";
            this.withdAmnt.Size = new System.Drawing.Size(319, 30);
            this.withdAmnt.TabIndex = 38;
            this.withdAmnt.Visible = false;
            this.withdAmnt.TextChanged += new System.EventHandler(this.withdAmnt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(122, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 34);
            this.label6.TabIndex = 37;
            // 
            // withdPanel
            // 
            this.withdPanel.Controls.Add(this.panel4);
            this.withdPanel.Controls.Add(this.panel3);
            this.withdPanel.Location = new System.Drawing.Point(122, 150);
            this.withdPanel.Name = "withdPanel";
            this.withdPanel.Size = new System.Drawing.Size(410, 111);
            this.withdPanel.TabIndex = 36;
            this.withdPanel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.accBal);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 46);
            this.panel4.TabIndex = 30;
            // 
            // accBal
            // 
            this.accBal.AutoSize = true;
            this.accBal.BackColor = System.Drawing.SystemColors.Control;
            this.accBal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accBal.Location = new System.Drawing.Point(214, 14);
            this.accBal.Name = "accBal";
            this.accBal.Size = new System.Drawing.Size(0, 23);
            this.accBal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Balance:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accNum);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 46);
            this.panel3.TabIndex = 29;
            // 
            // accNum
            // 
            this.accNum.AutoSize = true;
            this.accNum.BackColor = System.Drawing.SystemColors.Control;
            this.accNum.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accNum.Location = new System.Drawing.Point(214, 14);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(0, 23);
            this.accNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Number:\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(182, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 57);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.radioButton2.Location = new System.Drawing.Point(149, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Current";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.radioButton1.Location = new System.Drawing.Point(3, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Savings";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(122, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 34);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select Account to Withdraw from\r\n";
            // 
            // withdrawUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmWithd);
            this.Controls.Add(this.enterPass);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.withdAmnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.withdPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "withdrawUserControl";
            this.Size = new System.Drawing.Size(654, 558);
            this.Load += new System.EventHandler(this.withdrawUserControl_Load);
            this.withdPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmWithd;
        private System.Windows.Forms.TextBox enterPass;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox withdAmnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel withdPanel;
        private System.Windows.Forms.Label accBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}
