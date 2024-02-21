﻿namespace ClientManagerForms
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            clientsDataGridView = new DataGridView();
            clientsFormNotifyIcon = new NotifyIcon(components);
            menuStrip1 = new MenuStrip();
            clientMenuItem = new ToolStripMenuItem();
            createMenuSubItemClientNew = new ToolStripMenuItem();
            createMenuSubItemAccount = new ToolStripMenuItem();
            transactionsMenuItem = new ToolStripMenuItem();
            transactionsMenuItemNew = new ToolStripMenuItem();
            transactionsMenuItemStatus = new ToolStripMenuItem();
            permissionsToolStripMenuItem = new ToolStripMenuItem();
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
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            clientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            clientsDataGridView.Location = new Point(11, 41);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.BackColor = Color.Silver;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            clientsDataGridView.RowTemplate.Height = 50;
            clientsDataGridView.Size = new Size(612, 454);
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
            menuStrip1.Size = new Size(635, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientMenuItem
            // 
            clientMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMenuSubItemClientNew, createMenuSubItemAccount });
            clientMenuItem.Name = "clientMenuItem";
            clientMenuItem.Size = new Size(50, 20);
            clientMenuItem.Text = "Client";
            // 
            // createMenuSubItemClientNew
            // 
            createMenuSubItemClientNew.Name = "createMenuSubItemClientNew";
            createMenuSubItemClientNew.Size = new Size(180, 22);
            createMenuSubItemClientNew.Text = "New";
            createMenuSubItemClientNew.Click += createMenuSubItemClient_Click;
            // 
            // createMenuSubItemAccount
            // 
            createMenuSubItemAccount.Name = "createMenuSubItemAccount";
            createMenuSubItemAccount.Size = new Size(180, 22);
            createMenuSubItemAccount.Text = "Account";
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
            transactionsMenuItemNew.Click += transactionsMenuItemNew_Click;
            // 
            // transactionsMenuItemStatus
            // 
            transactionsMenuItemStatus.Name = "transactionsMenuItemStatus";
            transactionsMenuItemStatus.Size = new Size(106, 22);
            transactionsMenuItemStatus.Text = "Status";
            transactionsMenuItemStatus.Click += transactionsMenuItemStatus_Click;
            // 
            // permissionsToolStripMenuItem
            // 
            permissionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managersToolStripMenuItem });
            permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            permissionsToolStripMenuItem.Size = new Size(82, 20);
            permissionsToolStripMenuItem.Text = "Permissions";
            permissionsToolStripMenuItem.Visible = false;
            // 
            // managersToolStripMenuItem
            // 
            managersToolStripMenuItem.Name = "managersToolStripMenuItem";
            managersToolStripMenuItem.Size = new Size(126, 22);
            managersToolStripMenuItem.Text = "Managers";
            managersToolStripMenuItem.Click += managersToolStripMenuItem_Click;
            // 
            // nextPageNoButton
            // 
            nextPageNoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextPageNoButton.Location = new Point(308, 525);
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
            previousPageNoButton.Location = new Point(186, 525);
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
            ClientSize = new Size(635, 580);
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
        private ToolStripMenuItem clientMenuItem;
        private ToolStripMenuItem createMenuSubItemClientNew;
        private ToolStripMenuItem createMenuSubItemAccount;
        private ToolStripMenuItem transactionsMenuItem;
        private ToolStripMenuItem transactionsMenuItemNew;
        private ToolStripMenuItem transactionsMenuItemStatus;
        private Button nextPageNoButton;
        private Button previousPageNoButton;
        private ToolStripMenuItem permissionsToolStripMenuItem;
        private ToolStripMenuItem managersToolStripMenuItem;
    }
}