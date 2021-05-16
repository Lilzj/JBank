using JBank.Lib.Core.Repository;
using JBank.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using JBank.Lib.Core.Interface;
using JBank.Lib.Core;
using JBank.Lib.Model;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace JBankUI
{
    public partial class DepositUserControl : UserControl
    {
        private readonly IAccountRepository acctrepo;
        private static string accType = "";
        private static string id = "";
        private static string foundcustomer = "";
        private static DepositUserControl _instance;
        public static DepositUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DepositUserControl(GlobalConfig.IAccountinstance);
                return _instance;
            }
        }
        public DepositUserControl(IAccountRepository Acctrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DepositUserControl_Load(object sender, EventArgs e)
        {
           
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void depositAmnt_TextChanged(object sender, EventArgs e)
        {
          
            verifyBtn.Show();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            enterPass.Show();
        }

        private void enterPass_TextChanged(object sender, EventArgs e)
        {
            confirmBtn.Show();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            decimal depositAmount = Convert.ToDecimal(depositAmnt.Text);

            if (depositAmount < 0 || depositAmount == 0)
            {
                MessageBox.Show("Amount cannot be less than or equall to zero");
            }
            else
            {
                try
                {
                    string id = "";
                    string note = "Deposit";
                    var accno = "";
                    
                        id = UserSession.CurrentUserID[0];
                    
                    foreach (var item in UserSession.UserAccount)
                    {
                        accno = item;

                    }
                    
                    acctrepo.Deposit(id, accno, depositAmount, note, accType); 
                    MessageBox.Show("Deposit was Successfully done");

                }  
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
 
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            depositAccPanel.Visible = false;
            verifyBtn.Visible = false;
            enterPass.Visible = false;
            confirmBtn.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (radioButton1.Checked)
                {
                    accType = "Savings";
                   

                   
                        id = UserSession.CurrentUserID[0];
                    
                    using (var JBContext = new JBankContext())
                    {
                        var check = JBContext.Accounts.Include(x => x.Customer).Where(x => x.CustomerId == id && x.Type == accType);

                           
                            if (check != null)
                            {
                            foreach (var item in check)
                            {
                                foundcustomer = item.AccountNumber;
                                UserSession.UserAccount.Add(item.AccountNumber);
                                UserSession.CurrentUserID.Add(item.CustomerId);

                                if (foundcustomer != null)
                                {
                                    accNum.Text = foundcustomer;
                                    accBal.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                                    depositAccPanel.Visible = true;
                                    depositAmnt.Visible = true;
                                }
                                else
                                {
                                    depositAmnt.Visible = false;
                                    depositAccPanel.Visible = false;
                                }
                            }
                               
                            }

                        
                    }

                }
                else if (!radioButton1.Checked)
                {
                    depositAmnt.Visible = false;
                    depositAccPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                 accType = "Current";
               

               
                    id = UserSession.CurrentUserID[0];
                
                using (var JBContext = new JBankContext())
                {
                    var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.CustomerId == id && x.Type == accType);


                    if (check != null)
                    {
                        foundcustomer = check.AccountNumber;
                        UserSession.UserAccount.Add(check.AccountNumber);
                        UserSession.CurrentUserID.Add(check.CustomerId);

                        if (foundcustomer != null)
                        {
                            accNum.Text = foundcustomer;
                            accBal.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                            depositAccPanel.Visible = true;
                            depositAmnt.Visible = true;
                        }
                        else
                        {
                            depositAmnt.Visible = false;
                            depositAccPanel.Visible = false;
                        }
                    }


                }
            }
            else if (!radioButton2.Checked)
            {
                depositAmnt.Visible = false;
                depositAccPanel.Visible = false;
            }
}
    }
}
