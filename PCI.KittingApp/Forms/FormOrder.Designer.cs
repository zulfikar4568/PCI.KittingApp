namespace PCI.KittingApp.Forms
{
    partial class FormOrder
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
            this.textBoxMfgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMfgProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMfgQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMfgUOM = new System.Windows.Forms.TextBox();
            this.PanelMfgOrder = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.panelMfgProduct = new System.Windows.Forms.Panel();
            this.panelMfgQty = new System.Windows.Forms.Panel();
            this.panelMfgUOM = new System.Windows.Forms.Panel();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonMfgSubmit = new FontAwesome.Sharp.IconButton();
            this.PanelMfgOrder.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panelMfgProduct.SuspendLayout();
            this.panelMfgQty.SuspendLayout();
            this.panelMfgUOM.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMfgName
            // 
            this.textBoxMfgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMfgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxMfgName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMfgName.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMfgName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMfgName.Location = new System.Drawing.Point(17, 65);
            this.textBoxMfgName.Name = "textBoxMfgName";
            this.textBoxMfgName.Size = new System.Drawing.Size(300, 50);
            this.textBoxMfgName.TabIndex = 0;
            this.textBoxMfgName.Leave += new System.EventHandler(this.textBoxMfgName_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mfg Order Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product";
            // 
            // textBoxMfgProduct
            // 
            this.textBoxMfgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMfgProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxMfgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMfgProduct.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMfgProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMfgProduct.Location = new System.Drawing.Point(23, 65);
            this.textBoxMfgProduct.Name = "textBoxMfgProduct";
            this.textBoxMfgProduct.Size = new System.Drawing.Size(300, 50);
            this.textBoxMfgProduct.TabIndex = 2;
            this.textBoxMfgProduct.Leave += new System.EventHandler(this.textBoxMfgProduct_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Qty";
            // 
            // textBoxMfgQty
            // 
            this.textBoxMfgQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMfgQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxMfgQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMfgQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMfgQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMfgQty.Location = new System.Drawing.Point(23, 65);
            this.textBoxMfgQty.Name = "textBoxMfgQty";
            this.textBoxMfgQty.Size = new System.Drawing.Size(300, 50);
            this.textBoxMfgQty.TabIndex = 4;
            this.textBoxMfgQty.Leave += new System.EventHandler(this.textBoxMfgQty_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "UOM";
            // 
            // textBoxMfgUOM
            // 
            this.textBoxMfgUOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMfgUOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxMfgUOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMfgUOM.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxMfgUOM.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxMfgUOM.Location = new System.Drawing.Point(17, 63);
            this.textBoxMfgUOM.Name = "textBoxMfgUOM";
            this.textBoxMfgUOM.Size = new System.Drawing.Size(300, 50);
            this.textBoxMfgUOM.TabIndex = 6;
            this.textBoxMfgUOM.Leave += new System.EventHandler(this.textBoxMfgUOM_Leave);
            // 
            // PanelMfgOrder
            // 
            this.PanelMfgOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMfgOrder.ColumnCount = 3;
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.PanelMfgOrder.Controls.Add(this.PanelMfgName, 0, 0);
            this.PanelMfgOrder.Controls.Add(this.panelMfgProduct, 1, 0);
            this.PanelMfgOrder.Controls.Add(this.panelMfgQty, 2, 0);
            this.PanelMfgOrder.Controls.Add(this.panelMfgUOM, 0, 1);
            this.PanelMfgOrder.Controls.Add(this.panelMfgSubmit, 2, 3);
            this.PanelMfgOrder.Location = new System.Drawing.Point(35, 42);
            this.PanelMfgOrder.Name = "PanelMfgOrder";
            this.PanelMfgOrder.RowCount = 4;
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.PanelMfgOrder.Size = new System.Drawing.Size(1050, 545);
            this.PanelMfgOrder.TabIndex = 8;
            // 
            // PanelMfgName
            // 
            this.PanelMfgName.Controls.Add(this.textBoxMfgName);
            this.PanelMfgName.Controls.Add(this.label1);
            this.PanelMfgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMfgName.Location = new System.Drawing.Point(3, 3);
            this.PanelMfgName.Name = "PanelMfgName";
            this.PanelMfgName.Size = new System.Drawing.Size(340, 130);
            this.PanelMfgName.TabIndex = 9;
            // 
            // panelMfgProduct
            // 
            this.panelMfgProduct.Controls.Add(this.textBoxMfgProduct);
            this.panelMfgProduct.Controls.Add(this.label2);
            this.panelMfgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgProduct.Location = new System.Drawing.Point(349, 3);
            this.panelMfgProduct.Name = "panelMfgProduct";
            this.panelMfgProduct.Size = new System.Drawing.Size(340, 130);
            this.panelMfgProduct.TabIndex = 10;
            // 
            // panelMfgQty
            // 
            this.panelMfgQty.Controls.Add(this.textBoxMfgQty);
            this.panelMfgQty.Controls.Add(this.label3);
            this.panelMfgQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgQty.Location = new System.Drawing.Point(695, 3);
            this.panelMfgQty.Name = "panelMfgQty";
            this.panelMfgQty.Size = new System.Drawing.Size(352, 130);
            this.panelMfgQty.TabIndex = 11;
            // 
            // panelMfgUOM
            // 
            this.panelMfgUOM.Controls.Add(this.textBoxMfgUOM);
            this.panelMfgUOM.Controls.Add(this.label4);
            this.panelMfgUOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgUOM.Location = new System.Drawing.Point(3, 139);
            this.panelMfgUOM.Name = "panelMfgUOM";
            this.panelMfgUOM.Size = new System.Drawing.Size(340, 130);
            this.panelMfgUOM.TabIndex = 12;
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.buttonMfgSubmit);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(695, 465);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(352, 77);
            this.panelMfgSubmit.TabIndex = 14;
            // 
            // buttonMfgSubmit
            // 
            this.buttonMfgSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMfgSubmit.AutoSize = true;
            this.buttonMfgSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonMfgSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMfgSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMfgSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMfgSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonMfgSubmit.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.buttonMfgSubmit.IconColor = System.Drawing.Color.White;
            this.buttonMfgSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMfgSubmit.IconSize = 40;
            this.buttonMfgSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMfgSubmit.Location = new System.Drawing.Point(105, 16);
            this.buttonMfgSubmit.Name = "buttonMfgSubmit";
            this.buttonMfgSubmit.Size = new System.Drawing.Size(179, 46);
            this.buttonMfgSubmit.TabIndex = 13;
            this.buttonMfgSubmit.Text = "Submit";
            this.buttonMfgSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMfgSubmit.UseVisualStyleBackColor = false;
            this.buttonMfgSubmit.Click += new System.EventHandler(this.buttonMfgSubmit_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1129, 631);
            this.Controls.Add(this.PanelMfgOrder);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.PanelMfgOrder.ResumeLayout(false);
            this.PanelMfgName.ResumeLayout(false);
            this.PanelMfgName.PerformLayout();
            this.panelMfgProduct.ResumeLayout(false);
            this.panelMfgProduct.PerformLayout();
            this.panelMfgQty.ResumeLayout(false);
            this.panelMfgQty.PerformLayout();
            this.panelMfgUOM.ResumeLayout(false);
            this.panelMfgUOM.PerformLayout();
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMfgName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMfgProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMfgQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMfgUOM;
        private System.Windows.Forms.TableLayoutPanel PanelMfgOrder;
        private System.Windows.Forms.Panel PanelMfgName;
        private System.Windows.Forms.Panel panelMfgProduct;
        private System.Windows.Forms.Panel panelMfgQty;
        private System.Windows.Forms.Panel panelMfgUOM;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonMfgSubmit;
    }
}