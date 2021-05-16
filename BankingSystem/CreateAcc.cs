using JBank.Lib.Common;
using JBank.Lib.Core;
using JBank.Lib.Core.Interface;
using JBank.Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JBankUI
{
    public partial class CreateAcc : UserControl
    {

        private readonly IAccountRepository acctrepo;
        private readonly IAuthenticationRepository authrepo;
        private readonly ICustomerRepository cusRepo;

        public CreateAcc()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (firstName.Text == "" || lastName.Text == "")
            {
                MessageBox.Show("First Name or Last Name must not be empty");

            } else if (!Utilities.ValidateEmail(emailReg.Text))
            {
                MessageBox.Show("Invalid Email");

            }
            else if (passReg.Text == "")
            {
                MessageBox.Show("password cannot be empty");
            }

            else if (passReg.Text != cPassReg.Text)
            {
                MessageBox.Show("The two password do not match");
            }
            else
            {
              
               
                var fname = firstName.Text;
                var lname = lastName.Text;
                var email = emailReg.Text;
                var pass = passReg.Text;

                var customer = new Customer() { FirstName = fname, LastName = lname, Email = email };
                CusAdd.customerDetails.Add(customer);
              
             
                if (!Login.Instance.Content.Controls.ContainsKey("CreateAccount"))
                {
                    CreateAccount create2 = new CreateAccount(GlobalConfig.IAccountinstance,GlobalConfig.IAuthenticationinstance, pass , customer);
                    create2.Dock = DockStyle.Fill;
                    Login.Instance.Content.Controls.Add(create2);
                }
                Login.Instance.Content.Controls["CreateAccount"].BringToFront();
                Login.Instance.SignUp.Visible = true;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Abort Account Creation?....", "And Go To Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CreateAcc create1 = new CreateAcc();
                Login log = new Login();
                Login.Instance.Content.Controls.Remove(create1);
                log.Dock = DockStyle.Fill;
                log.Visible = true;
                log.BringToFront();
                log.Focus();
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {
            firstName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            panel1.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            lastName.BackColor = SystemColors.Control;
            emailReg.BackColor = SystemColors.Control;
            passReg.BackColor = SystemColors.Control;
            cPassReg.BackColor = SystemColors.Control;
        }

        private void lastName_Click(object sender, EventArgs e)
        {
            lastName.BackColor = Color.White;
            panel2.BackColor = Color.White;
            firstName.BackColor = SystemColors.Control;
            emailReg.BackColor = SystemColors.Control;
            passReg.BackColor = SystemColors.Control;
            cPassReg.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            panel1.BackColor = SystemColors.Control;
        }

        private void emailReg_Click(object sender, EventArgs e)
        {
            emailReg.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            firstName.BackColor = SystemColors.Control;
            lastName.BackColor = SystemColors.Control;
            passReg.BackColor = SystemColors.Control;
            cPassReg.BackColor = SystemColors.Control;
        }

        private void passReg_Click(object sender, EventArgs e)
        {
            lastName.BackColor = SystemColors.Control;
            panel2.BackColor = SystemColors.Control;
            panel1.BackColor = SystemColors.Control;
            firstName.BackColor = SystemColors.Control;
            emailReg.BackColor = SystemColors.Control;
            passReg.BackColor = Color.White;
            cPassReg.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
        }

        private void cPassReg_Click(object sender, EventArgs e)
        {
            lastName.BackColor = SystemColors.Control;
            panel2.BackColor = SystemColors.Control;
            firstName.BackColor = SystemColors.Control;
            emailReg.BackColor = SystemColors.Control;
            passReg.BackColor = SystemColors.Control;
            cPassReg.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = Color.White;
            panel1.BackColor = SystemColors.Control;
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
