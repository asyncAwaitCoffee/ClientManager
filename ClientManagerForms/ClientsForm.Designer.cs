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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            clientsDataGridView = new DataGridView();
            clientsFormNotifyIcon = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            createMenuItem = new ToolStripMenuItem();
            createMenuSubItemClient = new ToolStripMenuItem();
            createMenuSubItemAccount = new ToolStripMenuItem();
            createMenuSubItemManager = new ToolStripMenuItem();
            transactionsMenuItem = new ToolStripMenuItem();
            transactionsMenuItemNew = new ToolStripMenuItem();
            transactionsMenuItemStatus = new ToolStripMenuItem();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            clientsDataGridView.Location = new Point(10, 41);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            clientsDataGridView.RowTemplate.Height = 50;
            clientsDataGridView.Size = new Size(934, 454);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { createMenuItem, transactionsMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // createMenuItem
            // 
            createMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMenuSubItemClient, createMenuSubItemAccount, createMenuSubItemManager });
            createMenuItem.Name = "createMenuItem";
            createMenuItem.Size = new Size(53, 20);
            createMenuItem.Text = "Create";
            // 
            // createMenuSubItemClient
            // 
            createMenuSubItemClient.Name = "createMenuSubItemClient";
            createMenuSubItemClient.Size = new Size(121, 22);
            createMenuSubItemClient.Text = "Client";
            createMenuSubItemClient.Click += createMenuSubItemClient_Click;
            // 
            // createMenuSubItemAccount
            // 
            createMenuSubItemAccount.Name = "createMenuSubItemAccount";
            createMenuSubItemAccount.Size = new Size(121, 22);
            createMenuSubItemAccount.Text = "Account";
            // 
            // createMenuSubItemManager
            // 
            createMenuSubItemManager.Name = "createMenuSubItemManager";
            createMenuSubItemManager.Size = new Size(121, 22);
            createMenuSubItemManager.Text = "Manager";
            createMenuSubItemManager.Visible = false;
            // 
            // transactionsMenuItem
            // 
            transactionsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsMenuItemNew, transactionsMenuItemStatus });
            transactionsMenuItem.Name = "transactionsMenuItem";
            transactionsMenuItem.Size = new Size(84, 20);
            transactionsMenuItem.Text = "Transactions";
            // 
            // transactionsMenuItemNew
            // 
            transactionsMenuItemNew.Name = "transactionsMenuItemNew";
            transactionsMenuItemNew.Size = new Size(106, 22);
            transactionsMenuItemNew.Text = "New";
            // 
            // transactionsMenuItemStatus
            // 
            transactionsMenuItemStatus.Name = "transactionsMenuItemStatus";
            transactionsMenuItemStatus.Size = new Size(106, 22);
            transactionsMenuItemStatus.Text = "Status";
            // 
            // nextPageNoButton
            // 
            nextPageNoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextPageNoButton.Location = new Point(488, 517);
            nextPageNoButton.Name = "nextPageNoButton";
            nextPageNoButton.Size = new Size(101, 43);
            nextPageNoButton.TabIndex = 3;
            nextPageNoButton.Text = "Next";
            nextPageNoButton.UseVisualStyleBackColor = true;
            nextPageNoButton.Click += nextPageNoButton_Click;
            // 
            // previousPageNoButton
            // 
            previousPageNoButton.Enabled = false;
            previousPageNoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            previousPageNoButton.Location = new Point(366, 517);
            previousPageNoButton.Name = "previousPageNoButton";
            previousPageNoButton.Size = new Size(101, 43);
            previousPageNoButton.TabIndex = 4;
            previousPageNoButton.Text = "Prev";
            previousPageNoButton.UseVisualStyleBackColor = true;
            previousPageNoButton.Click += previousPageNoButton_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(955, 580);
            Controls.Add(previousPageNoButton);
            Controls.Add(nextPageNoButton);
            Controls.Add(clientsDataGridView);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientsForm";
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
        private ToolStripMenuItem createMenuItem;
        private ToolStripMenuItem createMenuSubItemClient;
        private ToolStripMenuItem createMenuSubItemAccount;
        private ToolStripMenuItem createMenuSubItemManager;
        private ToolStripMenuItem transactionsMenuItem;
        private ToolStripMenuItem transactionsMenuItemNew;
        private ToolStripMenuItem transactionsMenuItemStatus;
        private Button nextPageNoButton;
        private Button previousPageNoButton;
    }
}