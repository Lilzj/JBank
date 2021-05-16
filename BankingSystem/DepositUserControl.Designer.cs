
namespace JBankUI
{
    partial class DepositUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.depositAccPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.accBal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depositAmnt = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.enterPass = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.depositAccPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(101, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Account to Deposit to";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(161, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 57);
            this.panel1.TabIndex = 27;
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
            // depositAccPanel
            // 
            this.depositAccPanel.Controls.Add(this.panel4);
            this.depositAccPanel.Controls.Add(this.panel3);
            this.depositAccPanel.Location = new System.Drawing.Point(101, 134);
            this.depositAccPanel.Name = "depositAccPanel";
            this.depositAccPanel.Size = new System.Drawing.Size(410, 111);
            this.depositAccPanel.TabIndex = 28;
            this.depositAccPanel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.accBal);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 46);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // accBal
            // 
            this.accBal.AutoSize = true;
            this.accBal.BackColor = System.Drawing.SystemColors.Control;
            this.accBal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accBal.Location = new System.Drawing.Point(214, 14);
            this.accBal.Name = "accBal";
            this.accBal.Size = new System.Drawing.Size(54, 23);
            this.accBal.TabIndex = 3;
            this.accBal.Text = "5000";
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
            this.accNum.Size = new System.Drawing.Size(120, 23);
            this.accNum.TabIndex = 3;
            this.accNum.Text = "3065237856";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(101, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 34);
            this.label6.TabIndex = 29;
            // 
            // depositAmnt
            // 
            this.depositAmnt.BackColor = System.Drawing.SystemColors.Control;
            this.depositAmnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositAmnt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositAmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.depositAmnt.Location = new System.Drawing.Point(142, 269);
            this.depositAmnt.Name = "depositAmnt";
            this.depositAmnt.PlaceholderText = "Enter Amount to Depost Here...";
            this.depositAmnt.Size = new System.Drawing.Size(319, 30);
            this.depositAmnt.TabIndex = 30;
            this.depositAmnt.Visible = false;
            this.depositAmnt.TextChanged += new System.EventHandler(this.depositAmnt_TextChanged);
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.FlatAppearance.BorderSize = 0;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.verifyBtn.Location = new System.Drawing.Point(240, 321);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(112, 45);
            this.verifyBtn.TabIndex = 31;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Visible = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // enterPass
            // 
            this.enterPass.BackColor = System.Drawing.SystemColors.Control;
            this.enterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.enterPass.Location = new System.Drawing.Point(142, 391);
            this.enterPass.Name = "enterPass";
            this.enterPass.PlaceholderText = "Enter Password to continue...";
            this.enterPass.Size = new System.Drawing.Size(319, 30);
            this.enterPass.TabIndex = 32;
            this.enterPass.Visible = false;
            this.enterPass.TextChanged += new System.EventHandler(this.enterPass_TextChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmBtn.Location = new System.Drawing.Point(179, 464);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(256, 45);
            this.confirmBtn.TabIndex = 33;
            this.confirmBtn.Text = "Confirm Transaction";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // DepositUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.enterPass);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.depositAmnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.depositAccPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "DepositUserControl";
            this.Size = new System.Drawing.Size(654, 558);
            this.Load += new System.EventHandler(this.DepositUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.depositAccPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel depositAccPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label accBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox depositAmnt;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox enterPass;
        private System.Windows.Forms.Button confirmBtn;
    }
}
