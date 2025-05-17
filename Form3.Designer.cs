namespace MyWinFormsApp22;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel panelSidebar;
    private System.Windows.Forms.Button btnComplaints;
    private System.Windows.Forms.Button btnRequests;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelMain;
    private System.Windows.Forms.ListView listViewItems;
    private System.Windows.Forms.GroupBox groupBoxDetails;
    private System.Windows.Forms.Label lblDetails;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnReply;
    private System.Windows.Forms.Label lblSectionTitle;

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
        this.panelSidebar = new System.Windows.Forms.Panel();
        this.btnComplaints = new System.Windows.Forms.Button();
        this.btnRequests = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();
        this.panelMain = new System.Windows.Forms.Panel();
        this.listViewItems = new System.Windows.Forms.ListView();
        this.groupBoxDetails = new System.Windows.Forms.GroupBox();
        this.lblDetails = new System.Windows.Forms.Label();
        this.btnSend = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnReply = new System.Windows.Forms.Button();
        this.lblSectionTitle = new System.Windows.Forms.Label();
        // 
        // panelSidebar
        // 
        this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelSidebar.Width = 150;
        this.panelSidebar.Controls.Add(this.btnComplaints);
        this.panelSidebar.Controls.Add(this.btnRequests);
        // 
        // btnComplaints
        // 
        this.btnComplaints.Text = "Complaints";
        this.btnComplaints.Location = new System.Drawing.Point(10, 100);
        this.btnComplaints.Size = new System.Drawing.Size(130, 40);
        this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnComplaints.ForeColor = System.Drawing.Color.White;
        this.btnComplaints.BackColor = System.Drawing.Color.FromArgb(65, 105, 225);
        // 
        // btnRequests
        // 
        this.btnRequests.Text = "Requests";
        this.btnRequests.Location = new System.Drawing.Point(10, 160);
        this.btnRequests.Size = new System.Drawing.Size(130, 40);
        this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRequests.ForeColor = System.Drawing.Color.White;
        this.btnRequests.BackColor = System.Drawing.Color.FromArgb(65, 105, 225);
        // 
        // lblTitle
        // 
        this.lblTitle.Text = "Manager";
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
        this.lblTitle.Location = new System.Drawing.Point(170, 10);
        this.lblTitle.Size = new System.Drawing.Size(300, 40);
        // 
        // panelMain
        // 
        this.panelMain.Location = new System.Drawing.Point(160, 60);
        this.panelMain.Size = new System.Drawing.Size(620, 380);
        this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
        this.panelMain.Controls.Add(this.listViewItems);
        this.panelMain.Controls.Add(this.groupBoxDetails);
        this.panelMain.Controls.Add(this.btnSend);
        this.panelMain.Controls.Add(this.btnCancel);
        this.panelMain.Controls.Add(this.btnReply);
        this.panelMain.Controls.Add(this.lblSectionTitle);
        this.panelMain.Controls.SetChildIndex(this.lblSectionTitle, 0);
        // 
        // listViewItems
        // 
        this.listViewItems.Location = new System.Drawing.Point(20, 20);
        this.listViewItems.Size = new System.Drawing.Size(250, 340);
        this.listViewItems.View = System.Windows.Forms.View.List;
        // 
        // groupBoxDetails
        // 
        this.groupBoxDetails.Text = "Details";
        this.groupBoxDetails.Location = new System.Drawing.Point(290, 20);
        this.groupBoxDetails.Size = new System.Drawing.Size(310, 200);
        this.groupBoxDetails.Controls.Add(this.lblDetails);
        // 
        // lblDetails
        // 
        this.lblDetails.Text = "Select an item to view details.";
        this.lblDetails.Location = new System.Drawing.Point(10, 30);
        this.lblDetails.Size = new System.Drawing.Size(290, 150);
        // 
        // btnSend
        // 
        this.btnSend.Text = "Send";
        this.btnSend.Location = new System.Drawing.Point(290, 240);
        this.btnSend.Size = new System.Drawing.Size(90, 40);
        this.btnSend.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
        this.btnSend.ForeColor = System.Drawing.Color.White;
        this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // btnCancel
        // 
        this.btnCancel.Text = "Cancel";
        this.btnCancel.Location = new System.Drawing.Point(410, 240);
        this.btnCancel.Size = new System.Drawing.Size(90, 40);
        this.btnCancel.BackColor = System.Drawing.Color.LightGray;
        this.btnCancel.ForeColor = System.Drawing.Color.Black;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // btnReply
        // 
        this.btnReply.Text = "Reply";
        this.btnReply.Location = new System.Drawing.Point(530, 240);
        this.btnReply.Size = new System.Drawing.Size(70, 40);
        this.btnReply.BackColor = System.Drawing.Color.FromArgb(65, 105, 225);
        this.btnReply.ForeColor = System.Drawing.Color.White;
        this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        // 
        // lblSectionTitle
        // 
        this.lblSectionTitle.Text = "Complaints Section";
        this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(65, 105, 225);
        this.lblSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblSectionTitle.Location = new System.Drawing.Point(160, -5);
        this.lblSectionTitle.Size = new System.Drawing.Size(300, 28);
        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.panelSidebar);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.panelMain);
        this.Text = "Employee";
    }

    #endregion
}
