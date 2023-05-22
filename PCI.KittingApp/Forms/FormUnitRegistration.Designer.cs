﻿namespace PCI.KittingApp.Forms
{
    partial class FormUnitRegistration
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
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.textBoxUnitContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMfgProduct = new System.Windows.Forms.Panel();
            this.textBoxUnitMfg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonUnitSubmit = new FontAwesome.Sharp.IconButton();
            this.PanelMfgOrder.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panelMfgProduct.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelMfgOrder.Controls.Add(this.panelMfgSubmit, 2, 3);
            this.PanelMfgOrder.Location = new System.Drawing.Point(35, 69);
            this.PanelMfgOrder.Name = "PanelMfgOrder";
            this.PanelMfgOrder.RowCount = 4;
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.PanelMfgOrder.Size = new System.Drawing.Size(1050, 545);
            this.PanelMfgOrder.TabIndex = 9;
            // 
            // PanelMfgName
            // 
            this.PanelMfgName.Controls.Add(this.textBoxUnitContainer);
            this.PanelMfgName.Controls.Add(this.label1);
            this.PanelMfgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMfgName.Location = new System.Drawing.Point(3, 3);
            this.PanelMfgName.Name = "PanelMfgName";
            this.PanelMfgName.Size = new System.Drawing.Size(340, 130);
            this.PanelMfgName.TabIndex = 9;
            // 
            // textBoxUnitContainer
            // 
            this.textBoxUnitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxUnitContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitContainer.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitContainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUnitContainer.Location = new System.Drawing.Point(17, 65);
            this.textBoxUnitContainer.Name = "textBoxUnitContainer";
            this.textBoxUnitContainer.Size = new System.Drawing.Size(300, 50);
            this.textBoxUnitContainer.TabIndex = 0;
            this.textBoxUnitContainer.Leave += new System.EventHandler(this.textBoxUnitContainer_Leave);
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
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Container / Identifier";
            // 
            // panelMfgProduct
            // 
            this.panelMfgProduct.Controls.Add(this.textBoxUnitMfg);
            this.panelMfgProduct.Controls.Add(this.label2);
            this.panelMfgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgProduct.Location = new System.Drawing.Point(349, 3);
            this.panelMfgProduct.Name = "panelMfgProduct";
            this.panelMfgProduct.Size = new System.Drawing.Size(340, 130);
            this.panelMfgProduct.TabIndex = 10;
            // 
            // textBoxUnitMfg
            // 
            this.textBoxUnitMfg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitMfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxUnitMfg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitMfg.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBoxUnitMfg.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUnitMfg.Location = new System.Drawing.Point(23, 65);
            this.textBoxUnitMfg.Name = "textBoxUnitMfg";
            this.textBoxUnitMfg.Size = new System.Drawing.Size(300, 50);
            this.textBoxUnitMfg.TabIndex = 2;
            this.textBoxUnitMfg.Leave += new System.EventHandler(this.textBoxUnitMfg_Leave);
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
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mfg Order";
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.buttonUnitSubmit);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(695, 465);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(352, 77);
            this.panelMfgSubmit.TabIndex = 14;
            // 
            // buttonUnitSubmit
            // 
            this.buttonUnitSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnitSubmit.AutoSize = true;
            this.buttonUnitSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonUnitSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnitSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnitSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUnitSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonUnitSubmit.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.buttonUnitSubmit.IconColor = System.Drawing.Color.White;
            this.buttonUnitSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUnitSubmit.IconSize = 40;
            this.buttonUnitSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnitSubmit.Location = new System.Drawing.Point(105, 16);
            this.buttonUnitSubmit.Name = "buttonUnitSubmit";
            this.buttonUnitSubmit.Size = new System.Drawing.Size(179, 46);
            this.buttonUnitSubmit.TabIndex = 13;
            this.buttonUnitSubmit.Text = "Submit";
            this.buttonUnitSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUnitSubmit.UseVisualStyleBackColor = false;
            this.buttonUnitSubmit.Click += new System.EventHandler(this.buttonUnitSubmit_Click);
            // 
            // FormUnitRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1120, 682);
            this.Controls.Add(this.PanelMfgOrder);
            this.Name = "FormUnitRegistration";
            this.Text = "FormUnitRegistration";
            this.PanelMfgOrder.ResumeLayout(false);
            this.PanelMfgName.ResumeLayout(false);
            this.PanelMfgName.PerformLayout();
            this.panelMfgProduct.ResumeLayout(false);
            this.panelMfgProduct.PerformLayout();
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelMfgOrder;
        private System.Windows.Forms.Panel PanelMfgName;
        private System.Windows.Forms.TextBox textBoxUnitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMfgProduct;
        private System.Windows.Forms.TextBox textBoxUnitMfg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonUnitSubmit;
    }
}