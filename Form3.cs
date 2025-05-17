namespace MyWinFormsApp22;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btnComplaints.Click += BtnComplaints_Click;
        btnRequests.Click += BtnRequests_Click;
        ShowComplaints();
    }

    private void BtnComplaints_Click(object sender, EventArgs e)
    {
        ShowComplaints();
    }

    private void BtnRequests_Click(object sender, EventArgs e)
    {
        ShowRequests();
    }

    private void ShowComplaints()
    {
        lblSectionTitle.Text = "Complaints Section";
        listViewItems.Items.Clear();
        listViewItems.Items.Add("تأخير في الراتب");
        listViewItems.Items.Add("مشكلة في الحضور والانصراف");
        listViewItems.Items.Add("سوء معاملة المدير");
        lblDetails.Text = "اختر شكوى لعرض التفاصيل";
    }

    private void ShowRequests()
    {
        lblSectionTitle.Text = "Requests Section";
        listViewItems.Items.Clear();
        listViewItems.Items.Add("طلب إجازة سنوية");
        listViewItems.Items.Add("طلب سلفة مالية");
        listViewItems.Items.Add("طلب تغيير وردية العمل");
        lblDetails.Text = "اختر طلب لعرض التفاصيل";
    }
}
