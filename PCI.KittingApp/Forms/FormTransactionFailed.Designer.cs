namespace PCI.KittingApp.Forms
{
    partial class FormTransactionFailed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransactionFailed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridTransactionFail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retry = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionFail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridTransactionFail);
            this.panel1.Location = new System.Drawing.Point(44, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 591);
            this.panel1.TabIndex = 0;
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
            this.TypeTransaction,
            this.DataTransaction,
            this.DateTransaction,
            this.Retry});
            this.dataGridTransactionFail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTransactionFail.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTransactionFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTransactionFail.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridTransactionFail.Location = new System.Drawing.Point(0, 0);
            this.dataGridTransactionFail.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridTransactionFail.Name = "dataGridTransactionFail";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTransactionFail.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTransactionFail.RowHeadersVisible = false;
            this.dataGridTransactionFail.RowHeadersWidth = 80;
            this.dataGridTransactionFail.RowTemplate.Height = 60;
            this.dataGridTransactionFail.Size = new System.Drawing.Size(1143, 591);
            this.dataGridTransactionFail.TabIndex = 0;
            this.dataGridTransactionFail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransactionFail_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // TypeTransaction
            // 
            this.TypeTransaction.HeaderText = "Type Transaction";
            this.TypeTransaction.MinimumWidth = 6;
            this.TypeTransaction.Name = "TypeTransaction";
            this.TypeTransaction.Width = 200;
            // 
            // DataTransaction
            // 
            this.DataTransaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTransaction.HeaderText = "DataTransaction";
            this.DataTransaction.MinimumWidth = 6;
            this.DataTransaction.Name = "DataTransaction";
            // 
            // DateTransaction
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DateTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateTransaction.HeaderText = "Date Transaction";
            this.DateTransaction.MinimumWidth = 6;
            this.DateTransaction.Name = "DateTransaction";
            this.DateTransaction.Width = 200;
            // 
            // Retry
            // 
            this.Retry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.Retry.DefaultCellStyle = dataGridViewCellStyle4;
            this.Retry.HeaderText = "Retry";
            this.Retry.Image = global::PCI.KittingApp.Properties.Resources.sync;
            this.Retry.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Retry.MinimumWidth = 35;
            this.Retry.Name = "Retry";
            this.Retry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Retry.Width = 80;
            // 
            // FormTransactionFailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1238, 682);
            this.Controls.Add(this.panel1);
            this.Name = "FormTransactionFailed";
            this.Text = "FormTransactionFailed";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridTransactionFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTransaction;
        private System.Windows.Forms.DataGridViewImageColumn Retry;
    }
}