
namespace JBankUI
{
    partial class TransferUserControl
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
            this.confirm = new System.Windows.Forms.Button();
            this.passCfrm = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.transAmnt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accDetailsFrm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accNumFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.accBalFrm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toPanel = new System.Windows.Forms.Panel();
            this.recieverNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accDetailsTo = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.accNameTo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accDetailsFrm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toPanel.SuspendLayout();
            this.accDetailsTo.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.confirm.Location = new System.Drawing.Point(191, 497);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(256, 45);
            this.confirm.TabIndex = 41;
            this.confirm.Text = "Confirm Transaction";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // passCfrm
            // 
            this.passCfrm.BackColor = System.Drawing.SystemColors.Control;
            this.passCfrm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passCfrm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passCfrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passCfrm.Location = new System.Drawing.Point(166, 461);
            this.passCfrm.Name = "passCfrm";
            this.passCfrm.PlaceholderText = "Enter Password to continue...";
            this.passCfrm.Size = new System.Drawing.Size(319, 30);
            this.passCfrm.TabIndex = 40;
            this.passCfrm.Visible = false;
            this.passCfrm.TextChanged += new System.EventHandler(this.passCfrm_TextChanged);
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.FlatAppearance.BorderSize = 0;
            this.verifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verifyBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.verifyBtn.Location = new System.Drawing.Point(248, 410);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(112, 45);
            this.verifyBtn.TabIndex = 39;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = false;
            this.verifyBtn.Visible = false;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // transAmnt
            // 
            this.transAmnt.BackColor = System.Drawing.SystemColors.Control;
            this.transAmnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transAmnt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transAmnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.transAmnt.Location = new System.Drawing.Point(166, 361);
            this.transAmnt.Name = "transAmnt";
            this.transAmnt.PlaceholderText = "Enter Amount to Transfer Here...";
            this.transAmnt.Size = new System.Drawing.Size(319, 30);
            this.transAmnt.TabIndex = 38;
            this.transAmnt.Visible = false;
            this.transAmnt.TextChanged += new System.EventHandler(this.transAmnt_TextChanged);
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
            // accDetailsFrm
            // 
            this.accDetailsFrm.Controls.Add(this.panel3);
            this.accDetailsFrm.Controls.Add(this.panel4);
            this.accDetailsFrm.Location = new System.Drawing.Point(13, 116);
            this.accDetailsFrm.Name = "accDetailsFrm";
            this.accDetailsFrm.Size = new System.Drawing.Size(641, 55);
            this.accDetailsFrm.TabIndex = 36;
            this.accDetailsFrm.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accNumFrom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 46);
            this.panel3.TabIndex = 29;
            // 
            // accNumFrom
            // 
            this.accNumFrom.AutoSize = true;
            this.accNumFrom.BackColor = System.Drawing.SystemColors.Control;
            this.accNumFrom.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accNumFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accNumFrom.Location = new System.Drawing.Point(210, 14);
            this.accNumFrom.Name = "accNumFrom";
            this.accNumFrom.Size = new System.Drawing.Size(0, 23);
            this.accNumFrom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Number:\r\n";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.accBalFrm);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(367, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 46);
            this.panel4.TabIndex = 30;
            // 
            // accBalFrm
            // 
            this.accBalFrm.AutoSize = true;
            this.accBalFrm.BackColor = System.Drawing.SystemColors.Control;
            this.accBalFrm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accBalFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accBalFrm.Location = new System.Drawing.Point(133, 14);
            this.accBalFrm.Name = "accBalFrm";
            this.accBalFrm.Size = new System.Drawing.Size(0, 23);
            this.accBalFrm.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(182, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 57);
            this.panel1.TabIndex = 35;
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
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 34);
            this.label2.TabIndex = 34;
            this.label2.Text = "Select Account to Transfer from\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toPanel
            // 
            this.toPanel.Controls.Add(this.recieverNum);
            this.toPanel.Controls.Add(this.label7);
            this.toPanel.Location = new System.Drawing.Point(13, 177);
            this.toPanel.Name = "toPanel";
            this.toPanel.Size = new System.Drawing.Size(622, 108);
            this.toPanel.TabIndex = 42;
            this.toPanel.Visible = false;
            // 
            // recieverNum
            // 
            this.recieverNum.BackColor = System.Drawing.SystemColors.Control;
            this.recieverNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recieverNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.recieverNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recieverNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.recieverNum.Location = new System.Drawing.Point(127, 60);
            this.recieverNum.Name = "recieverNum";
            this.recieverNum.PlaceholderText = "Account Number here...";
            this.recieverNum.Size = new System.Drawing.Size(352, 23);
            this.recieverNum.TabIndex = 36;
            this.recieverNum.TextChanged += new System.EventHandler(this.recieverNum_TextChanged);
            this.recieverNum.Validated += new System.EventHandler(this.recieverNum_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(61, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 68);
            this.label7.TabIndex = 35;
            this.label7.Text = "Enter Account you are transfering to\r\n\r\n";
            // 
            // accDetailsTo
            // 
            this.accDetailsTo.Controls.Add(this.panel8);
            this.accDetailsTo.Location = new System.Drawing.Point(0, 291);
            this.accDetailsTo.Name = "accDetailsTo";
            this.accDetailsTo.Size = new System.Drawing.Size(641, 55);
            this.accDetailsTo.TabIndex = 43;
            this.accDetailsTo.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.accNameTo);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(622, 46);
            this.panel8.TabIndex = 29;
            // 
            // accNameTo
            // 
            this.accNameTo.AutoSize = true;
            this.accNameTo.BackColor = System.Drawing.SystemColors.Control;
            this.accNameTo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accNameTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.accNameTo.Location = new System.Drawing.Point(291, 14);
            this.accNameTo.Name = "accNameTo";
            this.accNameTo.Size = new System.Drawing.Size(0, 23);
            this.accNameTo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(70, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Account Name:\r\n";
            // 
            // TransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accDetailsTo);
            this.Controls.Add(this.toPanel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.passCfrm);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.transAmnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accDetailsFrm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "TransferUserControl";
            this.Size = new System.Drawing.Size(654, 558);
            this.Load += new System.EventHandler(this.TransferUserControl_Load);
            this.accDetailsFrm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toPanel.ResumeLayout(false);
            this.toPanel.PerformLayout();
            this.accDetailsTo.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox passCfrm;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox transAmnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel accDetailsFrm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label accNumFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label accBalFrm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel toPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel accDetailsTo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label accNameTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox recieverNum;
    }
}
