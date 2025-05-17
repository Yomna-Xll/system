namespace MyWinFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel sidePanel;
    private System.Windows.Forms.Button btnComplaints;
    private System.Windows.Forms.Button btnRequests;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView dgvComplaints;
    private System.Windows.Forms.DataGridView dgvRequests;
    private System.Windows.Forms.Panel detailsPanel;
    private System.Windows.Forms.TextBox txtDetails;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnReply;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.sidePanel = new System.Windows.Forms.Panel();
        this.btnComplaints = new System.Windows.Forms.Button();
        this.btnRequests = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();
        this.dgvComplaints = new System.Windows.Forms.DataGridView();
        this.dgvRequests = new System.Windows.Forms.DataGridView();
        this.detailsPanel = new System.Windows.Forms.Panel();
        this.txtDetails = new System.Windows.Forms.TextBox();
        this.btnSend = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnReply = new System.Windows.Forms.Button();
        // 
        // sidePanel
        // 
        this.sidePanel.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
        this.sidePanel.Width = 200;
        this.sidePanel.Controls.Add(this.btnComplaints);
        this.sidePanel.Controls.Add(this.btnRequests);
        // 
        // btnComplaints
        // 
        this.btnComplaints.Text = "Complaints";
        this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnComplaints.ForeColor = System.Drawing.Color.White;
        this.btnComplaints.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        this.btnComplaints.Location = new System.Drawing.Point(10, 100);
        this.btnComplaints.Size = new System.Drawing.Size(180, 45);
        this.btnComplaints.TabIndex = 0;
        this.btnComplaints.FlatAppearance.BorderSize = 0;
        // 
        // btnRequests
        // 
        this.btnRequests.Text = "Requests";
        this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnRequests.ForeColor = System.Drawing.Color.White;
        this.btnRequests.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        this.btnRequests.Location = new System.Drawing.Point(10, 160);
        this.btnRequests.Size = new System.Drawing.Size(180, 45);
        this.btnRequests.TabIndex = 1;
        this.btnRequests.FlatAppearance.BorderSize = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.Text = "Employee";
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
        this.lblTitle.Location = new System.Drawing.Point(220, 20);
        this.lblTitle.Size = new System.Drawing.Size(300, 50);
        // 
        // dgvComplaints
        // 
        this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvComplaints.Location = new System.Drawing.Point(220, 80);
        this.dgvComplaints.Size = new System.Drawing.Size(750, 300);
        this.dgvComplaints.AllowUserToAddRows = false;
        this.dgvComplaints.AllowUserToDeleteRows = false;
        this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
        this.dgvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvComplaints.Columns.Add("ComplaintTitle", "Complaint Title");
        this.dgvComplaints.Columns.Add("ComplaintText", "Complaint");
        this.dgvComplaints.Columns.Add("ComplainantName", "Complainant Name");
        this.dgvComplaints.Columns.Add("ComplaintDate", "Complaint Date");
        this.dgvComplaints.Columns.Add("Status", "Status");
        this.dgvComplaints.Visible = false;
        // 
        // dgvRequests
        // 
        this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRequests.Location = new System.Drawing.Point(220, 80);
        this.dgvRequests.Size = new System.Drawing.Size(750, 300);
        this.dgvRequests.AllowUserToAddRows = false;
        this.dgvRequests.AllowUserToDeleteRows = false;
        this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
        this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvRequests.Columns.Add("RequestTitle", "Request Title");
        this.dgvRequests.Columns.Add("RequestText", "Request");
        this.dgvRequests.Columns.Add("RequesterName", "Requester Name");
        this.dgvRequests.Columns.Add("RequestDate", "Request Date");
        this.dgvRequests.Columns.Add("Status", "Status");
        this.dgvRequests.Visible = false;
        // 
        // detailsPanel
        // 
        this.detailsPanel.Location = new System.Drawing.Point(220, 390);
        this.detailsPanel.Size = new System.Drawing.Size(750, 200);
        this.detailsPanel.BackColor = System.Drawing.Color.White;
        this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.detailsPanel.Controls.Add(this.txtDetails);
        this.detailsPanel.Controls.Add(this.btnSend);
        this.detailsPanel.Controls.Add(this.btnCancel);
        this.detailsPanel.Controls.Add(this.btnReply);
        // 
        // txtDetails
        // 
        this.txtDetails.Multiline = true;
        this.txtDetails.Location = new System.Drawing.Point(10, 10);
        this.txtDetails.Size = new System.Drawing.Size(730, 100);
        this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        // 
        // btnSend
        // 
        this.btnSend.Text = "Send";
        this.btnSend.Location = new System.Drawing.Point(10, 120);
        this.btnSend.Size = new System.Drawing.Size(100, 35);
        this.btnSend.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
        this.btnSend.ForeColor = System.Drawing.Color.White;
        this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        // 
        // btnCancel
        // 
        this.btnCancel.Text = "Cancel";
        this.btnCancel.Location = new System.Drawing.Point(120, 120);
        this.btnCancel.Size = new System.Drawing.Size(100, 35);
        this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
        this.btnCancel.ForeColor = System.Drawing.Color.White;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        // 
        // btnReply
        // 
        this.btnReply.Text = "Send Reply";
        this.btnReply.Location = new System.Drawing.Point(230, 120);
        this.btnReply.Size = new System.Drawing.Size(100, 35);
        this.btnReply.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
        this.btnReply.ForeColor = System.Drawing.Color.White;
        this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 600);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.sidePanel);
        this.Controls.Add(this.dgvComplaints);
        this.Controls.Add(this.dgvRequests);
        this.Controls.Add(this.detailsPanel);
        this.Text = "Employee Management System";
        this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    }

    #endregion
}
