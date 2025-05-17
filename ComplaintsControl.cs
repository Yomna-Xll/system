using System;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public class ComplaintsControl : UserControl
    {
        TextBox txtName = new TextBox();
        TextBox txtNational = new TextBox();
        TextBox txtPhone = new TextBox();
        TextBox txtComplaint = new TextBox();
        Button btnSend = new Button();

        public ComplaintsControl()
        {
            Label lblTitle = new Label { Text = "Submit a Complaint", Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(120, 20), AutoSize = true };
            Label lblName = new Label { Text = "Name:", Location = new System.Drawing.Point(30, 70), AutoSize = true };
            txtName.Location = new System.Drawing.Point(120, 65); txtName.Width = 200;
            Label lblNational = new Label { Text = "National:", Location = new System.Drawing.Point(30, 110), AutoSize = true };
            txtNational.Location = new System.Drawing.Point(120, 105); txtNational.Width = 200;
            Label lblPhone = new Label { Text = "Phone:", Location = new System.Drawing.Point(30, 150), AutoSize = true };
            txtPhone.Location = new System.Drawing.Point(120, 145); txtPhone.Width = 200;
            Label lblComplaint = new Label { Text = "Complaint:", Location = new System.Drawing.Point(30, 190), AutoSize = true };
            txtComplaint.Location = new System.Drawing.Point(120, 185); txtComplaint.Width = 200; txtComplaint.Height = 60; txtComplaint.Multiline = true;
            btnSend.Text = "Send"; btnSend.Location = new System.Drawing.Point(120, 260); btnSend.Click += BtnSend_Click;
            this.Controls.AddRange(new Control[] { lblTitle, lblName, txtName, lblNational, txtNational, lblPhone, txtPhone, lblComplaint, txtComplaint, btnSend });
            this.Dock = DockStyle.Fill;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            DatabaseHelper.InsertComplaint(txtName.Text, txtNational.Text, txtPhone.Text, txtComplaint.Text);
            MessageBox.Show("Complaint sent successfully!");
        }
    }
} 