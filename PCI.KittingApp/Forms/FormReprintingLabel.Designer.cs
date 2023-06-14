namespace PCI.KittingApp.Forms
{
    partial class FormReprintingLabel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelReprintLabel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.textBoxPrintingContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonReprintingMaterialLabel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReprintingUnitLabel = new FontAwesome.Sharp.IconButton();
            this.dataGridUnitPrintingLabel = new System.Windows.Forms.DataGridView();
            this.dataGridMaterialPrintingLabel = new System.Windows.Forms.DataGridView();
            this.PrintUnit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PrintMaterial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reprintingLabelMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reprintingLabelUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelReprintLabel.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnitPrintingLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterialPrintingLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprintingLabelMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprintingLabelUnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReprintLabel
            // 
            this.panelReprintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReprintLabel.ColumnCount = 2;
            this.panelReprintLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelReprintLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelReprintLabel.Controls.Add(this.panel1, 0, 2);
            this.panelReprintLabel.Controls.Add(this.panelMfgSubmit, 0, 2);
            this.panelReprintLabel.Controls.Add(this.PanelMfgName, 0, 0);
            this.panelReprintLabel.Controls.Add(this.dataGridMaterialPrintingLabel, 1, 1);
            this.panelReprintLabel.Controls.Add(this.dataGridUnitPrintingLabel, 0, 1);
            this.panelReprintLabel.Location = new System.Drawing.Point(40, 39);
            this.panelReprintLabel.Name = "panelReprintLabel";
            this.panelReprintLabel.RowCount = 3;
            this.panelReprintLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.panelReprintLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelReprintLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panelReprintLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelReprintLabel.Size = new System.Drawing.Size(1101, 565);
            this.panelReprintLabel.TabIndex = 0;
            // 
            // PanelMfgName
            // 
            this.PanelMfgName.Controls.Add(this.textBoxPrintingContainer);
            this.PanelMfgName.Controls.Add(this.label1);
            this.PanelMfgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMfgName.Location = new System.Drawing.Point(3, 3);
            this.PanelMfgName.Name = "PanelMfgName";
            this.PanelMfgName.Size = new System.Drawing.Size(544, 124);
            this.PanelMfgName.TabIndex = 10;
            // 
            // textBoxPrintingContainer
            // 
            this.textBoxPrintingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrintingContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxPrintingContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrintingContainer.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrintingContainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxPrintingContainer.Location = new System.Drawing.Point(17, 59);
            this.textBoxPrintingContainer.Name = "textBoxPrintingContainer";
            this.textBoxPrintingContainer.Size = new System.Drawing.Size(504, 50);
            this.textBoxPrintingContainer.TabIndex = 0;
            this.textBoxPrintingContainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUnitContainer_KeyDown);
            this.textBoxPrintingContainer.Leave += new System.EventHandler(this.textBoxUnitContainer_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Container / Identifier";
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.buttonReprintingMaterialLabel);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(553, 472);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(545, 90);
            this.panelMfgSubmit.TabIndex = 15;
            // 
            // buttonReprintingMaterialLabel
            // 
            this.buttonReprintingMaterialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReprintingMaterialLabel.AutoSize = true;
            this.buttonReprintingMaterialLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonReprintingMaterialLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReprintingMaterialLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReprintingMaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReprintingMaterialLabel.ForeColor = System.Drawing.Color.White;
            this.buttonReprintingMaterialLabel.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.buttonReprintingMaterialLabel.IconColor = System.Drawing.Color.White;
            this.buttonReprintingMaterialLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReprintingMaterialLabel.IconSize = 40;
            this.buttonReprintingMaterialLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReprintingMaterialLabel.Location = new System.Drawing.Point(234, 17);
            this.buttonReprintingMaterialLabel.Name = "buttonReprintingMaterialLabel";
            this.buttonReprintingMaterialLabel.Size = new System.Drawing.Size(294, 57);
            this.buttonReprintingMaterialLabel.TabIndex = 13;
            this.buttonReprintingMaterialLabel.Text = "Reprint All Material SN";
            this.buttonReprintingMaterialLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonReprintingMaterialLabel.UseVisualStyleBackColor = false;
            this.buttonReprintingMaterialLabel.Click += new System.EventHandler(this.buttonReprintingMaterialLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReprintingUnitLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 90);
            this.panel1.TabIndex = 16;
            // 
            // buttonReprintingUnitLabel
            // 
            this.buttonReprintingUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReprintingUnitLabel.AutoSize = true;
            this.buttonReprintingUnitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonReprintingUnitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReprintingUnitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReprintingUnitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReprintingUnitLabel.ForeColor = System.Drawing.Color.White;
            this.buttonReprintingUnitLabel.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.buttonReprintingUnitLabel.IconColor = System.Drawing.Color.White;
            this.buttonReprintingUnitLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReprintingUnitLabel.IconSize = 40;
            this.buttonReprintingUnitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReprintingUnitLabel.Location = new System.Drawing.Point(241, 17);
            this.buttonReprintingUnitLabel.Name = "buttonReprintingUnitLabel";
            this.buttonReprintingUnitLabel.Size = new System.Drawing.Size(286, 57);
            this.buttonReprintingUnitLabel.TabIndex = 13;
            this.buttonReprintingUnitLabel.Text = "Reprint All Unit SN";
            this.buttonReprintingUnitLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonReprintingUnitLabel.UseVisualStyleBackColor = false;
            this.buttonReprintingUnitLabel.Click += new System.EventHandler(this.buttonReprintingUnitLabel_Click);
            // 
            // dataGridUnitPrintingLabel
            // 
            this.dataGridUnitPrintingLabel.AllowUserToAddRows = false;
            this.dataGridUnitPrintingLabel.AutoGenerateColumns = false;
            this.dataGridUnitPrintingLabel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.dataGridUnitPrintingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUnitPrintingLabel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUnitPrintingLabel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUnitPrintingLabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUnitPrintingLabel.ColumnHeadersHeight = 55;
            this.dataGridUnitPrintingLabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitSNDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.PrintUnit});
            this.dataGridUnitPrintingLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridUnitPrintingLabel.DataSource = this.reprintingLabelUnitBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUnitPrintingLabel.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridUnitPrintingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUnitPrintingLabel.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridUnitPrintingLabel.Location = new System.Drawing.Point(20, 150);
            this.dataGridUnitPrintingLabel.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridUnitPrintingLabel.Name = "dataGridUnitPrintingLabel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUnitPrintingLabel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridUnitPrintingLabel.RowHeadersVisible = false;
            this.dataGridUnitPrintingLabel.RowHeadersWidth = 80;
            this.dataGridUnitPrintingLabel.RowTemplate.Height = 60;
            this.dataGridUnitPrintingLabel.Size = new System.Drawing.Size(510, 299);
            this.dataGridUnitPrintingLabel.TabIndex = 21;
            // 
            // dataGridMaterialPrintingLabel
            // 
            this.dataGridMaterialPrintingLabel.AllowUserToAddRows = false;
            this.dataGridMaterialPrintingLabel.AutoGenerateColumns = false;
            this.dataGridMaterialPrintingLabel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.dataGridMaterialPrintingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMaterialPrintingLabel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMaterialPrintingLabel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMaterialPrintingLabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMaterialPrintingLabel.ColumnHeadersHeight = 55;
            this.dataGridMaterialPrintingLabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialSNDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn1,
            this.PrintMaterial});
            this.dataGridMaterialPrintingLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridMaterialPrintingLabel.DataSource = this.reprintingLabelMaterialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMaterialPrintingLabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMaterialPrintingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMaterialPrintingLabel.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridMaterialPrintingLabel.Location = new System.Drawing.Point(570, 150);
            this.dataGridMaterialPrintingLabel.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridMaterialPrintingLabel.Name = "dataGridMaterialPrintingLabel";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMaterialPrintingLabel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMaterialPrintingLabel.RowHeadersVisible = false;
            this.dataGridMaterialPrintingLabel.RowHeadersWidth = 80;
            this.dataGridMaterialPrintingLabel.RowTemplate.Height = 60;
            this.dataGridMaterialPrintingLabel.Size = new System.Drawing.Size(511, 299);
            this.dataGridMaterialPrintingLabel.TabIndex = 20;
            // 
            // PrintUnit
            // 
            this.PrintUnit.HeaderText = "Print";
            this.PrintUnit.MinimumWidth = 6;
            this.PrintUnit.Name = "PrintUnit";
            this.PrintUnit.Text = "Print";
            this.PrintUnit.UseColumnTextForButtonValue = true;
            this.PrintUnit.Width = 125;
            // 
            // PrintMaterial
            // 
            this.PrintMaterial.HeaderText = "Print";
            this.PrintMaterial.MinimumWidth = 6;
            this.PrintMaterial.Name = "PrintMaterial";
            this.PrintMaterial.Width = 125;
            // 
            // materialSNDataGridViewTextBoxColumn
            // 
            this.materialSNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialSNDataGridViewTextBoxColumn.DataPropertyName = "MaterialSN";
            this.materialSNDataGridViewTextBoxColumn.HeaderText = "MaterialSN";
            this.materialSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialSNDataGridViewTextBoxColumn.Name = "materialSNDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn1
            // 
            this.dateStartDataGridViewTextBoxColumn1.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn1.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn1.Name = "dateStartDataGridViewTextBoxColumn1";
            this.dateStartDataGridViewTextBoxColumn1.Width = 200;
            // 
            // reprintingLabelMaterialBindingSource
            // 
            this.reprintingLabelMaterialBindingSource.DataSource = typeof(PCI.KittingApp.Entity.DataGrid.ReprintingLabelMaterial);
            // 
            // unitSNDataGridViewTextBoxColumn
            // 
            this.unitSNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitSNDataGridViewTextBoxColumn.DataPropertyName = "UnitSN";
            this.unitSNDataGridViewTextBoxColumn.HeaderText = "UnitSN";
            this.unitSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitSNDataGridViewTextBoxColumn.Name = "unitSNDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 200;
            // 
            // reprintingLabelUnitBindingSource
            // 
            this.reprintingLabelUnitBindingSource.DataSource = typeof(PCI.KittingApp.Entity.DataGrid.ReprintingLabelUnit);
            // 
            // FormReprintingLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1181, 647);
            this.Controls.Add(this.panelReprintLabel);
            this.Name = "FormReprintingLabel";
            this.Text = "FormReprintingLabel";
            this.panelReprintLabel.ResumeLayout(false);
            this.PanelMfgName.ResumeLayout(false);
            this.PanelMfgName.PerformLayout();
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnitPrintingLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterialPrintingLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprintingLabelMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprintingLabelUnitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelReprintLabel;
        private System.Windows.Forms.Panel PanelMfgName;
        private System.Windows.Forms.TextBox textBoxPrintingContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonReprintingUnitLabel;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonReprintingMaterialLabel;
        private System.Windows.Forms.DataGridView dataGridUnitPrintingLabel;
        private System.Windows.Forms.DataGridView dataGridMaterialPrintingLabel;
        private System.Windows.Forms.BindingSource reprintingLabelUnitBindingSource;
        private System.Windows.Forms.BindingSource reprintingLabelMaterialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn PrintUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn PrintMaterial;
    }
}