using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace claviomica_InventoryMS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            btn2.Click += btn2_Click;

            LinkLabel signInLink = panel1.Controls.OfType<LinkLabel>().First(link =>
                link.Text.Equals("Sign In", StringComparison.OrdinalIgnoreCase));
            signInLink.LinkClicked += signInLink_LinkClicked;
        }

        private void btn2_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Complete all registration fields.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!textBox6.Text.Equals(textBox7.Text, StringComparison.Ordinal))
            {
                MessageBox.Show("Passwords do not match.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contactNumber = textBox4.Text.Trim();

            try
            {
                string password = textBox6.Text;

                bool registered = Database.RegisterUser(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    contactNumber,
                    textBox3.Text.Trim(),
                    password);

                if (!registered)
                {
                    MessageBox.Show("That username is already registered.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Registration successful.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to register: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signInLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
