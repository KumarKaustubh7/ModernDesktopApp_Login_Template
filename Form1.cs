using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e){
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                if (txtPassword.Text == "root")
                {
                    MessageBox.Show("Access Granted", "Sign in Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dashboard ds = new Dashboard();
                    ds.Show();
                }
                else
                {
                    txtPassword.Clear();
                    txtUsername.Clear();
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtPassword.Text == "root")
                {
                    txtPassword.Clear();
                    txtUsername.Clear();
                    MessageBox.Show("Incorrect Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPassword.Clear();
                    txtUsername.Clear();
                    MessageBox.Show("Incorrect Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnSignIn.Enabled = true;
            }
            else
            {
                btnSignIn.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }
    }
}
