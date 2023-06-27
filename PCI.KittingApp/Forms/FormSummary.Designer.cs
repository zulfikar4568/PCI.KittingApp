namespace PCI.KittingApp.Forms
{
    partial class FormSummary
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
            this.PanelMfgOrder = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.panelMfgProduct = new System.Windows.Forms.Panel();
            this.textBoxMfg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.dataGridListContainer = new System.Windows.Forms.DataGrid();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTotalQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelMfgOrder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panelMfgProduct.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListContainer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMfgOrder
            // 
            this.PanelMfgOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMfgOrder.ColumnCount = 1;
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelMfgOrder.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.PanelMfgOrder.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.PanelMfgOrder.Location = new System.Drawing.Point(12, 12);
            this.PanelMfgOrder.Name = "PanelMfgOrder";
            this.PanelMfgOrder.RowCount = 2;
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelMfgOrder.Size = new System.Drawing.Size(1312, 723);
            this.PanelMfgOrder.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.Controls.Add(this.panelMfgSubmit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMfgProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 109);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.pictureBoxLoading);
            this.panelMfgSubmit.Controls.Add(this.buttonSearch);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(1061, 3);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(242, 103);
            this.panelMfgSubmit.TabIndex = 15;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::PCI.KittingApp.Properties.Resources.loading_ring;
            this.pictureBoxLoading.Location = new System.Drawing.Point(13, 38);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 14;
            this.pictureBoxLoading.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buttonSearch.IconColor = System.Drawing.Color.White;
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.IconSize = 40;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.Location = new System.Drawing.Point(76, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(146, 50);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelMfgProduct
            // 
            this.panelMfgProduct.Controls.Add(this.textBoxMfg);
            this.panelMfgProduct.Controls.Add(this.label2);
            this.panelMfgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgProduct.Location = new System.Drawing.Point(3, 3);
            this.panelMfgProduct.Name = "panelMfgProduct";
            this.panelMfgProduct.Size = new System.Drawing.Size(1052, 103);
            this.panelMfgProduct.TabIndex = 11;
            // 
            // textBoxMfg
            // 
            this.textBoxMfg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxMfg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMfg.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMfg.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMfg.Location = new System.Drawing.Point(23, 38);
            this.textBoxMfg.Name = "textBoxMfg";
            this.textBoxMfg.Size = new System.Drawing.Size(1012, 50);
            this.textBoxMfg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(19, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mfg Order Name";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panelListContainer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1306, 602);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // panelListContainer
            // 
            this.panelListContainer.Controls.Add(this.dataGridListContainer);
            this.panelListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListContainer.Location = new System.Drawing.Point(3, 3);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelListContainer.Size = new System.Drawing.Size(973, 596);
            this.panelListContainer.TabIndex = 15;
            // 
            // dataGridListContainer
            // 
            this.dataGridListContainer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridListContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridListContainer.CaptionBackColor = System.Drawing.Color.White;
            this.dataGridListContainer.CaptionFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridListContainer.DataMember = "";
            this.dataGridListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridListContainer.FlatMode = true;
            this.dataGridListContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridListContainer.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridListContainer.Location = new System.Drawing.Point(20, 20);
            this.dataGridListContainer.Name = "dataGridListContainer";
            this.dataGridListContainer.PreferredColumnWidth = 300;
            this.dataGridListContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridListContainer.Size = new System.Drawing.Size(933, 556);
            this.dataGridListContainer.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(982, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 223);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTotalQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 106);
            this.panel1.TabIndex = 1012;
            // 
            // textBoxTotalQty
            // 
            this.textBoxTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalQty.Enabled = false;
            this.textBoxTotalQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxTotalQty.Location = new System.Drawing.Point(6, 41);
            this.textBoxTotalQty.Name = "textBoxTotalQty";
            this.textBoxTotalQty.ReadOnly = true;
            this.textBoxTotalQty.Size = new System.Drawing.Size(292, 50);
            this.textBoxTotalQty.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kitting Qty";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(315, 105);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxQty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 99);
            this.panel2.TabIndex = 1010;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQty.Enabled = false;
            this.textBoxQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxQty.Location = new System.Drawing.Point(3, 34);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.ReadOnly = true;
            this.textBoxQty.Size = new System.Drawing.Size(145, 50);
            this.textBoxQty.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "PO Qty";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxBalance);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(160, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 99);
            this.panel3.TabIndex = 1012;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxBalance.Location = new System.Drawing.Point(3, 34);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(135, 50);
            this.textBoxBalance.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Balance";
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1336, 747);
            this.Controls.Add(this.PanelMfgOrder);
            this.Name = "FormSummary";
            this.Text = "FormSummary";
            this.Load += new System.EventHandler(this.FormSummary_Load);
            this.PanelMfgOrder.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panelMfgProduct.ResumeLayout(false);
            this.panelMfgProduct.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListContainer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelMfgOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTotalQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGrid dataGridListContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMfgProduct;
        private System.Windows.Forms.TextBox textBoxMfg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
    }
}