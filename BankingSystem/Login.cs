using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBank.Lib.Data;
using JBank.Lib.Core.Interface;
using JBank.Lib.Core.Repository;
using System.Threading;
using JBank.Lib.Core;
using System.Data.SqlClient;
using JBank.Lib.Model;

namespace JBankUI
{
    public partial class Login : Form
    {
        static Login _obj;

        public static Login Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Login();
                }
                return _obj;
            }
        }

        public readonly IAuthenticationRepository authrepo;
        public Login(IAuthenticationRepository Authrepo)
        {
            authrepo = Authrepo;
            InitializeComponent();


        }

        public Button SignUp
        {
            get { return button3; }
            set { button3 = value; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pass_login.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pass_login.UseSystemPasswordChar = true;
        }

        public void ShowControl(Control control)
        {
            Content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);
        }

        private void login_load(object sender, EventArgs e)
        {

            _obj = this;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateAcc create1 = new CreateAcc();
            ShowControl(create1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var JBContext = new JBankContext())
            {
                var check = JBContext.Customers.Where(x => x.Email == email_login.Text);



                if (check != null)
                {
                    //check existence of a user
                    if (authrepo.Login(email_login.Text, pass_login.Text))
                    {

                         UserSession.CurrentUser.Add(email_login.Text);

                        this.Hide();
                        Dashboard db = new Dashboard(GlobalConfig.IAccountinstance);
                        db.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password/Email");
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist");
                }
            }
        }

        private void email_login_Click(object sender, EventArgs e)
        {
            email_login.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            pass_login.BackColor = SystemColors.Control;
        }

        private void pass_login_Click(object sender, EventArgs e)
        {
            pass_login.BackColor = Color.White;
            panel4.BackColor = Color.White;
            email_login.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
    }
}
