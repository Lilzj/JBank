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
    public partial class TransferUserControl : UserControl
    {
        private readonly IAccountRepository acctrepo;
        private static string accTypeFrm = "";
        private static string accTypeTo = "";
        private static string reAcc = "";
        private static string recipient = "";
        private static string recpAccId = "";

        private static TransferUserControl _instance;
        public static TransferUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TransferUserControl(GlobalConfig.IAccountinstance);
                return _instance;
            }
        }

        public TransferUserControl(IAccountRepository Acctrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TransferUserControl_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                accTypeFrm = "Savings";
                string id = "";
                string foundcustomer;

                foreach (var item in UserSession.CurrentUserID)
                {
                    id = item.Split(",")[0];
                }
                using (var JBContext = new JBankContext())
                {
                    
                        var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.CustomerId == id && x.Type == accTypeFrm);
                       
                        if (check != null)
                        {
                        foundcustomer = check.AccountNumber;
                            UserSession.UserAccount.Add(check.AccountNumber);
                            UserSession.CurrentUserID.Add(check.CustomerId);

                            if (foundcustomer != null)
                            {
                                accNumFrom.Text = foundcustomer;
                                accBalFrm.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                                accDetailsFrm.Visible = true;
                                toPanel.Visible = true;
                            }
                            else
                            {
                                accDetailsFrm.Visible = false;
                                toPanel.Visible = false;
                            }
                        }

                    
                }
            }
            else if (!radioButton1.Checked)
            {
                accDetailsFrm.Visible = false;
                toPanel.Visible = false;
                radioButton1.Checked = false;
            }
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                accTypeFrm = "Current";
                //checkCF = accTypeFrm;
                string id = "";
                string foundcustomer;

                foreach (var item in UserSession.CurrentUserID)
                {
                    id = item.Split(",")[0];
                }
                using (var JBContext = new JBankContext())
                {

                    var check = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.CustomerId == id && x.Type == accTypeFrm);

                    if (check != null)
                    {
                        foundcustomer = check.AccountNumber;
                        UserSession.UserAccount.Add(check.AccountNumber);
                        UserSession.CurrentUserID.Add(check.CustomerId);

                        if (foundcustomer != null)
                        {
                            accNumFrom.Text = foundcustomer;
                            accBalFrm.Text = acctrepo.GetDbBalance(foundcustomer).ToString();
                            accDetailsFrm.Visible = true;
                            toPanel.Visible = true;
                        }
                        else
                        {
                            accDetailsFrm.Visible = false;
                            toPanel.Visible = false;
                        }
                    }


                }
            }
            else if (!radioButton2.Checked)
            {
                accDetailsFrm.Visible = false;
                toPanel.Visible = false;
                radioButton2.Checked = false;
            }
        }


        private void transAmnt_TextChanged(object sender, EventArgs e)
        {
           
            verifyBtn.Show();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            passCfrm.Show();
        }

        private void passCfrm_TextChanged(object sender, EventArgs e)
        {
            confirm.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {


            decimal tranAmnt = Convert.ToDecimal(transAmnt.Text);

            if (tranAmnt < 0 || tranAmnt ==0)
            {
                MessageBox.Show("Amount cannot be less than or equall to zero");
            }
            else
            {
                try
                {
                    string id = "";
                    string note = "Transfer";
                    var accno = "";
                    
                    foreach (var item in UserSession.CurrentUserID)
                    {
                        id = item.Split(",")[0];
                    }
                    foreach (var item in UserSession.UserAccount)
                    {
                        accno = item.Split(",")[0];
                    }
                    acctrepo.Transfer(id, recipient,recpAccId,accno,reAcc,tranAmnt,note,accTypeFrm,accTypeTo);
                    MessageBox.Show("Transfer Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            toPanel.Visible = false;
            verifyBtn.Visible = false;
            passCfrm.Visible = false;
            confirm.Visible = false;
        }
        private void recieverNum_TextChanged(object sender, EventArgs e)
        {
            if (recieverNum.Text.ToString().Length == 8)
            {
                try
                {
                    reAcc = recieverNum.Text;


                    // var accnumTo = AccountData.Accounts.Find(a => a.AccountNumber == reAcc);
                    if (reAcc != null)
                    {
                        using (var JBContext = new JBankContext())
                        {
                            var respAcc = JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.AccountNumber == reAcc);

                            
                            if (respAcc != null)
                            {
                                recpAccId = respAcc.AccountId;
                                recipient = respAcc.CustomerId;
                                accTypeTo = respAcc.Type;
                                accNameTo.Text = respAcc.Customer.FullName;

                            }


                        }
                        accDetailsTo.Show();
                        transAmnt.Show();
                      
                    }
                    else
                    {
                        MessageBox.Show("Account not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Account not found");
            }
           


        }

        private void recieverNum_Validated(object sender, EventArgs e)
        {
           
        }
    }
}

