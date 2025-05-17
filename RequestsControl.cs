using System;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public class RequestsControl : UserControl
    {
        TextBox txtName = new TextBox();
        TextBox txtNational = new TextBox();
        TextBox txtPhone = new TextBox();
        TextBox txtRequest = new TextBox();
        Button btnSend = new Button();

        public RequestsControl()
        {
            Label lblTitle = new Label { Text = "Submit a Request", Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(120, 20), AutoSize = true };
            Label lblName = new Label { Text = "Name:", Location = new System.Drawing.Point(30, 70), AutoSize = true };
            txtName.Location = new System.Drawing.Point(120, 65); txtName.Width = 200;
            Label lblNational = new Label { Text = "National:", Location = new System.Drawing.Point(30, 110), AutoSize = true };
            txtNational.Location = new System.Drawing.Point(120, 105); txtNational.Width = 200;
            Label lblPhone = new Label { Text = "Phone:", Location = new System.Drawing.Point(30, 150), AutoSize = true };
            txtPhone.Location = new System.Drawing.Point(120, 145); txtPhone.Width = 200;
            Label lblRequest = new Label { Text = "Request:", Location = new System.Drawing.Point(30, 190), AutoSize = true };
            txtRequest.Location = new System.Drawing.Point(120, 185); txtRequest.Width = 200; txtRequest.Height = 60; txtRequest.Multiline = true;
            btnSend.Text = "Send"; btnSend.Location = new System.Drawing.Point(120, 260); btnSend.Click += BtnSend_Click;
            this.Controls.AddRange(new Control[] { lblTitle, lblName, txtName, lblNational, txtNational, lblPhone, txtPhone, lblRequest, txtRequest, btnSend });
            this.Dock = DockStyle.Fill;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            DatabaseHelper.InsertRequest(txtName.Text, txtNational.Text, txtPhone.Text, txtRequest.Text);
            MessageBox.Show("Request sent successfully!");
        }
    }
} 