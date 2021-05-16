using JBank.Lib.Core;
using JBank.Lib.Core.Interface;
using JBank.Lib.Core.Repository;
using JBank.Lib.Data;
using JBank.Lib.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class DashboardUsersControl : UserControl
    {
        private readonly IAccountRepository acctrepo;
        private static DashboardUsersControl _instance;
        public static DashboardUsersControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashboardUsersControl(GlobalConfig.IAccountinstance);
                return _instance;
            }
        }
        public DashboardUsersControl(IAccountRepository Acctrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashboardUsersControl_Load(object sender, EventArgs e)
        {

            string id = "";
            string foundcustomer = "";
           
                id = UserSession.CurrentUserID[0];
            

            using (var JBContext = new JBankContext())
            {

                var check = JBContext.Customers.Include(x => x.Accounts).FirstOrDefault(x => x.CustomerId == id);

               
                    if (check != null)
                    {
                        foreach (var acc in check.Accounts)
                        {
                            foundcustomer = acc.Type;
                            var accno = acc.AccountNumber;

                            if (foundcustomer == "Savings")
                            {
                                savAmnt.Text = acctrepo.GetDbBalance(accno).ToString();
                                UCSavingPanel.Visible = true;

                            }
                            else if (foundcustomer == "Current")
                            {
                                currAmnt.Text = acctrepo.GetDbBalance(accno).ToString();
                                UCcurrentPanel.Visible = true;
                            }
                        }
                        
                    }

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCcurrentPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UCSavingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
