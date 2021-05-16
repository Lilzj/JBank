  using JBank.Lib.Common;
using JBank.Lib.Core;
using JBank.Lib.Core.Interface;
using JBank.Lib.Core.Repository;
using JBank.Lib.Data;
using JBank.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class CreateAccount : UserControl
    {
        private readonly IAccountRepository acctrepo;
        private readonly IAuthenticationRepository authrepo;
        private readonly string _password;
        private Customer _customer;
        public CreateAccount(IAccountRepository Acctrepo, IAuthenticationRepository Authrepo, string password, Customer customer)
        {
            InitializeComponent();
            acctrepo = Acctrepo;
            authrepo = Authrepo;
            _password = password;
            _customer = customer;
        }

        public CreateAccount()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            var accType = "";
            var initialDeposit = 0;
            var narrate = "";

            if (radioButton1.Checked)
            {
                accType = radioButton1.Text;
                initialDeposit = Convert.ToInt32(textBox1.Text);
                narrate = note.Text;
                
                if (initialDeposit < 1000)
                {
                    MessageBox.Show("Initial deposit must be 1000 and above");

                }
                else
                {
                     _customer  = acctrepo.CreateTheAccount(accType, initialDeposit, narrate, _password, _customer);

                    var res = authrepo.Register(_customer);
                    if (res[0] == "failed")
                    {
                        MessageBox.Show(res[1]);
                    }
                    else
                    {
                        using (var JBContext = new JBankContext())
                        {

                            try
                            {
                                JBContext.Customers.Add(_customer);
                                JBContext.SaveChanges();

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                                //roll back the transaction if it was not succesfull

                            }
                        }


                        MessageBox.Show("Your Account have been Created Successfully: Login to your Dashboard");
                        Thread.Sleep(1000);
                        this.Hide();
                        Login lf = new Login(GlobalConfig.IAuthenticationinstance);
                        lf.Show();
                    }
                }
            }

            else
            {
                accType = radioButton2.Text;
                initialDeposit = Convert.ToInt32(textBox3.Text);
                narrate = note.Text;
                if (initialDeposit < 0)
                {
                    MessageBox.Show("Sorry you can't deposit less than 0");
                }
                else
                {
                    _customer = acctrepo.CreateTheAccount(accType, initialDeposit, narrate, _password, _customer);

                    var res = authrepo.Register(_customer);
                    if (res[0] == "failed")
                    {
                        MessageBox.Show(res[1]);
                    }
                    else
                    {
                        using (var JBContext = new JBankContext())
                        {

                            try
                            {
                                JBContext.Customers.Add(_customer);
                                JBContext.SaveChanges();

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                                //roll back the transaction if it was not succesfull

                            }
                        }


                        MessageBox.Show("Your Account have been Created Successfully: Login to your Dashboard");
                        Thread.Sleep(1000);
                        this.Hide();
                        Login lf = new Login(GlobalConfig.IAuthenticationinstance);
                        lf.Show();
                    }

                }
            }

        }

       // private void CreateTheAccount(string accType, int initialDeposit, string narrate)
       //{
       //     try
       //     {
                

                
       //     }
       //     catch (Exception ex)
       //     {
       //         MessageBox.Show(ex.Message);
       //     }
       // }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                savingsPanel.Visible = true;
                panel2.Visible = false;
                CurrentPanel.Visible = false;
                
            }
        }

        private void CurrentPanel_Paint(object sender, PaintEventArgs e)
        {
            //this.Visible = false;
        }

        private void savingsPanel_Paint(object sender, PaintEventArgs e)
        {
            //this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //this.Visible = true;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                savingsPanel.Visible = false;
                panel2.Visible = false;
                CurrentPanel.Visible = true;
            }
        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
