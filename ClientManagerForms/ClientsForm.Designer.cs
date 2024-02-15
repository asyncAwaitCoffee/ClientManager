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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            clientsDataGridView = new DataGridView();
            clientId = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            accountId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientId, surName, fullName, accountId });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            clientsDataGridView.Location = new Point(12, 112);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.Size = new Size(839, 312);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellContentClick += clientsDataGridView_CellContentClick;
            // 
            // clientId
            // 
            clientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientId.FillWeight = 2F;
            clientId.HeaderText = "Id";
            clientId.Name = "clientId";
            clientId.ReadOnly = true;
            // 
            // surName
            // 
            surName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surName.FillWeight = 10F;
            surName.HeaderText = "SurName";
            surName.Name = "surName";
            surName.ReadOnly = true;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullName.FillWeight = 10F;
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // accountId
            // 
            accountId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountId.FillWeight = 10F;
            accountId.HeaderText = "AccountId";
            accountId.Name = "accountId";
            accountId.ReadOnly = true;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 501);
            Controls.Add(clientsDataGridView);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8, 9, 8, 9);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientsForm";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView clientsDataGridView;
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn accountId;
    }
}