namespace MyWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        SetupEventHandlers();
        LoadInitialData();
    }

    private void SetupEventHandlers()
    {
        btnComplaints.Click += BtnComplaints_Click;
        btnRequests.Click += BtnRequests_Click;
        btnSend.Click += BtnSend_Click;
        btnCancel.Click += BtnCancel_Click;
        btnReply.Click += BtnReply_Click;
        
        dgvComplaints.SelectionChanged += DgvComplaints_SelectionChanged;
        dgvRequests.SelectionChanged += DgvRequests_SelectionChanged;
    }

    private void LoadInitialData()
    {
        // Show complaints by default
        BtnComplaints_Click(null, EventArgs.Empty);
    }

    private void BtnComplaints_Click(object sender, EventArgs e)
    {
        dgvComplaints.Visible = true;
        dgvRequests.Visible = false;
        detailsPanel.Visible = true;
        btnComplaints.BackColor = Color.FromArgb(0, 102, 184);
        btnRequests.BackColor = Color.FromArgb(0, 122, 204);
    }

    private void BtnRequests_Click(object sender, EventArgs e)
    {
        dgvRequests.Visible = true;
        dgvComplaints.Visible = false;
        detailsPanel.Visible = true;
        btnRequests.BackColor = Color.FromArgb(0, 102, 184);
        btnComplaints.BackColor = Color.FromArgb(0, 122, 204);
    }

    private void DgvComplaints_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvComplaints.SelectedRows.Count > 0)
        {
            var selectedComplaint = dgvComplaints.SelectedRows[0];
            txtDetails.Text = $"Complaint Title: {selectedComplaint.Cells["ComplaintTitle"].Value}\n\n" +
                            $"Complaint: {selectedComplaint.Cells["ComplaintText"].Value}\n\n" +
                            $"Complainant Name: {selectedComplaint.Cells["ComplainantName"].Value}\n\n" +
                            $"Complaint Date: {selectedComplaint.Cells["ComplaintDate"].Value}";
        }
    }

    private void DgvRequests_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvRequests.SelectedRows.Count > 0)
        {
            var selectedRequest = dgvRequests.SelectedRows[0];
            txtDetails.Text = $"Request Title: {selectedRequest.Cells["RequestTitle"].Value}\n\n" +
                            $"Request: {selectedRequest.Cells["RequestText"].Value}\n\n" +
                            $"Requester Name: {selectedRequest.Cells["RequesterName"].Value}\n\n" +
                            $"Request Date: {selectedRequest.Cells["RequestDate"].Value}";
        }
    }

    private void BtnSend_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Request sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        txtDetails.Clear();
        if (dgvComplaints.Visible)
            dgvComplaints.ClearSelection();
        if (dgvRequests.Visible)
            dgvRequests.ClearSelection();
    }

    private void BtnReply_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDetails.Text))
        {
            MessageBox.Show("Please enter a reply", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Reply sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
