namespace claviomica_InventoryMS
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LinkLabel linkLabel1;
            pnlLogin = new Panel();
            btn1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(358, 383);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Here.";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(250, 248, 252);
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(btn1);
            pnlLogin.Controls.Add(textBox2);
            pnlLogin.Controls.Add(textBox1);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(linkLabel1);
            pnlLogin.Location = new Point(138, 33);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(668, 493);
            pnlLogin.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(103, 65, 165);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.White;
            btn1.ImageAlign = ContentAlignment.TopLeft;
            btn1.Location = new Point(266, 333);
            btn1.Name = "btn1";
            btn1.Size = new Size(142, 38);
            btn1.TabIndex = 6;
            btn1.Text = "SIGN-IN";
            btn1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 31);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 31);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 383);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 3;
            label4.Text = "Don't have an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 221);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 120);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(574, 45);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 36, 91);
            ClientSize = new Size(944, 576);
            Controls.Add(pnlLogin);
            Name = "LogIn";
            Text = " ";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btn1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}