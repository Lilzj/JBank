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
using System.Threading;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class withdrawUserControl : UserControl
    {
        private readonly IAccountRepository acctrepo;
        private static string accType = "";
        private static withdrawUserControl _instance;
        public static withdrawUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new withdrawUserControl(GlobalConfig.IAccountinstance);
                return _instance;
            }
        }

        public withdrawUserControl(IAccountRepository Acctrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
        }

        private void withdrawUserControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                accType = "Savings";
                string id = "";
                string foundcustomer;

                foreach (var item in UserSession.CurrentUserID)
                {
                    id = item.Split(",")[0];
                }
                using (var JBContext = new JBankContext())
                {
                    var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.Type == accType && x.CustomerId == id);
                   
                        if (check != null)
                        {
                            foundcustomer = check.AccountNumber; ;
                            UserSession.UserAccount.Add(check.AccountNumber);
                            UserSession.CurrentUserID.Add(check.CustomerId);

                            if (foundcustomer != null)
                            {
                                accNum.Text = foundcustomer;
                                accBal.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                                withdPanel.Visible = true;
                                withdAmnt.Visible = true;
                            }
                            else
                            {
                                withdAmnt.Visible = false;
                                withdPanel.Visible = false;
                            }
                        }

                    
                }
              
            }
            else if (!radioButton1.Checked)
            {
                withdAmnt.Visible = false;
                withdPanel.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                accType = "Current";
                string id = "";
                string foundcustomer;

                foreach (var item in UserSession.CurrentUserID)
                {
                    id = item.Split(",")[0];
                }
                using (var JBContext = new JBankContext())
                {
                    var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.Type == accType && x.CustomerId == id);

                    if (check != null)
                    {
                        foundcustomer = check.AccountNumber; ;
                        UserSession.UserAccount.Add(check.AccountNumber);
                        UserSession.CurrentUserID.Add(check.CustomerId);

                        if (foundcustomer != null)
                        {
                            accNum.Text = foundcustomer;
                            accBal.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                            withdPanel.Visible = true;
                            withdAmnt.Visible = true;
                        }
                        else
                        {
                            withdAmnt.Visible = false;
                            withdPanel.Visible = false;
                        }
                    }


                }
            }
            else if (!radioButton2.Checked)
            {
                withdAmnt.Visible = false;
                withdPanel.Visible = false;
            }
        }

        private void withdAmnt_TextChanged(object sender, EventArgs e)
        {
            verifyBtn.Show();
        }

        private void enterPass_TextChanged(object sender, EventArgs e)
        {
            confirmWithd.Show();
        }

        private void confirmWithd_Click(object sender, EventArgs e)
        {

            decimal withdAmount = Convert.ToDecimal(withdAmnt.Text);

            if (withdAmount < 0 || withdAmount == 0)
            {
                MessageBox.Show("Amount cannot be less than or equall to zero");
            }
            else
            {
                try
                {
                    string id = "";
                    string note = "Withdrawal";
                    var accno = "";
                    foreach (var item in UserSession.CurrentUserID)
                    {
                        id = item.Split(",")[0];
                    }
                    foreach (var item in UserSession.UserAccount)
                    {
                        accno = item.Split(",")[0];
                    }
                    using (var JBContext = new JBankContext())
                    {
                        var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.Type == accType && x.CustomerId == id);
                        var withd = new Transact() { AccountId = check.AccountId, CustomerId = id, AccountNumber = accno, Amount = -withdAmount, Note = note, AccountType = accType };
                        JBContext.Transacts.Add(withd);
                        JBContext.SaveChanges();
                            MessageBox.Show("Withdrawal was Successfully Made");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            withdPanel.Visible = false;
            verifyBtn.Visible = false;
            enterPass.Visible = false;
            confirmWithd.Visible = false;
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            enterPass.Show();
        }
    }
}
