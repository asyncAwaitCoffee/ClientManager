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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            clientsDataGridView = new DataGridView();
            clientId = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            accountId = new DataGridViewTextBoxColumn();
            checkClientColumn = new DataGridViewCheckBoxColumn();
            totalBalance = new DataGridViewTextBoxColumn();
            clientsFormNotifyIcon = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            createMenuItem = new ToolStripMenuItem();
            createMenuSubItemClient = new ToolStripMenuItem();
            createMenuSubItemAccount = new ToolStripMenuItem();
            createMenuSubItemManager = new ToolStripMenuItem();
            transactionsMenuItem = new ToolStripMenuItem();
            transactionsMenuItemNew = new ToolStripMenuItem();
            transactionsMenuItemStatus = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientId, surName, fullName, accountId, checkClientColumn, totalBalance });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            clientsDataGridView.Location = new Point(10, 115);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Silver;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            clientsDataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            clientsDataGridView.RowTemplate.Height = 200;
            clientsDataGridView.Size = new Size(934, 454);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellDoubleClick += clientsDataGridView_CellDoubleClick;
            // 
            // clientId
            // 
            clientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientId.DefaultCellStyle = dataGridViewCellStyle1;
            clientId.FillWeight = 20F;
            clientId.HeaderText = "Id";
            clientId.Name = "clientId";
            clientId.ReadOnly = true;
            clientId.Width = 65;
            // 
            // surName
            // 
            surName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            surName.DefaultCellStyle = dataGridViewCellStyle2;
            surName.FillWeight = 40F;
            surName.HeaderText = "SurName";
            surName.Name = "surName";
            surName.ReadOnly = true;
            surName.Width = 151;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            fullName.DefaultCellStyle = dataGridViewCellStyle3;
            fullName.FillWeight = 40F;
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            fullName.Width = 162;
            // 
            // accountId
            // 
            accountId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            accountId.DefaultCellStyle = dataGridViewCellStyle4;
            accountId.FillWeight = 30F;
            accountId.HeaderText = "AccountId";
            accountId.Name = "accountId";
            accountId.ReadOnly = true;
            accountId.Width = 161;
            // 
            // checkClientColumn
            // 
            checkClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.Padding = new Padding(5);
            checkClientColumn.DefaultCellStyle = dataGridViewCellStyle5;
            checkClientColumn.FillWeight = 20F;
            checkClientColumn.HeaderText = "VIP";
            checkClientColumn.Name = "checkClientColumn";
            checkClientColumn.ReadOnly = true;
            checkClientColumn.Width = 62;
            // 
            // totalBalance
            // 
            totalBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            totalBalance.HeaderText = "Total Balance";
            totalBalance.Name = "totalBalance";
            totalBalance.ReadOnly = true;
            totalBalance.Width = 197;
            // 
            // clientsFormNotifyIcon
            // 
            clientsFormNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            clientsFormNotifyIcon.BalloonTipText = "Click to expand window";
            clientsFormNotifyIcon.BalloonTipTitle = "Clients Manager";
            clientsFormNotifyIcon.Icon = (Icon)resources.GetObject("clientsFormNotifyIcon.Icon");
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
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(955, 580);
            Controls.Add(clientsDataGridView);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7);
            Name = "ClientsForm";
            ShowInTaskbar = false;
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
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn accountId;
        private DataGridViewCheckBoxColumn checkClientColumn;
        private DataGridViewTextBoxColumn totalBalance;
    }
}