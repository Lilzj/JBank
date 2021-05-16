using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class TransactionUserControl : UserControl
    {

        private static TransactionUserControl _instance;
        public static TransactionUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TransactionUserControl();
                return _instance;
            }
        }

        public TransactionUserControl()
        {
            InitializeComponent();
        }

        private void TransactionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void transaction_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
