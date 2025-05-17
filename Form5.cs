using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsApp7
{
    public partial class Form5 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton citizen;
        private RadioButton employee;
        private RadioButton boss;
        private Button button1;
        private Button exit;

        public Form5()
        {
            InitializeComponent();
            SetupForm();
            CreateControls();
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(240, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(400, 500);
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            SetRoundedCorners(30);
        }

        private void CreateControls()
        {
            // إنشاء عنوان النموذج
            Label titleLabel = new Label
            {
                Text = "تسجيل الدخول",
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(70, 70, 120),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(300, 40),
                Location = new Point(50, 30),
                RightToLeft = RightToLeft.Yes
            };

            // إنشاء حقل اسم المستخدم
            txtUsername = new TextBox
            {
                Location = new Point(50, 100),
                Size = new Size(300, 30),
                Font = new Font("Arial", 12),
                PlaceholderText = "اسم المستخدم",
                RightToLeft = RightToLeft.Yes
            };

            // إنشاء حقل كلمة المرور
            txtPassword = new TextBox
            {
                Location = new Point(50, 150),
                Size = new Size(300, 30),
                Font = new Font("Arial", 12),
                PasswordChar = '●',
                PlaceholderText = "كلمة المرور",
                RightToLeft = RightToLeft.Yes
            };

            // إنشاء مجموعة الراديو باتون
            citizen = new RadioButton
            {
                Text = "مواطن",
                Location = new Point(250, 200),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12),
                RightToLeft = RightToLeft.Yes
            };

            employee = new RadioButton
            {
                Text = "موظف",
                Location = new Point(150, 200),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12),
                RightToLeft = RightToLeft.Yes
            };

            boss = new RadioButton
            {
                Text = "مدير",
                Location = new Point(50, 200),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12),
                RightToLeft = RightToLeft.Yes
            };

            // إنشاء زر تسجيل الدخول
            button1 = new Button
            {
                Text = "دخول",
                Location = new Point(50, 250),
                Size = new Size(300, 40),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(70, 70, 120),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                RightToLeft = RightToLeft.Yes
            };
            button1.Click += button1_Click;

            // إنشاء زر الخروج
            exit = new Button
            {
                Text = "خروج",
                Location = new Point(50, 300),
                Size = new Size(300, 40),
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(200, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                RightToLeft = RightToLeft.Yes
            };
            exit.Click += exit_Click_1;

            // إضافة العناصر إلى النموذج
            this.Controls.AddRange(new Control[] { 
                titleLabel, txtUsername, txtPassword, 
                citizen, employee, boss, 
                button1, exit 
            });

            // إضافة معالج حدث السحب
            this.MouseDown += Form5_MouseDown;
        }

        private void SetRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCorners(30);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت متأكد من الخروج؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string role = "";

            if (citizen.Checked)
                role = "Citizen";
            else if (employee.Checked)
                role = "Employee";
            else if (boss.Checked)
                role = "Boss";

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("الرجاء اختيار الدور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValid =
                (username == "admin" && password == "1234" && role == "Boss") ||
                (username == "huda" && password == "1234" && role == "Employee") ||
                (username == "ahmed" && password == "1234" && role == "Employee") ||
                (username == "yomna" && password == "1234" && role == "Boss") ||
                (username == "mohammed" && password == "1234" && role == "Employee") ||
                (username == "zeyad" && password == "1234" && role == "Citizen");

            if (isValid)
            {
                MessageBox.Show($"مرحباً {username} ({role})!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور أو الدور غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

