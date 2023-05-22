namespace PCI.KittingApp.Forms
{
    partial class FormMaterialRegistration
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
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonRegisterSubmit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMaterialRegister = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRegisterSN = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxRegisterBatchID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxRegisterPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewMaterial = new System.Windows.Forms.ListView();
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.textBoxRegisterContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxRegisterERPBOM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxRegisterProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMfgOrder.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMfgOrder
            // 
            this.PanelMfgOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMfgOrder.ColumnCount = 2;
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.PanelMfgOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.PanelMfgOrder.Controls.Add(this.panelMfgSubmit, 1, 3);
            this.PanelMfgOrder.Controls.Add(this.panel1, 1, 2);
            this.PanelMfgOrder.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.PanelMfgOrder.Controls.Add(this.listViewMaterial, 0, 1);
            this.PanelMfgOrder.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.PanelMfgOrder.Location = new System.Drawing.Point(30, 26);
            this.PanelMfgOrder.Name = "PanelMfgOrder";
            this.PanelMfgOrder.RowCount = 4;
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.PanelMfgOrder.Size = new System.Drawing.Size(1133, 731);
            this.PanelMfgOrder.TabIndex = 10;
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.buttonRegisterSubmit);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMfgSubmit.Location = new System.Drawing.Point(711, 655);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(419, 73);
            this.panelMfgSubmit.TabIndex = 4;
            // 
            // buttonRegisterSubmit
            // 
            this.buttonRegisterSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegisterSubmit.AutoSize = true;
            this.buttonRegisterSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(222)))));
            this.buttonRegisterSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegisterSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRegisterSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonRegisterSubmit.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            this.buttonRegisterSubmit.IconColor = System.Drawing.Color.White;
            this.buttonRegisterSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRegisterSubmit.IconSize = 40;
            this.buttonRegisterSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisterSubmit.Location = new System.Drawing.Point(171, 13);
            this.buttonRegisterSubmit.Name = "buttonRegisterSubmit";
            this.buttonRegisterSubmit.Size = new System.Drawing.Size(179, 46);
            this.buttonRegisterSubmit.TabIndex = 5;
            this.buttonRegisterSubmit.Text = "Submit";
            this.buttonRegisterSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRegisterSubmit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMaterialRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(711, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 56);
            this.panel1.TabIndex = 3;
            // 
            // buttonMaterialRegister
            // 
            this.buttonMaterialRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaterialRegister.AutoSize = true;
            this.buttonMaterialRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(71)))), ((int)(((byte)(204)))));
            this.buttonMaterialRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaterialRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaterialRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMaterialRegister.ForeColor = System.Drawing.Color.White;
            this.buttonMaterialRegister.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.buttonMaterialRegister.IconColor = System.Drawing.Color.White;
            this.buttonMaterialRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMaterialRegister.IconSize = 40;
            this.buttonMaterialRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMaterialRegister.Location = new System.Drawing.Point(171, 7);
            this.buttonMaterialRegister.Name = "buttonMaterialRegister";
            this.buttonMaterialRegister.Size = new System.Drawing.Size(179, 46);
            this.buttonMaterialRegister.TabIndex = 4;
            this.buttonMaterialRegister.Text = "Register";
            this.buttonMaterialRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMaterialRegister.UseVisualStyleBackColor = false;
            this.buttonMaterialRegister.Click += new System.EventHandler(this.buttonMaterialRegister_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(711, 222);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 365);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBoxRegisterSN);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 115);
            this.panel6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "* Scan Component Serial Number";
            // 
            // textBoxRegisterSN
            // 
            this.textBoxRegisterSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxRegisterSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterSN.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterSN.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterSN.Location = new System.Drawing.Point(17, 46);
            this.textBoxRegisterSN.Name = "textBoxRegisterSN";
            this.textBoxRegisterSN.Size = new System.Drawing.Size(373, 50);
            this.textBoxRegisterSN.TabIndex = 2;
            this.textBoxRegisterSN.Leave += new System.EventHandler(this.textBoxRegisterSN_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxRegisterBatchID);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 245);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 117);
            this.panel5.TabIndex = 2;
            // 
            // textBoxRegisterBatchID
            // 
            this.textBoxRegisterBatchID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterBatchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxRegisterBatchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterBatchID.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterBatchID.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterBatchID.Location = new System.Drawing.Point(17, 48);
            this.textBoxRegisterBatchID.Name = "textBoxRegisterBatchID";
            this.textBoxRegisterBatchID.Size = new System.Drawing.Size(373, 50);
            this.textBoxRegisterBatchID.TabIndex = 3;
            this.textBoxRegisterBatchID.Leave += new System.EventHandler(this.textBoxRegisterBatchID_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Scan Batch ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxRegisterPN);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 115);
            this.panel4.TabIndex = 1;
            // 
            // textBoxRegisterPN
            // 
            this.textBoxRegisterPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxRegisterPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterPN.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterPN.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterPN.Location = new System.Drawing.Point(17, 63);
            this.textBoxRegisterPN.Name = "textBoxRegisterPN";
            this.textBoxRegisterPN.Size = new System.Drawing.Size(373, 50);
            this.textBoxRegisterPN.TabIndex = 1;
            this.textBoxRegisterPN.Leave += new System.EventHandler(this.textBoxRegisterPN_Leave);
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
            this.label4.Size = new System.Drawing.Size(315, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "* Scan Component Part Number";
            // 
            // listViewMaterial
            // 
            this.listViewMaterial.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewMaterial.BackColor = System.Drawing.Color.White;
            this.listViewMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMaterial.CheckBoxes = true;
            this.listViewMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Material,
            this.Description});
            this.listViewMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMaterial.Enabled = false;
            this.listViewMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.listViewMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.listViewMaterial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMaterial.HideSelection = false;
            this.listViewMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewMaterial.Location = new System.Drawing.Point(30, 249);
            this.listViewMaterial.Margin = new System.Windows.Forms.Padding(30);
            this.listViewMaterial.Name = "listViewMaterial";
            this.listViewMaterial.Size = new System.Drawing.Size(648, 311);
            this.listViewMaterial.TabIndex = 18;
            this.listViewMaterial.TileSize = new System.Drawing.Size(228, 20);
            this.listViewMaterial.UseCompatibleStateImageBehavior = false;
            this.listViewMaterial.View = System.Windows.Forms.View.Details;
            // 
            // Material
            // 
            this.Material.Text = "Material";
            this.Material.Width = 150;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 500;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PanelMfgName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 208);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(687, 98);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // PanelMfgName
            // 
            this.PanelMfgName.Controls.Add(this.textBoxRegisterContainer);
            this.PanelMfgName.Controls.Add(this.label1);
            this.PanelMfgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMfgName.Location = new System.Drawing.Point(3, 3);
            this.PanelMfgName.Name = "PanelMfgName";
            this.PanelMfgName.Size = new System.Drawing.Size(687, 98);
            this.PanelMfgName.TabIndex = 1;
            // 
            // textBoxRegisterContainer
            // 
            this.textBoxRegisterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.textBoxRegisterContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterContainer.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterContainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterContainer.Location = new System.Drawing.Point(17, 33);
            this.textBoxRegisterContainer.Name = "textBoxRegisterContainer";
            this.textBoxRegisterContainer.Size = new System.Drawing.Size(649, 50);
            this.textBoxRegisterContainer.TabIndex = 0;
            this.textBoxRegisterContainer.Leave += new System.EventHandler(this.textBoxRegisterContainer_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Scan Customer SN Console";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxRegisterERPBOM);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 92);
            this.panel2.TabIndex = 11;
            // 
            // textBoxRegisterERPBOM
            // 
            this.textBoxRegisterERPBOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterERPBOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxRegisterERPBOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterERPBOM.Enabled = false;
            this.textBoxRegisterERPBOM.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterERPBOM.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterERPBOM.Location = new System.Drawing.Point(17, 27);
            this.textBoxRegisterERPBOM.Name = "textBoxRegisterERPBOM";
            this.textBoxRegisterERPBOM.ReadOnly = true;
            this.textBoxRegisterERPBOM.Size = new System.Drawing.Size(297, 50);
            this.textBoxRegisterERPBOM.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ERP BOM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxRegisterProduct);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(346, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 92);
            this.panel3.TabIndex = 12;
            // 
            // textBoxRegisterProduct
            // 
            this.textBoxRegisterProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegisterProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxRegisterProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegisterProduct.Enabled = false;
            this.textBoxRegisterProduct.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegisterProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRegisterProduct.Location = new System.Drawing.Point(17, 27);
            this.textBoxRegisterProduct.Name = "textBoxRegisterProduct";
            this.textBoxRegisterProduct.ReadOnly = true;
            this.textBoxRegisterProduct.Size = new System.Drawing.Size(298, 50);
            this.textBoxRegisterProduct.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product";
            // 
            // FormMaterialRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1193, 782);
            this.Controls.Add(this.PanelMfgOrder);
            this.Name = "FormMaterialRegistration";
            this.Text = "FormMaterialRegistration";
            this.PanelMfgOrder.ResumeLayout(false);
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.PanelMfgName.ResumeLayout(false);
            this.PanelMfgName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelMfgOrder;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonRegisterSubmit;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonMaterialRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxRegisterBatchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxRegisterSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxRegisterPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewMaterial;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelMfgName;
        private System.Windows.Forms.TextBox textBoxRegisterContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxRegisterProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxRegisterERPBOM;
        private System.Windows.Forms.Label label2;
    }
}