namespace PCI.KittingApp.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMfgOrder = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMfgName = new System.Windows.Forms.Panel();
            this.textBoxUnitContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMfgProduct = new System.Windows.Forms.Panel();
            this.textBoxUnitMfg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMfgSubmit = new System.Windows.Forms.Panel();
            this.buttonReset = new FontAwesome.Sharp.IconButton();
            this.buttonUnitSubmit = new FontAwesome.Sharp.IconButton();
            this.panelListContainer = new System.Windows.Forms.Panel();
            this.dataGridUnitListContainer = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUnitTotalQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUnitQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxUnitBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelMfgOrder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelMfgName.SuspendLayout();
            this.panelMfgProduct.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMfgSubmit.SuspendLayout();
            this.panelListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnitListContainer)).BeginInit();
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
            this.PanelMfgOrder.Location = new System.Drawing.Point(35, 69);
            this.PanelMfgOrder.Name = "PanelMfgOrder";
            this.PanelMfgOrder.RowCount = 2;
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.PanelMfgOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelMfgOrder.Size = new System.Drawing.Size(1050, 545);
            this.PanelMfgOrder.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PanelMfgName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMfgProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 109);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // PanelMfgName
            // 
            this.PanelMfgName.Controls.Add(this.textBoxUnitContainer);
            this.PanelMfgName.Controls.Add(this.label1);
            this.PanelMfgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMfgName.Location = new System.Drawing.Point(525, 3);
            this.PanelMfgName.Name = "PanelMfgName";
            this.PanelMfgName.Size = new System.Drawing.Size(516, 103);
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
            this.textBoxUnitContainer.Location = new System.Drawing.Point(17, 38);
            this.textBoxUnitContainer.Name = "textBoxUnitContainer";
            this.textBoxUnitContainer.Size = new System.Drawing.Size(476, 50);
            this.textBoxUnitContainer.TabIndex = 0;
            this.textBoxUnitContainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUnitContainer_KeyDown);
            this.textBoxUnitContainer.Leave += new System.EventHandler(this.textBoxUnitContainer_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 3);
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
            this.panelMfgProduct.Location = new System.Drawing.Point(3, 3);
            this.panelMfgProduct.Name = "panelMfgProduct";
            this.panelMfgProduct.Size = new System.Drawing.Size(516, 103);
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
            this.textBoxUnitMfg.Location = new System.Drawing.Point(23, 38);
            this.textBoxUnitMfg.Name = "textBoxUnitMfg";
            this.textBoxUnitMfg.Size = new System.Drawing.Size(476, 50);
            this.textBoxUnitMfg.TabIndex = 2;
            this.textBoxUnitMfg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUnitMfg_KeyDown);
            this.textBoxUnitMfg.Leave += new System.EventHandler(this.textBoxUnitMfg_Leave);
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
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelMfgSubmit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelListContainer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1044, 424);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // panelMfgSubmit
            // 
            this.panelMfgSubmit.Controls.Add(this.buttonReset);
            this.panelMfgSubmit.Controls.Add(this.buttonUnitSubmit);
            this.panelMfgSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMfgSubmit.Location = new System.Drawing.Point(524, 344);
            this.panelMfgSubmit.Name = "panelMfgSubmit";
            this.panelMfgSubmit.Size = new System.Drawing.Size(517, 77);
            this.panelMfgSubmit.TabIndex = 14;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.AutoSize = true;
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.buttonReset.IconColor = System.Drawing.Color.White;
            this.buttonReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReset.IconSize = 40;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReset.Location = new System.Drawing.Point(136, 16);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(179, 47);
            this.buttonReset.TabIndex = 102;
            this.buttonReset.Text = "Reset";
            this.buttonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
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
            this.buttonUnitSubmit.Location = new System.Drawing.Point(321, 16);
            this.buttonUnitSubmit.Name = "buttonUnitSubmit";
            this.buttonUnitSubmit.Size = new System.Drawing.Size(179, 47);
            this.buttonUnitSubmit.TabIndex = 13;
            this.buttonUnitSubmit.Text = "Submit";
            this.buttonUnitSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUnitSubmit.UseVisualStyleBackColor = false;
            this.buttonUnitSubmit.Click += new System.EventHandler(this.buttonUnitSubmit_Click);
            // 
            // panelListContainer
            // 
            this.panelListContainer.Controls.Add(this.dataGridUnitListContainer);
            this.panelListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListContainer.Location = new System.Drawing.Point(3, 3);
            this.panelListContainer.Name = "panelListContainer";
            this.panelListContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelListContainer.Size = new System.Drawing.Size(307, 418);
            this.panelListContainer.TabIndex = 15;
            // 
            // dataGridUnitListContainer
            // 
            this.dataGridUnitListContainer.AllowUserToAddRows = false;
            this.dataGridUnitListContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.dataGridUnitListContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUnitListContainer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUnitListContainer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUnitListContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridUnitListContainer.ColumnHeadersHeight = 55;
            this.dataGridUnitListContainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.SN});
            this.dataGridUnitListContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUnitListContainer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridUnitListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUnitListContainer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridUnitListContainer.Location = new System.Drawing.Point(20, 20);
            this.dataGridUnitListContainer.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridUnitListContainer.Name = "dataGridUnitListContainer";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUnitListContainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridUnitListContainer.RowHeadersVisible = false;
            this.dataGridUnitListContainer.RowHeadersWidth = 80;
            this.dataGridUnitListContainer.RowTemplate.Height = 60;
            this.dataGridUnitListContainer.Size = new System.Drawing.Size(267, 378);
            this.dataGridUnitListContainer.TabIndex = 22;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 60;
            // 
            // SN
            // 
            this.SN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SN.HeaderText = "S/N";
            this.SN.MinimumWidth = 6;
            this.SN.Name = "SN";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(316, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(202, 223);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUnitTotalQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 106);
            this.panel1.TabIndex = 1012;
            // 
            // textBoxUnitTotalQty
            // 
            this.textBoxUnitTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitTotalQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxUnitTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitTotalQty.Enabled = false;
            this.textBoxUnitTotalQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitTotalQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUnitTotalQty.Location = new System.Drawing.Point(6, 41);
            this.textBoxUnitTotalQty.Name = "textBoxUnitTotalQty";
            this.textBoxUnitTotalQty.ReadOnly = true;
            this.textBoxUnitTotalQty.Size = new System.Drawing.Size(173, 50);
            this.textBoxUnitTotalQty.TabIndex = 10;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(196, 105);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxUnitQty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 99);
            this.panel2.TabIndex = 1010;
            // 
            // textBoxUnitQty
            // 
            this.textBoxUnitQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxUnitQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitQty.Enabled = false;
            this.textBoxUnitQty.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUnitQty.Location = new System.Drawing.Point(3, 34);
            this.textBoxUnitQty.Name = "textBoxUnitQty";
            this.textBoxUnitQty.ReadOnly = true;
            this.textBoxUnitQty.Size = new System.Drawing.Size(86, 50);
            this.textBoxUnitQty.TabIndex = 10;
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
            this.panel3.Controls.Add(this.textBoxUnitBalance);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(101, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 99);
            this.panel3.TabIndex = 1012;
            // 
            // textBoxUnitBalance
            // 
            this.textBoxUnitBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.textBoxUnitBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUnitBalance.Enabled = false;
            this.textBoxUnitBalance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUnitBalance.Location = new System.Drawing.Point(3, 34);
            this.textBoxUnitBalance.Name = "textBoxUnitBalance";
            this.textBoxUnitBalance.ReadOnly = true;
            this.textBoxUnitBalance.Size = new System.Drawing.Size(75, 50);
            this.textBoxUnitBalance.TabIndex = 10;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelMfgName.ResumeLayout(false);
            this.PanelMfgName.PerformLayout();
            this.panelMfgProduct.ResumeLayout(false);
            this.panelMfgProduct.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelMfgSubmit.ResumeLayout(false);
            this.panelMfgSubmit.PerformLayout();
            this.panelListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnitListContainer)).EndInit();
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
        private System.Windows.Forms.Panel PanelMfgName;
        private System.Windows.Forms.TextBox textBoxUnitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMfgSubmit;
        private FontAwesome.Sharp.IconButton buttonUnitSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelListContainer;
        private System.Windows.Forms.DataGridView dataGridUnitListContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.Panel panelMfgProduct;
        private System.Windows.Forms.TextBox textBoxUnitMfg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUnitTotalQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUnitQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxUnitBalance;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton buttonReset;
    }
}