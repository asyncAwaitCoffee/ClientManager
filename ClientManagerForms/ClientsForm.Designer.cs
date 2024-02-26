namespace ClientManagerForms
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            clientsDataGridView = new DataGridView();
            clientsFormNotifyIcon = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            clientMenuItem = new ToolStripMenuItem();
            createMenuSubItemClientNew = new ToolStripMenuItem();
            buildReportToolStripMenuItem = new ToolStripMenuItem();
            transactionsMenuItem = new ToolStripMenuItem();
            transactionsMenuItemNew = new ToolStripMenuItem();
            transactionsMenuItemLog = new ToolStripMenuItem();
            permissionsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            managersToolStripMenuItem = new ToolStripMenuItem();
            nextPageNoButton = new Button();
            previousPageNoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            clientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientsDataGridView.Location = new Point(9, 33);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            clientsDataGridView.RowTemplate.Height = 50;
            clientsDataGridView.Size = new Size(872, 478);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellDoubleClick += clientsDataGridView_CellDoubleClick;
            // 
            // clientsFormNotifyIcon
            // 
            clientsFormNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            clientsFormNotifyIcon.BalloonTipText = "Click to expand window";
            clientsFormNotifyIcon.BalloonTipTitle = "Clients Manager";
            clientsFormNotifyIcon.Text = "Clients Manager";
            clientsFormNotifyIcon.Visible = true;
            clientsFormNotifyIcon.BalloonTipClicked += clientsFormNotifyIcon_BalloonTipClicked;
            clientsFormNotifyIcon.MouseClick += clientsFormNotifyIcon_MouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientMenuItem, transactionsMenuItem, permissionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(892, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientMenuItem
            // 
            clientMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMenuSubItemClientNew, buildReportToolStripMenuItem });
            clientMenuItem.Name = "clientMenuItem";
            clientMenuItem.Size = new Size(50, 20);
            clientMenuItem.Text = "Client";
            // 
            // createMenuSubItemClientNew
            // 
            createMenuSubItemClientNew.Name = "createMenuSubItemClientNew";
            createMenuSubItemClientNew.Size = new Size(139, 22);
            createMenuSubItemClientNew.Text = "New";
            createMenuSubItemClientNew.Click += createMenuSubItemClient_Click;
            // 
            // buildReportToolStripMenuItem
            // 
            buildReportToolStripMenuItem.Name = "buildReportToolStripMenuItem";
            buildReportToolStripMenuItem.Size = new Size(139, 22);
            buildReportToolStripMenuItem.Text = "Build Report";
            buildReportToolStripMenuItem.Click += buildReportToolStripMenuItem_Click;
            // 
            // transactionsMenuItem
            // 
            transactionsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsMenuItemNew, transactionsMenuItemLog });
            transactionsMenuItem.Name = "transactionsMenuItem";
            transactionsMenuItem.Size = new Size(84, 20);
            transactionsMenuItem.Text = "Transactions";
            // 
            // transactionsMenuItemNew
            // 
            transactionsMenuItemNew.Name = "transactionsMenuItemNew";
            transactionsMenuItemNew.Size = new Size(132, 22);
            transactionsMenuItemNew.Text = "New";
            transactionsMenuItemNew.Click += transactionsMenuItemNew_Click;
            // 
            // transactionsMenuItemLog
            // 
            transactionsMenuItemLog.Name = "transactionsMenuItemLog";
            transactionsMenuItemLog.Size = new Size(132, 22);
            transactionsMenuItemLog.Text = "Browse log";
            transactionsMenuItemLog.Click += transactionsMenuItemStatus_Click;
            // 
            // permissionsToolStripMenuItem
            // 
            permissionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, managersToolStripMenuItem });
            permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            permissionsToolStripMenuItem.Size = new Size(82, 20);
            permissionsToolStripMenuItem.Text = "Permissions";
            permissionsToolStripMenuItem.Visible = false;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(126, 22);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += managersToolStripMenuItem_Click;
            // 
            // managersToolStripMenuItem
            // 
            managersToolStripMenuItem.Name = "managersToolStripMenuItem";
            managersToolStripMenuItem.Size = new Size(126, 22);
            managersToolStripMenuItem.Text = "Managers";
            managersToolStripMenuItem.Click += managersToolStripMenuItem_Click_1;
            // 
            // nextPageNoButton
            // 
            nextPageNoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextPageNoButton.Location = new Point(458, 526);
            nextPageNoButton.Margin = new Padding(2);
            nextPageNoButton.Name = "nextPageNoButton";
            nextPageNoButton.Size = new Size(81, 35);
            nextPageNoButton.TabIndex = 3;
            nextPageNoButton.Text = "Next";
            nextPageNoButton.UseVisualStyleBackColor = true;
            nextPageNoButton.Click += nextPageNoButton_Click;
            // 
            // previousPageNoButton
            // 
            previousPageNoButton.Enabled = false;
            previousPageNoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            previousPageNoButton.Location = new Point(354, 526);
            previousPageNoButton.Margin = new Padding(2);
            previousPageNoButton.Name = "previousPageNoButton";
            previousPageNoButton.Size = new Size(81, 35);
            previousPageNoButton.TabIndex = 4;
            previousPageNoButton.Text = "Prev";
            previousPageNoButton.UseVisualStyleBackColor = true;
            previousPageNoButton.Click += previousPageNoButton_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 575);
            Controls.Add(previousPageNoButton);
            Controls.Add(nextPageNoButton);
            Controls.Add(clientsDataGridView);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients";
            SizeChanged += ClientsForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView clientsDataGridView;
        private ListView clientsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private NotifyIcon clientsFormNotifyIcon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientMenuItem;
        private ToolStripMenuItem createMenuSubItemClientNew;
        private ToolStripMenuItem transactionsMenuItem;
        private ToolStripMenuItem transactionsMenuItemNew;
        private ToolStripMenuItem transactionsMenuItemLog;
        private Button nextPageNoButton;
        private Button previousPageNoButton;
        private ToolStripMenuItem permissionsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem managersToolStripMenuItem;
        private ToolStripMenuItem buildReportToolStripMenuItem;
    }
}