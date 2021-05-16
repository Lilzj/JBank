
namespace JBankUI
{
    partial class DashboardUsersControl
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
            this.UCSavingPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.savAmnt = new System.Windows.Forms.Label();
            this.savingLabel = new System.Windows.Forms.Label();
            this.UCcurrentPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.currAmnt = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UCSavingPanel.SuspendLayout();
            this.UCcurrentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UCSavingPanel
            // 
            this.UCSavingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.UCSavingPanel.Controls.Add(this.label2);
            this.UCSavingPanel.Controls.Add(this.savAmnt);
            this.UCSavingPanel.Controls.Add(this.savingLabel);
            this.UCSavingPanel.Location = new System.Drawing.Point(29, 9);
            this.UCSavingPanel.Name = "UCSavingPanel";
            this.UCSavingPanel.Size = new System.Drawing.Size(226, 128);
            this.UCSavingPanel.TabIndex = 0;
            this.UCSavingPanel.Visible = false;
            this.UCSavingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UCSavingPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(181, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "bal";
            // 
            // savAmnt
            // 
            this.savAmnt.AutoSize = true;
            this.savAmnt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savAmnt.ForeColor = System.Drawing.SystemColors.Control;
            this.savAmnt.Location = new System.Drawing.Point(96, 79);
            this.savAmnt.Name = "savAmnt";
            this.savAmnt.Size = new System.Drawing.Size(0, 34);
            this.savAmnt.TabIndex = 1;
            this.savAmnt.Click += new System.EventHandler(this.label2_Click);
            // 
            // savingLabel
            // 
            this.savingLabel.AutoSize = true;
            this.savingLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.savingLabel.Location = new System.Drawing.Point(36, 18);
            this.savingLabel.Name = "savingLabel";
            this.savingLabel.Size = new System.Drawing.Size(139, 34);
            this.savingLabel.TabIndex = 0;
            this.savingLabel.Text = "SAVINGS";
            // 
            // UCcurrentPanel
            // 
            this.UCcurrentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.UCcurrentPanel.Controls.Add(this.label3);
            this.UCcurrentPanel.Controls.Add(this.currAmnt);
            this.UCcurrentPanel.Controls.Add(this.currentLabel);
            this.UCcurrentPanel.Location = new System.Drawing.Point(395, 9);
            this.UCcurrentPanel.Name = "UCcurrentPanel";
            this.UCcurrentPanel.Size = new System.Drawing.Size(226, 128);
            this.UCcurrentPanel.TabIndex = 1;
            this.UCcurrentPanel.Visible = false;
            this.UCcurrentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UCcurrentPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(181, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "bal";
            // 
            // currAmnt
            // 
            this.currAmnt.AutoSize = true;
            this.currAmnt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currAmnt.ForeColor = System.Drawing.SystemColors.Control;
            this.currAmnt.Location = new System.Drawing.Point(96, 79);
            this.currAmnt.Name = "currAmnt";
            this.currAmnt.Size = new System.Drawing.Size(0, 34);
            this.currAmnt.TabIndex = 1;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentLabel.Location = new System.Drawing.Point(36, 18);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(135, 34);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "CURRENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(32, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIST OF RECENT TRANSACTIONS DONE\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(29, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 253);
            this.panel1.TabIndex = 3;
            // 
            // DashboardUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UCcurrentPanel);
            this.Controls.Add(this.UCSavingPanel);
            this.Name = "DashboardUsersControl";
            this.Size = new System.Drawing.Size(654, 558);
            this.Load += new System.EventHandler(this.DashboardUsersControl_Load);
            this.UCSavingPanel.ResumeLayout(false);
            this.UCSavingPanel.PerformLayout();
            this.UCcurrentPanel.ResumeLayout(false);
            this.UCcurrentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UCSavingPanel;
        private System.Windows.Forms.Label savingLabel;
        private System.Windows.Forms.Label savAmnt;
        private System.Windows.Forms.Panel UCcurrentPanel;
        private System.Windows.Forms.Label currAmnt;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
