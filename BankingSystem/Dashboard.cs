using JBank.Lib.Common;
using JBank.Lib.Core.Interface;
using JBank.Lib.Core.Repository;
using JBank.Lib.Data;
using JBank.Lib.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class Dashboard : Form
    {
        private readonly IAccountRepository acctrepo;
        public Dashboard(IAccountRepository Acctrepo)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
        }


        public static string userDetails(string email)
        {
            string user = "";
            using (var JBContext = new JBankContext())
            {

                var check = JBContext.Customers.FirstOrDefault(x => x.Email == email);
               
                   
                    if (check != null)
                    {
                        user = check.FullName;
                        UserSession.CurrentUserID.Add(check.CustomerId);
                    }

                
            }
            return user;
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            try
            {
                string email = "";

                foreach (var item in UserSession.CurrentUser)
                {
                    email = item.Split(",")[0];

                }
                userName.Text = userDetails(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void userControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dashboardBtn_Click(object sender, EventArgs e)
        {

            if (!userControlPanel.Controls.Contains(DashboardUsersControl.Instance))
            {
                userControlPanel.Controls.Add(DashboardUsersControl.Instance);
                DashboardUsersControl.Instance.Dock = DockStyle.Fill;
                DashboardUsersControl.Instance.BringToFront();
            }
            else
            {
                DashboardUsersControl.Instance.BringToFront();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depsoitBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanel.Controls.Contains(DepositUserControl.Instance))
            {
                userControlPanel.Controls.Add(DepositUserControl.Instance);
                DepositUserControl.Instance.Dock = DockStyle.Fill;
                DepositUserControl.Instance.BringToFront();

            }
            else
            {
                DepositUserControl.Instance.BringToFront();
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanel.Controls.Contains(TransferUserControl.Instance))
            {
                userControlPanel.Controls.Add(TransferUserControl.Instance);
                TransferUserControl.Instance.Dock = DockStyle.Fill;
                TransferUserControl.Instance.BringToFront();
            }
            else
            {
                TransferUserControl.Instance.BringToFront();
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (!userControlPanel.Controls.Contains(withdrawUserControl.Instance))
            {
                userControlPanel.Controls.Add(withdrawUserControl.Instance);
                withdrawUserControl.Instance.Dock = DockStyle.Fill;
                withdrawUserControl.Instance.BringToFront();
            }
            else
            {
                withdrawUserControl.Instance.BringToFront();
            }
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {

            if (!userControlPanel.Controls.Contains(TransactionUserControl.Instance))
            {
                userControlPanel.Controls.Add(TransactionUserControl.Instance);
                TransactionUserControl.Instance.Dock = DockStyle.Fill;
                TransactionUserControl.Instance.BringToFront();
            }
            else
            {
                TransactionUserControl.Instance.BringToFront();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AuthenticationRepository.CurrentUser = null;
            this.Hide();
            Login show = new Login();
            show.Show();
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void anotherAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                foreach (var item in UserSession.CurrentUserID)
                {
                    id = item.Split(",")[0];
                }
                using (var JBContext = new JBankContext())
                {

                    var check = JBContext.Customers.Include(x => x.Accounts).FirstOrDefault(x => x.CustomerId == id);
                   

                       
                        if (check != null)
                        {
                            foreach (var acc in check.Accounts)
                            {
                                if (acc.Type == "Savings")
                                {
                                    string accType = "Current";
                                  
                                    string acctno = Utilities.GenerateNumber();
                                    var account = new Account() { AccountNumber = acctno, CustomerId = id, Balance= 0, Type = accType,};
                                UserSession.CurrentUserID.Add(id);
                                    check.Accounts.Add(account);
                                    JBContext.Accounts.Add(account);
                                    JBContext.SaveChanges();
                                    MessageBox.Show("Your Current Account has been successfully created for you");
                                }
                                else 
                                {
                                    string accType = "Savings";
                                   
                                    string acctno = Utilities.GenerateNumber();
                                    var account = new Account() { AccountNumber = acctno, CustomerId = id, Balance = 1000, Type = accType, };
                                UserSession.CurrentUserID.Add(id);
                                check.Accounts.Add(account);
                                    JBContext.Accounts.Add(account);
                                    JBContext.SaveChanges();
                                MessageBox.Show("Your Savings Account has been successfully created for you");
                                }
                            }
                           
                            
                              
                            
                        }
                        else
                        {
                            MessageBox.Show("You Already Have Two Accounts");

                        }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
    
}
