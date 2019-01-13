using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;


namespace SA47Team10a_GalaxyLibrary
{
    public partial class frm2Login : Form
    {
        //bool checkBoss = false;
        Form f;

        public string username;
        public frm2Login()
        {
            InitializeComponent();
            Password_text.PasswordChar = '*';
        }

        //public CheckBoss
        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = Username_txt.Text;
            string password = Password_text.Text;
            Username_txt.Text.Trim();

            using (GalaxyEntities context = new GalaxyEntities())
            {
                var user = context.Staffs.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    if (user.Password == password)
                    {
                        this.Hide();
                        //this.DialogResult = DialogResult.OK;
                        //proceed to new form = 
                        frm6BorrowBook f = new frm6BorrowBook();
                        //frmTemplate temp = new frmTemplate();
                        //temp.LbUserName = username;
                        f.Name = user.Name;

                        f.Location = this.Location;
                        f.ShowDialog();
                        this.Close();

                        //label4.Text = "Login successful";
                        //if (user.Username == "Venkat") {
                        //    checkBoss = true;
                        //}
                    }
                    else
                        label4.Text = "Wrong password";
                }
                else
                 label4.Text = "No User Called " + username + " found";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var password = Console.ReadLine();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (checkBox1.Checked == true)
                {
                    string password = Password_text.Text;
                    Password_text.PasswordChar = '\0';
                }
                else
                {
                    Password_text.PasswordChar = '*';
                }
         }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm1Welcome();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm3ChangePassword();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void Password_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }
    }
 }

