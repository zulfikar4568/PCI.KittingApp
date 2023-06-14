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
            this.panelReprintLabel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.textBoxPrintingContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonReprintingMaterialLabel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReprintingUnitLabel = new FontAwesome.Sharp.IconButton();
            this.listUnitLabel = new System.Windows.Forms.ListView();
            this.UnitSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateStartUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMaterialLabel = new System.Windows.Forms.ListView();
            this.MaterialSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateStartMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelReprintLabel.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelReprintLabel.Controls.Add(this.listUnitLabel, 0, 1);
            this.panelReprintLabel.Controls.Add(this.panel1, 0, 2);
            this.panelReprintLabel.Controls.Add(this.panelMfgSubmit, 0, 2);
            this.panelReprintLabel.Controls.Add(this.PanelMfgName, 0, 0);
            this.panelReprintLabel.Controls.Add(this.listMaterialLabel, 1, 1);
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
            this.panelMfgSubmit.Controls.Add(this.buttonReprintingUnitLabel);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(3, 472);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(544, 90);
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
            this.buttonReprintingMaterialLabel.Location = new System.Drawing.Point(251, 17);
            this.buttonReprintingMaterialLabel.Name = "buttonReprintingMaterialLabel";
            this.buttonReprintingMaterialLabel.Size = new System.Drawing.Size(294, 57);
            this.buttonReprintingMaterialLabel.TabIndex = 13;
            this.buttonReprintingMaterialLabel.Text = "Re - Print Material Label";
            this.buttonReprintingMaterialLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonReprintingMaterialLabel.UseVisualStyleBackColor = false;
            this.buttonReprintingMaterialLabel.Click += new System.EventHandler(this.buttonReprintingMaterialLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReprintingMaterialLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(553, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 90);
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
            this.buttonReprintingUnitLabel.Location = new System.Drawing.Point(299, 17);
            this.buttonReprintingUnitLabel.Name = "buttonReprintingUnitLabel";
            this.buttonReprintingUnitLabel.Size = new System.Drawing.Size(242, 57);
            this.buttonReprintingUnitLabel.TabIndex = 13;
            this.buttonReprintingUnitLabel.Text = "Re-Print Unit Label";
            this.buttonReprintingUnitLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonReprintingUnitLabel.UseVisualStyleBackColor = false;
            this.buttonReprintingUnitLabel.Click += new System.EventHandler(this.buttonReprintingUnitLabel_Click);
            // 
            // listUnitLabel
            // 
            this.listUnitLabel.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listUnitLabel.BackColor = System.Drawing.Color.White;
            this.listUnitLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUnitLabel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UnitSN,
            this.DateStartUnit});
            this.listUnitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUnitLabel.Enabled = false;
            this.listUnitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.listUnitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.listUnitLabel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listUnitLabel.HideSelection = false;
            this.listUnitLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listUnitLabel.Location = new System.Drawing.Point(30, 160);
            this.listUnitLabel.Margin = new System.Windows.Forms.Padding(30);
            this.listUnitLabel.Name = "listUnitLabel";
            this.listUnitLabel.Size = new System.Drawing.Size(490, 279);
            this.listUnitLabel.TabIndex = 19;
            this.listUnitLabel.TileSize = new System.Drawing.Size(228, 20);
            this.listUnitLabel.UseCompatibleStateImageBehavior = false;
            this.listUnitLabel.View = System.Windows.Forms.View.Details;
            // 
            // UnitSN
            // 
            this.UnitSN.Text = "Unit SN";
            this.UnitSN.Width = 250;
            // 
            // DateStartUnit
            // 
            this.DateStartUnit.Text = "Date Start";
            this.DateStartUnit.Width = 250;
            // 
            // listMaterialLabel
            // 
            this.listMaterialLabel.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listMaterialLabel.BackColor = System.Drawing.Color.White;
            this.listMaterialLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMaterialLabel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaterialSN,
            this.DateStartMaterial});
            this.listMaterialLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMaterialLabel.Enabled = false;
            this.listMaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.listMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.listMaterialLabel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMaterialLabel.HideSelection = false;
            this.listMaterialLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listMaterialLabel.Location = new System.Drawing.Point(580, 160);
            this.listMaterialLabel.Margin = new System.Windows.Forms.Padding(30);
            this.listMaterialLabel.Name = "listMaterialLabel";
            this.listMaterialLabel.Size = new System.Drawing.Size(491, 279);
            this.listMaterialLabel.TabIndex = 20;
            this.listMaterialLabel.TileSize = new System.Drawing.Size(228, 20);
            this.listMaterialLabel.UseCompatibleStateImageBehavior = false;
            this.listMaterialLabel.View = System.Windows.Forms.View.Details;
            // 
            // MaterialSN
            // 
            this.MaterialSN.Text = "Material SN";
            this.MaterialSN.Width = 250;
            // 
            // DateStartMaterial
            // 
            this.DateStartMaterial.Text = "Date Start";
            this.DateStartMaterial.Width = 250;
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
        private System.Windows.Forms.ListView listUnitLabel;
        private System.Windows.Forms.ColumnHeader UnitSN;
        private System.Windows.Forms.ColumnHeader DateStartUnit;
        private System.Windows.Forms.ListView listMaterialLabel;
        private System.Windows.Forms.ColumnHeader MaterialSN;
        private System.Windows.Forms.ColumnHeader DateStartMaterial;
    }
}