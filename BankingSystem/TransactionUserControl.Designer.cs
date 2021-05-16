
namespace JBankUI
{
    partial class TransactionUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transaction_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIST OF RECENT TRANSACTIONS DONE\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 84);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOTE: Only the recent five transactions done\r\n           will be display\r\n\r\n";
            // 
            // transaction_panel
            // 
            this.transaction_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transaction_panel.Location = new System.Drawing.Point(24, 184);
            this.transaction_panel.Name = "transaction_panel";
            this.transaction_panel.Size = new System.Drawing.Size(589, 348);
            this.transaction_panel.TabIndex = 7;
            this.transaction_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.transaction_panel_Paint);
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transaction_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(654, 558);
            this.Load += new System.EventHandler(this.TransactionUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel transaction_panel;
    }
}
