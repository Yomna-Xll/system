using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form4 : Form
    {
        private Panel sidebar;
        private Button btnComplaints;
        private Button btnRequests;
        private Button btnReplies;
        private Panel mainPanel;
        private Label lblTitle;
        private Label lblName;
        private Label lblNational;
        private Label lblPhone;
        private Label lblRequest;
        private TextBox txtName;
        private TextBox txtNational;
        private TextBox txtPhone;
        private TextBox txtRequest;
        private Button btnSend;
        private Button btnCancel;

        public Form4()
        {
            InitializeComponent();
            SetupUI();
            btnRequests.Click += (s, e) => ShowSection("requests");
            btnComplaints.Click += (s, e) => ShowSection("complaints");
            btnReplies.Click += (s, e) => ShowSection("replies");
            ShowSection("requests"); // الافتراضي
        }

        private void SetupUI()
        {
            // Sidebar
            sidebar = new Panel
            {
                BackColor = Color.FromArgb(0, 180, 228),
                Dock = DockStyle.Left,
                Width = 180
            };

            btnComplaints = new Button
            {
                Text = "Complaints",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 180, 228),
                FlatStyle = FlatStyle.Flat,
                Height = 60,
                Dock = DockStyle.Top
            };
            btnComplaints.FlatAppearance.BorderSize = 0;

            btnRequests = new Button
            {
                Text = "Requests",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 180, 228),
                FlatStyle = FlatStyle.Flat,
                Height = 60,
                Dock = DockStyle.Top
            };
            btnRequests.FlatAppearance.BorderSize = 0;

            btnReplies = new Button
            {
                Text = "Replies",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 180, 228),
                FlatStyle = FlatStyle.Flat,
                Height = 60,
                Dock = DockStyle.Top
            };
            btnReplies.FlatAppearance.BorderSize = 0;

            sidebar.Controls.Add(btnReplies);
            sidebar.Controls.Add(btnRequests);
            sidebar.Controls.Add(btnComplaints);
            this.Controls.Add(sidebar);

            // Main Panel
            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(mainPanel);

            // Title
            lblTitle = new Label
            {
                Text = "Submit a Request",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(300, 50)
            };
            mainPanel.Controls.Add(lblTitle);

            // Labels and TextBoxes
            lblName = new Label { Text = "Name:", Font = new Font("Segoe UI", 12), Location = new Point(220, 120), AutoSize = true };
            txtName = new TextBox { Font = new Font("Segoe UI", 12), Location = new Point(320, 115), Size = new Size(200, 30) };

            lblNational = new Label { Text = "National", Font = new Font("Segoe UI", 12), Location = new Point(220, 160), AutoSize = true, ForeColor = Color.FromArgb(200, 150, 0) };
            txtNational = new TextBox { Font = new Font("Segoe UI", 12), Location = new Point(320, 155), Size = new Size(200, 30) };

            lblPhone = new Label { Text = "Phone", Font = new Font("Segoe UI", 12), Location = new Point(220, 200), AutoSize = true };
            txtPhone = new TextBox { Font = new Font("Segoe UI", 12), Location = new Point(320, 195), Size = new Size(200, 30) };

            lblRequest = new Label { Text = "Request:", Font = new Font("Segoe UI", 12), Location = new Point(220, 240), AutoSize = true };
            txtRequest = new TextBox { Font = new Font("Segoe UI", 12), Location = new Point(320, 235), Size = new Size(250, 60), Multiline = true };

            mainPanel.Controls.Add(lblName);
            mainPanel.Controls.Add(txtName);
            mainPanel.Controls.Add(lblNational);
            mainPanel.Controls.Add(txtNational);
            mainPanel.Controls.Add(lblPhone);
            mainPanel.Controls.Add(txtPhone);
            mainPanel.Controls.Add(lblRequest);
            mainPanel.Controls.Add(txtRequest);

            // Buttons
            btnSend = new Button
            {
                Text = "Send",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 180, 228),
                ForeColor = Color.White,
                Location = new Point(320, 320),
                Size = new Size(90, 40),
                FlatStyle = FlatStyle.Flat
            };
            btnSend.FlatAppearance.BorderSize = 1;
            btnSend.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 228);

            btnCancel = new Button
            {
                Text = "Cancel",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = Color.Black,
                Location = new Point(420, 320),
                Size = new Size(90, 40),
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.BorderColor = Color.Gray;

            mainPanel.Controls.Add(btnSend);
            mainPanel.Controls.Add(btnCancel);
        }

        private void ShowSection(string section)
        {
            mainPanel.Controls.Clear();
            UserControl control = null;
            switch (section)
            {
                case "requests":
                    control = new RequestsControl();
                    break;
                case "complaints":
                    control = new ComplaintsControl();
                    break;
                case "replies":
                    control = new RepliesControl();
                    break;
            }
            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(control);
            }
        }
    }
}
