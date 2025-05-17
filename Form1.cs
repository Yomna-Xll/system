using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            this.Text = "My Colorful Form";
            
            // Create a button
            Button button1 = new Button();
            button1.Text = "Click Me";
            button1.Location = new Point(100, 100);
            button1.Size = new Size(100, 40);
            button1.BackColor = Color.LightGreen;
            button1.ForeColor = Color.DarkBlue;
            button1.Click += Button1_Click;
            
            // Add the button to the form
            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! This is a colorful form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
} 