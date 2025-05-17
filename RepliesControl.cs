using System;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public class RepliesControl : UserControl
    {
        TextBox txtRequestId = new TextBox();
        TextBox txtReply = new TextBox();
        Button btnSend = new Button();

        public RepliesControl()
        {
            Label lblTitle = new Label { Text = "Submit a Reply", Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(120, 20), AutoSize = true };
            Label lblRequestId = new Label { Text = "Request ID:", Location = new System.Drawing.Point(30, 70), AutoSize = true };
            txtRequestId.Location = new System.Drawing.Point(120, 65); txtRequestId.Width = 200;
            Label lblReply = new Label { Text = "Reply:", Location = new System.Drawing.Point(30, 110), AutoSize = true };
            txtReply.Location = new System.Drawing.Point(120, 105); txtReply.Width = 200; txtReply.Height = 60; txtReply.Multiline = true;
            btnSend.Text = "Send"; btnSend.Location = new System.Drawing.Point(120, 180); btnSend.Click += BtnSend_Click;
            this.Controls.AddRange(new Control[] { lblTitle, lblRequestId, txtRequestId, lblReply, txtReply, btnSend });
            this.Dock = DockStyle.Fill;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRequestId.Text, out int requestId))
            {
                DatabaseHelper.InsertReply(requestId, txtReply.Text);
                MessageBox.Show("Reply sent successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Request ID!");
            }
        }
    }
} 