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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            clientsDataGridView = new DataGridView();
            clientId = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            accountId = new DataGridViewTextBoxColumn();
            checkClientColumn = new DataGridViewCheckBoxColumn();
            clientsFormNotifyIcon = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientId, surName, fullName, accountId, checkClientColumn });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            clientsDataGridView.Location = new Point(10, 115);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.Silver;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            clientsDataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            clientsDataGridView.RowTemplate.Height = 200;
            clientsDataGridView.Size = new Size(699, 279);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellDoubleClick += clientsDataGridView_CellDoubleClick;
            // 
            // clientId
            // 
            clientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientId.DefaultCellStyle = dataGridViewCellStyle8;
            clientId.FillWeight = 20F;
            clientId.HeaderText = "Id";
            clientId.Name = "clientId";
            clientId.ReadOnly = true;
            clientId.Width = 65;
            // 
            // surName
            // 
            surName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            surName.DefaultCellStyle = dataGridViewCellStyle9;
            surName.FillWeight = 40F;
            surName.HeaderText = "SurName";
            surName.Name = "surName";
            surName.ReadOnly = true;
            surName.Width = 151;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            fullName.DefaultCellStyle = dataGridViewCellStyle10;
            fullName.FillWeight = 40F;
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            fullName.Width = 162;
            // 
            // accountId
            // 
            accountId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            accountId.DefaultCellStyle = dataGridViewCellStyle11;
            accountId.FillWeight = 30F;
            accountId.HeaderText = "AccountId";
            accountId.Name = "accountId";
            accountId.ReadOnly = true;
            accountId.Width = 161;
            // 
            // checkClientColumn
            // 
            checkClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = false;
            dataGridViewCellStyle12.Padding = new Padding(5);
            checkClientColumn.DefaultCellStyle = dataGridViewCellStyle12;
            checkClientColumn.FillWeight = 20F;
            checkClientColumn.HeaderText = "VIP";
            checkClientColumn.Name = "checkClientColumn";
            checkClientColumn.ReadOnly = true;
            checkClientColumn.Width = 62;
            // 
            // clientsFormNotifyIcon
            // 
            clientsFormNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            clientsFormNotifyIcon.BalloonTipText = "Чтобы раскрыть приложение, нажмите на иконку";
            clientsFormNotifyIcon.BalloonTipTitle = "Подсказка";
            clientsFormNotifyIcon.Icon = (Icon)resources.GetObject("clientsFormNotifyIcon.Icon");
            clientsFormNotifyIcon.Text = "notifyIcon1";
            clientsFormNotifyIcon.Visible = true;
            clientsFormNotifyIcon.BalloonTipClicked += clientsFormNotifyIcon_BalloonTipClicked;
            clientsFormNotifyIcon.MouseClick += clientsFormNotifyIcon_MouseClick;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 412);
            Controls.Add(clientsDataGridView);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7);
            Name = "ClientsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientsForm";
            SizeChanged += ClientsForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView clientsDataGridView;
        private ListView clientsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn accountId;
        private DataGridViewCheckBoxColumn checkClientColumn;
        private NotifyIcon clientsFormNotifyIcon;
    }
}