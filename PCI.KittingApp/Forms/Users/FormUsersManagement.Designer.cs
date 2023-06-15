namespace PCI.KittingApp.Forms.Users
{
    partial class FormUsersManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUsers = new System.Windows.Forms.TableLayoutPanel();
            this.panelUserMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreateUser = new FontAwesome.Sharp.IconButton();
            this.dataGridTransactionFail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelUsers.SuspendLayout();
            this.panelUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionFail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.ColumnCount = 1;
            this.panelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUsers.Controls.Add(this.dataGridTransactionFail, 0, 1);
            this.panelUsers.Controls.Add(this.panelUserMenu, 0, 0);
            this.panelUsers.Location = new System.Drawing.Point(59, 63);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.RowCount = 2;
            this.panelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.306709F));
            this.panelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.69329F));
            this.panelUsers.Size = new System.Drawing.Size(1201, 626);
            this.panelUsers.TabIndex = 0;
            // 
            // panelUserMenu
            // 
            this.panelUserMenu.ColumnCount = 2;
            this.panelUserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.6862F));
            this.panelUserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31381F));
            this.panelUserMenu.Controls.Add(this.buttonCreateUser, 1, 0);
            this.panelUserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserMenu.Location = new System.Drawing.Point(3, 3);
            this.panelUserMenu.Name = "panelUserMenu";
            this.panelUserMenu.RowCount = 1;
            this.panelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUserMenu.Size = new System.Drawing.Size(1195, 46);
            this.panelUserMenu.TabIndex = 0;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.AutoSize = true;
            this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCreateUser.ForeColor = System.Drawing.Color.White;
            this.buttonCreateUser.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.buttonCreateUser.IconColor = System.Drawing.Color.White;
            this.buttonCreateUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCreateUser.IconSize = 30;
            this.buttonCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateUser.Location = new System.Drawing.Point(1015, 3);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(177, 40);
            this.buttonCreateUser.TabIndex = 101;
            this.buttonCreateUser.Text = "Create";
            this.buttonCreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            // 
            // dataGridTransactionFail
            // 
            this.dataGridTransactionFail.AllowUserToAddRows = false;
            this.dataGridTransactionFail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.dataGridTransactionFail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTransactionFail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTransactionFail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTransactionFail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTransactionFail.ColumnHeadersHeight = 55;
            this.dataGridTransactionFail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameUser,
            this.EmailUser,
            this.Edit,
            this.Delete});
            this.dataGridTransactionFail.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTransactionFail.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTransactionFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTransactionFail.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridTransactionFail.Location = new System.Drawing.Point(5, 57);
            this.dataGridTransactionFail.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridTransactionFail.Name = "dataGridTransactionFail";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTransactionFail.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTransactionFail.RowHeadersVisible = false;
            this.dataGridTransactionFail.RowHeadersWidth = 80;
            this.dataGridTransactionFail.RowTemplate.Height = 60;
            this.dataGridTransactionFail.Size = new System.Drawing.Size(1191, 564);
            this.dataGridTransactionFail.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // NameUser
            // 
            this.NameUser.HeaderText = "Name";
            this.NameUser.MinimumWidth = 6;
            this.NameUser.Name = "NameUser";
            this.NameUser.Width = 300;
            // 
            // EmailUser
            // 
            this.EmailUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmailUser.HeaderText = "Email";
            this.EmailUser.MinimumWidth = 6;
            this.EmailUser.Name = "EmailUser";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 35;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // FormUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1330, 742);
            this.Controls.Add(this.panelUsers);
            this.Name = "FormUsersManagement";
            this.Text = "FormUsersManagement";
            this.panelUsers.ResumeLayout(false);
            this.panelUserMenu.ResumeLayout(false);
            this.panelUserMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelUsers;
        private System.Windows.Forms.TableLayoutPanel panelUserMenu;
        private FontAwesome.Sharp.IconButton buttonCreateUser;
        private System.Windows.Forms.DataGridView dataGridTransactionFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}