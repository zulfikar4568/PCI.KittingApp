namespace PCI.KittingApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconStatusConnection = new FontAwesome.Sharp.IconButton();
            this.btnTransactionFailed = new FontAwesome.Sharp.IconButton();
            this.btnMaterialRegistration = new FontAwesome.Sharp.IconButton();
            this.btnUnitRegistration = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.lblCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelVersion = new System.Windows.Forms.LinkLabel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelMenu.Controls.Add(this.btnTransactionFailed);
            this.panelMenu.Controls.Add(this.btnMaterialRegistration);
            this.panelMenu.Controls.Add(this.btnUnitRegistration);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 823);
            this.panelMenu.TabIndex = 0;
            // 
            // iconStatusConnection
            // 
            this.iconStatusConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconStatusConnection.FlatAppearance.BorderSize = 0;
            this.iconStatusConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconStatusConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.iconStatusConnection.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconStatusConnection.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            this.iconStatusConnection.IconColor = System.Drawing.Color.Gainsboro;
            this.iconStatusConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStatusConnection.IconSize = 32;
            this.iconStatusConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconStatusConnection.Location = new System.Drawing.Point(3, 3);
            this.iconStatusConnection.Name = "iconStatusConnection";
            this.iconStatusConnection.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconStatusConnection.Size = new System.Drawing.Size(214, 54);
            this.iconStatusConnection.TabIndex = 5;
            this.iconStatusConnection.Text = "Connected";
            this.iconStatusConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconStatusConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconStatusConnection.UseVisualStyleBackColor = true;
            this.iconStatusConnection.Click += new System.EventHandler(this.iconStatusConnection_Click);
            // 
            // btnTransactionFailed
            // 
            this.btnTransactionFailed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionFailed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionFailed.FlatAppearance.BorderSize = 0;
            this.btnTransactionFailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionFailed.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTransactionFailed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransactionFailed.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark;
            this.btnTransactionFailed.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTransactionFailed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransactionFailed.IconSize = 32;
            this.btnTransactionFailed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionFailed.Location = new System.Drawing.Point(0, 340);
            this.btnTransactionFailed.Name = "btnTransactionFailed";
            this.btnTransactionFailed.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTransactionFailed.Size = new System.Drawing.Size(220, 60);
            this.btnTransactionFailed.TabIndex = 4;
            this.btnTransactionFailed.Text = "Transaction Failed";
            this.btnTransactionFailed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionFailed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionFailed.UseVisualStyleBackColor = true;
            this.btnTransactionFailed.Click += new System.EventHandler(this.btnTransactionFailed_Click);
            // 
            // btnMaterialRegistration
            // 
            this.btnMaterialRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterialRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialRegistration.FlatAppearance.BorderSize = 0;
            this.btnMaterialRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialRegistration.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnMaterialRegistration.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaterialRegistration.IconChar = FontAwesome.Sharp.IconChar.Megaport;
            this.btnMaterialRegistration.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaterialRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialRegistration.IconSize = 32;
            this.btnMaterialRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterialRegistration.Location = new System.Drawing.Point(0, 280);
            this.btnMaterialRegistration.Name = "btnMaterialRegistration";
            this.btnMaterialRegistration.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMaterialRegistration.Size = new System.Drawing.Size(220, 60);
            this.btnMaterialRegistration.TabIndex = 3;
            this.btnMaterialRegistration.Text = "Material Registration";
            this.btnMaterialRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterialRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterialRegistration.UseVisualStyleBackColor = true;
            this.btnMaterialRegistration.Click += new System.EventHandler(this.btnMaterialRegistration_Click);
            // 
            // btnUnitRegistration
            // 
            this.btnUnitRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnitRegistration.FlatAppearance.BorderSize = 0;
            this.btnUnitRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitRegistration.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUnitRegistration.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUnitRegistration.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.btnUnitRegistration.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUnitRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUnitRegistration.IconSize = 32;
            this.btnUnitRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnitRegistration.Location = new System.Drawing.Point(0, 220);
            this.btnUnitRegistration.Name = "btnUnitRegistration";
            this.btnUnitRegistration.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUnitRegistration.Size = new System.Drawing.Size(220, 60);
            this.btnUnitRegistration.TabIndex = 2;
            this.btnUnitRegistration.Text = "Unit Registration";
            this.btnUnitRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnitRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnitRegistration.UseVisualStyleBackColor = true;
            this.btnUnitRegistration.Click += new System.EventHandler(this.btnUnitRegistration_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 32;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 160);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 60);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Mfg Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 160);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::PCI.KittingApp.Properties.Resources.logoPCI1;
            this.btnHome.Location = new System.Drawing.Point(25, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 91);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1132, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTItleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1103, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1077, 11);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1051, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblCurrentChildForm
            // 
            this.lblCurrentChildForm.AutoSize = true;
            this.lblCurrentChildForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCurrentChildForm.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentChildForm.Location = new System.Drawing.Point(60, 32);
            this.lblCurrentChildForm.Name = "lblCurrentChildForm";
            this.lblCurrentChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblCurrentChildForm.TabIndex = 1;
            this.lblCurrentChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Coral;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Coral;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1132, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1132, 734);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PCI.KittingApp.Properties.Resources.Ilustration;
            this.pictureBox1.Location = new System.Drawing.Point(198, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconStatusConnection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 721);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 102);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelVersion
            // 
            this.labelVersion.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 5F);
            this.labelVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVersion.LinkColor = System.Drawing.Color.Gainsboro;
            this.labelVersion.Location = new System.Drawing.Point(3, 60);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(214, 42);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.TabStop = true;
            this.labelVersion.Text = "version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVersion.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.labelVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelVersion_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 823);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnMaterialRegistration;
        private FontAwesome.Sharp.IconButton btnUnitRegistration;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnTransactionFailed;
        private FontAwesome.Sharp.IconButton iconStatusConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel labelVersion;
    }
}

