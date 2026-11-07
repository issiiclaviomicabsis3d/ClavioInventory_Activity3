using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace claviomica_InventoryMS
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            btn1.Click += btnLog_Click;

            LinkLabel registerLink = pnlLogin.Controls.OfType<LinkLabel>().First(link =>
                link.Text.Equals("Register Here.", StringComparison.OrdinalIgnoreCase));
            registerLink.LinkClicked += registerLink_LinkClicked;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Enter your username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Database.AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to log in: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Register().ShowDialog(this);
            Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
