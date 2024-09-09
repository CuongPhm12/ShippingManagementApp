
namespace ShippingManagementApp
{
    partial class frm_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelAddPage1 = new System.Windows.Forms.Panel();
            this.gbReceiverPorfile = new System.Windows.Forms.GroupBox();
            this.lbReceiverID = new System.Windows.Forms.Label();
            this.panelReceiver = new System.Windows.Forms.Panel();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.lbReceiver = new System.Windows.Forms.Label();
            this.panelReceiverName = new System.Windows.Forms.Panel();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.panelMobileReceiver = new System.Windows.Forms.Panel();
            this.txtMobileReceiver = new System.Windows.Forms.TextBox();
            this.panelReceiverID = new System.Windows.Forms.Panel();
            this.cbReceiverID = new System.Windows.Forms.ComboBox();
            this.lbReceiverAddress = new System.Windows.Forms.Label();
            this.lbReceiverName = new System.Windows.Forms.Label();
            this.panelReceiverAddress = new System.Windows.Forms.Panel();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.lbMobileReceiver = new System.Windows.Forms.Label();
            this.gbSenderPorfile = new System.Windows.Forms.GroupBox();
            this.lbSenderID = new System.Windows.Forms.Label();
            this.panelSender = new System.Windows.Forms.Panel();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.lbSender = new System.Windows.Forms.Label();
            this.panelSenderName = new System.Windows.Forms.Panel();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.panelMobileSender = new System.Windows.Forms.Panel();
            this.txtMobileSender = new System.Windows.Forms.TextBox();
            this.panelSenderID = new System.Windows.Forms.Panel();
            this.cbSenderID = new System.Windows.Forms.ComboBox();
            this.lbSenderAddress = new System.Windows.Forms.Label();
            this.lbSenderName = new System.Windows.Forms.Label();
            this.panelSenderAddress = new System.Windows.Forms.Panel();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.lbMobileSender = new System.Windows.Forms.Label();
            this.panelAddPage2 = new System.Windows.Forms.Panel();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.panelTotalCost = new System.Windows.Forms.Panel();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gbOrderCost = new System.Windows.Forms.GroupBox();
            this.lbAdministrativeCosts = new System.Windows.Forms.Label();
            this.panelAdministrativeCosts = new System.Windows.Forms.Panel();
            this.txtAdministrativeCosts = new System.Windows.Forms.TextBox();
            this.lbServiceCosts = new System.Windows.Forms.Label();
            this.lbShippingCosts = new System.Windows.Forms.Label();
            this.panelShippingCosts = new System.Windows.Forms.Panel();
            this.txtShippingCosts = new System.Windows.Forms.TextBox();
            this.panelServiceCosts = new System.Windows.Forms.Panel();
            this.txtServiceCosts = new System.Windows.Forms.TextBox();
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.gbOrderInformation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelPaymentType = new System.Windows.Forms.Label();
            this.rbDestination = new System.Windows.Forms.RadioButton();
            this.rbOrigin = new System.Windows.Forms.RadioButton();
            this.panelPostType = new System.Windows.Forms.Panel();
            this.cbPostType = new System.Windows.Forms.ComboBox();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbPackageType = new System.Windows.Forms.Label();
            this.panelPackageType = new System.Windows.Forms.Panel();
            this.cbPackageType = new System.Windows.Forms.ComboBox();
            this.lbPostType = new System.Windows.Forms.Label();
            this.panelWeight = new System.Windows.Forms.Panel();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.numUDNumber = new System.Windows.Forms.NumericUpDown();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelPaymentStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbPaymentStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.panelOrderDate = new System.Windows.Forms.Panel();
            this.panelBirthDate = new System.Windows.Forms.Label();
            this.dateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOrderID = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.tlpPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelAddPage1.SuspendLayout();
            this.gbReceiverPorfile.SuspendLayout();
            this.panelReceiver.SuspendLayout();
            this.panelReceiverName.SuspendLayout();
            this.panelMobileReceiver.SuspendLayout();
            this.panelReceiverID.SuspendLayout();
            this.panelReceiverAddress.SuspendLayout();
            this.gbSenderPorfile.SuspendLayout();
            this.panelSender.SuspendLayout();
            this.panelSenderName.SuspendLayout();
            this.panelMobileSender.SuspendLayout();
            this.panelSenderID.SuspendLayout();
            this.panelSenderAddress.SuspendLayout();
            this.panelAddPage2.SuspendLayout();
            this.panelTotalCost.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.gbOrderCost.SuspendLayout();
            this.panelAdministrativeCosts.SuspendLayout();
            this.panelShippingCosts.SuspendLayout();
            this.panelServiceCosts.SuspendLayout();
            this.panelDiscount.SuspendLayout();
            this.gbOrderInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelPostType.SuspendLayout();
            this.panelPackageType.SuspendLayout();
            this.panelWeight.SuspendLayout();
            this.panelNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelOrderDate.SuspendLayout();
            this.panelCondition.SuspendLayout();
            this.panelOrderID.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPanelTop
            // 
            this.tlpPanelTop.BackColor = System.Drawing.Color.White;
            this.tlpPanelTop.ColumnCount = 7;
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPanelTop.Controls.Add(this.btnPrint, 4, 0);
            this.tlpPanelTop.Controls.Add(this.btnRefresh, 3, 0);
            this.tlpPanelTop.Controls.Add(this.btnDelete, 2, 0);
            this.tlpPanelTop.Controls.Add(this.btnEdit, 1, 0);
            this.tlpPanelTop.Controls.Add(this.btnAdd, 0, 0);
            this.tlpPanelTop.Controls.Add(this.txtSearch, 1, 1);
            this.tlpPanelTop.Controls.Add(this.pictureBox1, 6, 1);
            this.tlpPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tlpPanelTop.Name = "tlpPanelTop";
            this.tlpPanelTop.RowCount = 2;
            this.tlpPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPanelTop.Size = new System.Drawing.Size(944, 100);
            this.tlpPanelTop.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::ShippingManagementApp.Properties.Resources.Print_white;
            this.btnPrint.Location = new System.Drawing.Point(363, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 54);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ShippingManagementApp.Properties.Resources.Reboot_white;
            this.btnRefresh.Location = new System.Drawing.Point(273, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 54);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ShippingManagementApp.Properties.Resources.Delete_User_Male_white;
            this.btnDelete.Location = new System.Drawing.Point(183, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ShippingManagementApp.Properties.Resources.Edit_User_white;
            this.btnEdit.Location = new System.Drawing.Point(93, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 54);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ShippingManagementApp.Properties.Resources.Add_User_Male_white;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.tlpPanelTop.SetColumnSpan(this.txtSearch, 5);
            this.txtSearch.Location = new System.Drawing.Point(90, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(764, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShippingManagementApp.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(854, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Prev.png");
            this.imageList.Images.SetKeyName(1, "Next page.png");
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.ColumnHeadersHeight = 45;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDate,
            this.Sender,
            this.Receiver,
            this.Weight,
            this.Number,
            this.PostType,
            this.PackageType,
            this.PaymentType,
            this.TotalCost,
            this.Description});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Location = new System.Drawing.Point(3, 103);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 40;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(47)))));
            this.dgvOrder.RowTemplate.DividerHeight = 2;
            this.dgvOrder.RowTemplate.Height = 30;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(944, 10);
            this.dgvOrder.TabIndex = 6;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderID";
            this.OrderId.HeaderText = "Id";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 60;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // Sender
            // 
            this.Sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.DataPropertyName = "Receiver";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Receiver.DefaultCellStyle = dataGridViewCellStyle4;
            this.Receiver.HeaderText = "Receiver";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            this.Receiver.Width = 110;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // PostType
            // 
            this.PostType.DataPropertyName = "PostType";
            this.PostType.HeaderText = "Post Type";
            this.PostType.Name = "PostType";
            this.PostType.ReadOnly = true;
            this.PostType.Width = 150;
            // 
            // PackageType
            // 
            this.PackageType.DataPropertyName = "PackageType";
            this.PackageType.HeaderText = "Package Type";
            this.PackageType.Name = "PackageType";
            this.PackageType.ReadOnly = true;
            this.PackageType.Width = 150;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            this.PaymentType.Width = 150;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 120;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Controls.Add(this.panelAddPage1);
            this.panelAdd.Controls.Add(this.panelAddPage2);
            this.panelAdd.Controls.Add(this.panel1);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(3, 113);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(944, 637);
            this.panelAdd.TabIndex = 7;
            // 
            // panelAddPage1
            // 
            this.panelAddPage1.Controls.Add(this.gbReceiverPorfile);
            this.panelAddPage1.Controls.Add(this.gbSenderPorfile);
            this.panelAddPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddPage1.ForeColor = System.Drawing.Color.Black;
            this.panelAddPage1.Location = new System.Drawing.Point(0, 143);
            this.panelAddPage1.Name = "panelAddPage1";
            this.panelAddPage1.Size = new System.Drawing.Size(0, 494);
            this.panelAddPage1.TabIndex = 21;
            // 
            // gbReceiverPorfile
            // 
            this.gbReceiverPorfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbReceiverPorfile.BackColor = System.Drawing.Color.White;
            this.gbReceiverPorfile.Controls.Add(this.lbReceiverID);
            this.gbReceiverPorfile.Controls.Add(this.panelReceiver);
            this.gbReceiverPorfile.Controls.Add(this.lbReceiver);
            this.gbReceiverPorfile.Controls.Add(this.panelReceiverName);
            this.gbReceiverPorfile.Controls.Add(this.panelMobileReceiver);
            this.gbReceiverPorfile.Controls.Add(this.panelReceiverID);
            this.gbReceiverPorfile.Controls.Add(this.lbReceiverAddress);
            this.gbReceiverPorfile.Controls.Add(this.lbReceiverName);
            this.gbReceiverPorfile.Controls.Add(this.panelReceiverAddress);
            this.gbReceiverPorfile.Controls.Add(this.lbMobileReceiver);
            this.gbReceiverPorfile.ForeColor = System.Drawing.Color.Black;
            this.gbReceiverPorfile.Location = new System.Drawing.Point(-460, 254);
            this.gbReceiverPorfile.Name = "gbReceiverPorfile";
            this.gbReceiverPorfile.Size = new System.Drawing.Size(919, 239);
            this.gbReceiverPorfile.TabIndex = 50;
            this.gbReceiverPorfile.TabStop = false;
            this.gbReceiverPorfile.Text = "Receiver Porfile";
            // 
            // lbReceiverID
            // 
            this.lbReceiverID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceiverID.AutoSize = true;
            this.lbReceiverID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiverID.Location = new System.Drawing.Point(70, 38);
            this.lbReceiverID.Name = "lbReceiverID";
            this.lbReceiverID.Size = new System.Drawing.Size(96, 20);
            this.lbReceiverID.TabIndex = 45;
            this.lbReceiverID.Text = "Receiver ID";
            // 
            // panelReceiver
            // 
            this.panelReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReceiver.BackColor = System.Drawing.Color.Gainsboro;
            this.panelReceiver.Controls.Add(this.txtReceiver);
            this.panelReceiver.Location = new System.Drawing.Point(176, 78);
            this.panelReceiver.Margin = new System.Windows.Forms.Padding(0);
            this.panelReceiver.Name = "panelReceiver";
            this.panelReceiver.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelReceiver.Size = new System.Drawing.Size(292, 30);
            this.panelReceiver.TabIndex = 35;
            // 
            // txtReceiver
            // 
            this.txtReceiver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiver.Location = new System.Drawing.Point(0, 0);
            this.txtReceiver.Multiline = true;
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(292, 27);
            this.txtReceiver.TabIndex = 0;
            // 
            // lbReceiver
            // 
            this.lbReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiver.Location = new System.Drawing.Point(90, 83);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(76, 20);
            this.lbReceiver.TabIndex = 44;
            this.lbReceiver.Text = "Receiver";
            // 
            // panelReceiverName
            // 
            this.panelReceiverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReceiverName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelReceiverName.Controls.Add(this.txtReceiverName);
            this.panelReceiverName.Location = new System.Drawing.Point(702, 78);
            this.panelReceiverName.Margin = new System.Windows.Forms.Padding(0);
            this.panelReceiverName.Name = "panelReceiverName";
            this.panelReceiverName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelReceiverName.Size = new System.Drawing.Size(139, 30);
            this.panelReceiverName.TabIndex = 36;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceiverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiverName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiverName.Location = new System.Drawing.Point(0, 0);
            this.txtReceiverName.Multiline = true;
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(139, 27);
            this.txtReceiverName.TabIndex = 0;
            // 
            // panelMobileReceiver
            // 
            this.panelMobileReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMobileReceiver.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMobileReceiver.Controls.Add(this.txtMobileReceiver);
            this.panelMobileReceiver.Location = new System.Drawing.Point(686, 33);
            this.panelMobileReceiver.Margin = new System.Windows.Forms.Padding(0);
            this.panelMobileReceiver.Name = "panelMobileReceiver";
            this.panelMobileReceiver.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelMobileReceiver.Size = new System.Drawing.Size(155, 30);
            this.panelMobileReceiver.TabIndex = 37;
            // 
            // txtMobileReceiver
            // 
            this.txtMobileReceiver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMobileReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobileReceiver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMobileReceiver.Location = new System.Drawing.Point(0, 0);
            this.txtMobileReceiver.Multiline = true;
            this.txtMobileReceiver.Name = "txtMobileReceiver";
            this.txtMobileReceiver.Size = new System.Drawing.Size(155, 27);
            this.txtMobileReceiver.TabIndex = 0;
            // 
            // panelReceiverID
            // 
            this.panelReceiverID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReceiverID.BackColor = System.Drawing.Color.Gainsboro;
            this.panelReceiverID.Controls.Add(this.cbReceiverID);
            this.panelReceiverID.Location = new System.Drawing.Point(176, 33);
            this.panelReceiverID.Margin = new System.Windows.Forms.Padding(0);
            this.panelReceiverID.Name = "panelReceiverID";
            this.panelReceiverID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelReceiverID.Size = new System.Drawing.Size(190, 30);
            this.panelReceiverID.TabIndex = 38;
            // 
            // cbReceiverID
            // 
            this.cbReceiverID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbReceiverID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbReceiverID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReceiverID.FormattingEnabled = true;
            this.cbReceiverID.Items.AddRange(new object[] {
            "__Select__",
            "Afficial",
            "Free"});
            this.cbReceiverID.Location = new System.Drawing.Point(0, 0);
            this.cbReceiverID.Name = "cbReceiverID";
            this.cbReceiverID.Size = new System.Drawing.Size(190, 29);
            this.cbReceiverID.TabIndex = 0;
            this.cbReceiverID.SelectedIndexChanged += new System.EventHandler(this.cbReceiverID_SelectedIndexChanged);
            // 
            // lbReceiverAddress
            // 
            this.lbReceiverAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceiverAddress.AutoSize = true;
            this.lbReceiverAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiverAddress.Location = new System.Drawing.Point(35, 146);
            this.lbReceiverAddress.Name = "lbReceiverAddress";
            this.lbReceiverAddress.Size = new System.Drawing.Size(138, 20);
            this.lbReceiverAddress.TabIndex = 43;
            this.lbReceiverAddress.Text = "Receiver Address";
            // 
            // lbReceiverName
            // 
            this.lbReceiverName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceiverName.AutoSize = true;
            this.lbReceiverName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiverName.Location = new System.Drawing.Point(550, 83);
            this.lbReceiverName.Name = "lbReceiverName";
            this.lbReceiverName.Size = new System.Drawing.Size(124, 20);
            this.lbReceiverName.TabIndex = 41;
            this.lbReceiverName.Text = "Receiver Name";
            // 
            // panelReceiverAddress
            // 
            this.panelReceiverAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReceiverAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.panelReceiverAddress.Controls.Add(this.txtReceiverAddress);
            this.panelReceiverAddress.Location = new System.Drawing.Point(176, 146);
            this.panelReceiverAddress.Margin = new System.Windows.Forms.Padding(0);
            this.panelReceiverAddress.Name = "panelReceiverAddress";
            this.panelReceiverAddress.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelReceiverAddress.Size = new System.Drawing.Size(665, 67);
            this.panelReceiverAddress.TabIndex = 39;
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceiverAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiverAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiverAddress.Location = new System.Drawing.Point(0, 0);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(665, 64);
            this.txtReceiverAddress.TabIndex = 0;
            // 
            // lbMobileReceiver
            // 
            this.lbMobileReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMobileReceiver.AutoSize = true;
            this.lbMobileReceiver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMobileReceiver.Location = new System.Drawing.Point(543, 38);
            this.lbMobileReceiver.Name = "lbMobileReceiver";
            this.lbMobileReceiver.Size = new System.Drawing.Size(131, 20);
            this.lbMobileReceiver.TabIndex = 42;
            this.lbMobileReceiver.Text = "Mobile Receiver";
            // 
            // gbSenderPorfile
            // 
            this.gbSenderPorfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSenderPorfile.BackColor = System.Drawing.Color.White;
            this.gbSenderPorfile.Controls.Add(this.lbSenderID);
            this.gbSenderPorfile.Controls.Add(this.panelSender);
            this.gbSenderPorfile.Controls.Add(this.lbSender);
            this.gbSenderPorfile.Controls.Add(this.panelSenderName);
            this.gbSenderPorfile.Controls.Add(this.panelMobileSender);
            this.gbSenderPorfile.Controls.Add(this.panelSenderID);
            this.gbSenderPorfile.Controls.Add(this.lbSenderAddress);
            this.gbSenderPorfile.Controls.Add(this.lbSenderName);
            this.gbSenderPorfile.Controls.Add(this.panelSenderAddress);
            this.gbSenderPorfile.Controls.Add(this.lbMobileSender);
            this.gbSenderPorfile.ForeColor = System.Drawing.Color.Black;
            this.gbSenderPorfile.Location = new System.Drawing.Point(-460, 2);
            this.gbSenderPorfile.Name = "gbSenderPorfile";
            this.gbSenderPorfile.Size = new System.Drawing.Size(926, 239);
            this.gbSenderPorfile.TabIndex = 51;
            this.gbSenderPorfile.TabStop = false;
            this.gbSenderPorfile.Text = "Sender Porfile";
            // 
            // lbSenderID
            // 
            this.lbSenderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenderID.AutoSize = true;
            this.lbSenderID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenderID.Location = new System.Drawing.Point(72, 38);
            this.lbSenderID.Name = "lbSenderID";
            this.lbSenderID.Size = new System.Drawing.Size(80, 20);
            this.lbSenderID.TabIndex = 45;
            this.lbSenderID.Text = "Sender ID";
            // 
            // panelSender
            // 
            this.panelSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSender.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSender.Controls.Add(this.txtSender);
            this.panelSender.Location = new System.Drawing.Point(178, 78);
            this.panelSender.Margin = new System.Windows.Forms.Padding(0);
            this.panelSender.Name = "panelSender";
            this.panelSender.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelSender.Size = new System.Drawing.Size(292, 30);
            this.panelSender.TabIndex = 35;
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSender.Location = new System.Drawing.Point(0, 0);
            this.txtSender.Multiline = true;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(292, 27);
            this.txtSender.TabIndex = 0;
            // 
            // lbSender
            // 
            this.lbSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSender.AutoSize = true;
            this.lbSender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSender.Location = new System.Drawing.Point(92, 83);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(60, 20);
            this.lbSender.TabIndex = 44;
            this.lbSender.Text = "Sender";
            // 
            // panelSenderName
            // 
            this.panelSenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSenderName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSenderName.Controls.Add(this.txtSenderName);
            this.panelSenderName.Location = new System.Drawing.Point(704, 78);
            this.panelSenderName.Margin = new System.Windows.Forms.Padding(0);
            this.panelSenderName.Name = "panelSenderName";
            this.panelSenderName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelSenderName.Size = new System.Drawing.Size(139, 30);
            this.panelSenderName.TabIndex = 36;
            // 
            // txtSenderName
            // 
            this.txtSenderName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSenderName.Location = new System.Drawing.Point(0, 0);
            this.txtSenderName.Multiline = true;
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(139, 27);
            this.txtSenderName.TabIndex = 0;
            // 
            // panelMobileSender
            // 
            this.panelMobileSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMobileSender.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMobileSender.Controls.Add(this.txtMobileSender);
            this.panelMobileSender.Location = new System.Drawing.Point(688, 33);
            this.panelMobileSender.Margin = new System.Windows.Forms.Padding(0);
            this.panelMobileSender.Name = "panelMobileSender";
            this.panelMobileSender.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelMobileSender.Size = new System.Drawing.Size(155, 30);
            this.panelMobileSender.TabIndex = 37;
            // 
            // txtMobileSender
            // 
            this.txtMobileSender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMobileSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobileSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMobileSender.Location = new System.Drawing.Point(0, 0);
            this.txtMobileSender.Multiline = true;
            this.txtMobileSender.Name = "txtMobileSender";
            this.txtMobileSender.Size = new System.Drawing.Size(155, 27);
            this.txtMobileSender.TabIndex = 0;
            // 
            // panelSenderID
            // 
            this.panelSenderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSenderID.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSenderID.Controls.Add(this.cbSenderID);
            this.panelSenderID.Location = new System.Drawing.Point(178, 33);
            this.panelSenderID.Margin = new System.Windows.Forms.Padding(0);
            this.panelSenderID.Name = "panelSenderID";
            this.panelSenderID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelSenderID.Size = new System.Drawing.Size(190, 30);
            this.panelSenderID.TabIndex = 38;
            // 
            // cbSenderID
            // 
            this.cbSenderID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSenderID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSenderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSenderID.FormattingEnabled = true;
            this.cbSenderID.Items.AddRange(new object[] {
            "__Select__",
            "Afficial",
            "Free"});
            this.cbSenderID.Location = new System.Drawing.Point(0, 0);
            this.cbSenderID.Name = "cbSenderID";
            this.cbSenderID.Size = new System.Drawing.Size(190, 29);
            this.cbSenderID.TabIndex = 0;
            this.cbSenderID.SelectedIndexChanged += new System.EventHandler(this.cbSenderID_SelectedIndexChanged);
            // 
            // lbSenderAddress
            // 
            this.lbSenderAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenderAddress.AutoSize = true;
            this.lbSenderAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenderAddress.Location = new System.Drawing.Point(30, 146);
            this.lbSenderAddress.Name = "lbSenderAddress";
            this.lbSenderAddress.Size = new System.Drawing.Size(122, 20);
            this.lbSenderAddress.TabIndex = 43;
            this.lbSenderAddress.Text = "Sender Address";
            // 
            // lbSenderName
            // 
            this.lbSenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSenderName.AutoSize = true;
            this.lbSenderName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenderName.Location = new System.Drawing.Point(552, 83);
            this.lbSenderName.Name = "lbSenderName";
            this.lbSenderName.Size = new System.Drawing.Size(108, 20);
            this.lbSenderName.TabIndex = 41;
            this.lbSenderName.Text = "Sender Name";
            // 
            // panelSenderAddress
            // 
            this.panelSenderAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSenderAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSenderAddress.Controls.Add(this.txtSenderAddress);
            this.panelSenderAddress.Location = new System.Drawing.Point(178, 146);
            this.panelSenderAddress.Margin = new System.Windows.Forms.Padding(0);
            this.panelSenderAddress.Name = "panelSenderAddress";
            this.panelSenderAddress.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelSenderAddress.Size = new System.Drawing.Size(665, 67);
            this.panelSenderAddress.TabIndex = 39;
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenderAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenderAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSenderAddress.Location = new System.Drawing.Point(0, 0);
            this.txtSenderAddress.Multiline = true;
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(665, 64);
            this.txtSenderAddress.TabIndex = 0;
            // 
            // lbMobileSender
            // 
            this.lbMobileSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMobileSender.AutoSize = true;
            this.lbMobileSender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMobileSender.Location = new System.Drawing.Point(545, 38);
            this.lbMobileSender.Name = "lbMobileSender";
            this.lbMobileSender.Size = new System.Drawing.Size(115, 20);
            this.lbMobileSender.TabIndex = 42;
            this.lbMobileSender.Text = "Mobile Sender";
            // 
            // panelAddPage2
            // 
            this.panelAddPage2.BackColor = System.Drawing.Color.White;
            this.panelAddPage2.Controls.Add(this.lbTotalCost);
            this.panelAddPage2.Controls.Add(this.panelTotalCost);
            this.panelAddPage2.Controls.Add(this.panelDescription);
            this.panelAddPage2.Controls.Add(this.lbDescription);
            this.panelAddPage2.Controls.Add(this.gbOrderCost);
            this.panelAddPage2.Controls.Add(this.gbOrderInformation);
            this.panelAddPage2.Controls.Add(this.label7);
            this.panelAddPage2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddPage2.Location = new System.Drawing.Point(0, 143);
            this.panelAddPage2.Name = "panelAddPage2";
            this.panelAddPage2.Size = new System.Drawing.Size(944, 494);
            this.panelAddPage2.TabIndex = 20;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.Black;
            this.lbTotalCost.Location = new System.Drawing.Point(795, 370);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(79, 20);
            this.lbTotalCost.TabIndex = 59;
            this.lbTotalCost.Text = "Total Cost";
            // 
            // panelTotalCost
            // 
            this.panelTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTotalCost.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTotalCost.Controls.Add(this.txtTotalCost);
            this.panelTotalCost.Location = new System.Drawing.Point(797, 394);
            this.panelTotalCost.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalCost.Name = "panelTotalCost";
            this.panelTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelTotalCost.Size = new System.Drawing.Size(117, 58);
            this.panelTotalCost.TabIndex = 56;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalCost.Location = new System.Drawing.Point(0, 0);
            this.txtTotalCost.Multiline = true;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(117, 55);
            this.txtTotalCost.TabIndex = 0;
            // 
            // panelDescription
            // 
            this.panelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDescription.Controls.Add(this.txtDescription);
            this.panelDescription.Location = new System.Drawing.Point(126, 372);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelDescription.Size = new System.Drawing.Size(617, 81);
            this.panelDescription.TabIndex = 60;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(0, 0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(617, 78);
            this.txtDescription.TabIndex = 0;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Black;
            this.lbDescription.Location = new System.Drawing.Point(8, 377);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(91, 20);
            this.lbDescription.TabIndex = 54;
            this.lbDescription.Text = "Description";
            // 
            // gbOrderCost
            // 
            this.gbOrderCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOrderCost.Controls.Add(this.lbAdministrativeCosts);
            this.gbOrderCost.Controls.Add(this.panelAdministrativeCosts);
            this.gbOrderCost.Controls.Add(this.lbServiceCosts);
            this.gbOrderCost.Controls.Add(this.lbShippingCosts);
            this.gbOrderCost.Controls.Add(this.panelShippingCosts);
            this.gbOrderCost.Controls.Add(this.panelServiceCosts);
            this.gbOrderCost.Controls.Add(this.panelDiscount);
            this.gbOrderCost.Controls.Add(this.label5);
            this.gbOrderCost.Controls.Add(this.label4);
            this.gbOrderCost.Controls.Add(this.label3);
            this.gbOrderCost.Controls.Add(this.label2);
            this.gbOrderCost.Controls.Add(this.lbDiscount);
            this.gbOrderCost.ForeColor = System.Drawing.Color.Black;
            this.gbOrderCost.Location = new System.Drawing.Point(12, 206);
            this.gbOrderCost.Name = "gbOrderCost";
            this.gbOrderCost.Size = new System.Drawing.Size(919, 138);
            this.gbOrderCost.TabIndex = 57;
            this.gbOrderCost.TabStop = false;
            this.gbOrderCost.Text = "Order Cost";
            // 
            // lbAdministrativeCosts
            // 
            this.lbAdministrativeCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdministrativeCosts.AutoSize = true;
            this.lbAdministrativeCosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdministrativeCosts.Location = new System.Drawing.Point(17, 80);
            this.lbAdministrativeCosts.Name = "lbAdministrativeCosts";
            this.lbAdministrativeCosts.Size = new System.Drawing.Size(155, 20);
            this.lbAdministrativeCosts.TabIndex = 51;
            this.lbAdministrativeCosts.Text = "Administrative Costs";
            // 
            // panelAdministrativeCosts
            // 
            this.panelAdministrativeCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAdministrativeCosts.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAdministrativeCosts.Controls.Add(this.txtAdministrativeCosts);
            this.panelAdministrativeCosts.Location = new System.Drawing.Point(174, 75);
            this.panelAdministrativeCosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdministrativeCosts.Name = "panelAdministrativeCosts";
            this.panelAdministrativeCosts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelAdministrativeCosts.Size = new System.Drawing.Size(100, 30);
            this.panelAdministrativeCosts.TabIndex = 50;
            // 
            // txtAdministrativeCosts
            // 
            this.txtAdministrativeCosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdministrativeCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdministrativeCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdministrativeCosts.Location = new System.Drawing.Point(0, 0);
            this.txtAdministrativeCosts.Multiline = true;
            this.txtAdministrativeCosts.Name = "txtAdministrativeCosts";
            this.txtAdministrativeCosts.Size = new System.Drawing.Size(100, 27);
            this.txtAdministrativeCosts.TabIndex = 0;
            // 
            // lbServiceCosts
            // 
            this.lbServiceCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbServiceCosts.AutoSize = true;
            this.lbServiceCosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceCosts.Location = new System.Drawing.Point(492, 46);
            this.lbServiceCosts.Name = "lbServiceCosts";
            this.lbServiceCosts.Size = new System.Drawing.Size(107, 20);
            this.lbServiceCosts.TabIndex = 49;
            this.lbServiceCosts.Text = "Service Costs";
            // 
            // lbShippingCosts
            // 
            this.lbShippingCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShippingCosts.AutoSize = true;
            this.lbShippingCosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShippingCosts.Location = new System.Drawing.Point(17, 46);
            this.lbShippingCosts.Name = "lbShippingCosts";
            this.lbShippingCosts.Size = new System.Drawing.Size(113, 20);
            this.lbShippingCosts.TabIndex = 49;
            this.lbShippingCosts.Text = "Shipping Costs";
            // 
            // panelShippingCosts
            // 
            this.panelShippingCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelShippingCosts.BackColor = System.Drawing.Color.Gainsboro;
            this.panelShippingCosts.Controls.Add(this.txtShippingCosts);
            this.panelShippingCosts.Location = new System.Drawing.Point(174, 41);
            this.panelShippingCosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelShippingCosts.Name = "panelShippingCosts";
            this.panelShippingCosts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelShippingCosts.Size = new System.Drawing.Size(100, 30);
            this.panelShippingCosts.TabIndex = 46;
            // 
            // txtShippingCosts
            // 
            this.txtShippingCosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtShippingCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShippingCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShippingCosts.Location = new System.Drawing.Point(0, 0);
            this.txtShippingCosts.Multiline = true;
            this.txtShippingCosts.Name = "txtShippingCosts";
            this.txtShippingCosts.Size = new System.Drawing.Size(100, 27);
            this.txtShippingCosts.TabIndex = 0;
            // 
            // panelServiceCosts
            // 
            this.panelServiceCosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelServiceCosts.BackColor = System.Drawing.Color.Gainsboro;
            this.panelServiceCosts.Controls.Add(this.txtServiceCosts);
            this.panelServiceCosts.Location = new System.Drawing.Point(631, 41);
            this.panelServiceCosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelServiceCosts.Name = "panelServiceCosts";
            this.panelServiceCosts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelServiceCosts.Size = new System.Drawing.Size(100, 30);
            this.panelServiceCosts.TabIndex = 46;
            // 
            // txtServiceCosts
            // 
            this.txtServiceCosts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServiceCosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServiceCosts.Location = new System.Drawing.Point(0, 0);
            this.txtServiceCosts.Multiline = true;
            this.txtServiceCosts.Name = "txtServiceCosts";
            this.txtServiceCosts.Size = new System.Drawing.Size(100, 27);
            this.txtServiceCosts.TabIndex = 0;
            // 
            // panelDiscount
            // 
            this.panelDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDiscount.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDiscount.Controls.Add(this.txtDiscount);
            this.panelDiscount.Location = new System.Drawing.Point(631, 75);
            this.panelDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelDiscount.Size = new System.Drawing.Size(100, 30);
            this.panelDiscount.TabIndex = 46;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Location = new System.Drawing.Point(0, 0);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 27);
            this.txtDiscount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(737, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(737, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "$";
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(511, 80);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(72, 20);
            this.lbDiscount.TabIndex = 48;
            this.lbDiscount.Text = "Discount";
            // 
            // gbOrderInformation
            // 
            this.gbOrderInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOrderInformation.Controls.Add(this.groupBox1);
            this.gbOrderInformation.Controls.Add(this.panelPostType);
            this.gbOrderInformation.Controls.Add(this.lbPaymentType);
            this.gbOrderInformation.Controls.Add(this.lbWeight);
            this.gbOrderInformation.Controls.Add(this.lbPackageType);
            this.gbOrderInformation.Controls.Add(this.panelPackageType);
            this.gbOrderInformation.Controls.Add(this.lbPostType);
            this.gbOrderInformation.Controls.Add(this.panelWeight);
            this.gbOrderInformation.Controls.Add(this.panelNumber);
            this.gbOrderInformation.Controls.Add(this.lbNumber);
            this.gbOrderInformation.Controls.Add(this.label6);
            this.gbOrderInformation.ForeColor = System.Drawing.Color.Black;
            this.gbOrderInformation.Location = new System.Drawing.Point(12, 20);
            this.gbOrderInformation.Name = "gbOrderInformation";
            this.gbOrderInformation.Size = new System.Drawing.Size(919, 154);
            this.gbOrderInformation.TabIndex = 58;
            this.gbOrderInformation.TabStop = false;
            this.gbOrderInformation.Text = "Order Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.panelPaymentType);
            this.groupBox1.Controls.Add(this.rbDestination);
            this.groupBox1.Controls.Add(this.rbOrigin);
            this.groupBox1.Location = new System.Drawing.Point(631, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 82);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // panelPaymentType
            // 
            this.panelPaymentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPaymentType.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPaymentType.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPaymentType.Location = new System.Drawing.Point(-5, 77);
            this.panelPaymentType.Name = "panelPaymentType";
            this.panelPaymentType.Size = new System.Drawing.Size(257, 4);
            this.panelPaymentType.TabIndex = 52;
            // 
            // rbDestination
            // 
            this.rbDestination.AutoSize = true;
            this.rbDestination.Location = new System.Drawing.Point(15, 43);
            this.rbDestination.Name = "rbDestination";
            this.rbDestination.Size = new System.Drawing.Size(213, 25);
            this.rbDestination.TabIndex = 0;
            this.rbDestination.TabStop = true;
            this.rbDestination.Text = "Payment at Destination";
            this.rbDestination.UseVisualStyleBackColor = true;
            // 
            // rbOrigin
            // 
            this.rbOrigin.AutoSize = true;
            this.rbOrigin.Location = new System.Drawing.Point(15, 17);
            this.rbOrigin.Name = "rbOrigin";
            this.rbOrigin.Size = new System.Drawing.Size(170, 25);
            this.rbOrigin.TabIndex = 0;
            this.rbOrigin.TabStop = true;
            this.rbOrigin.Text = "Payment at Origin";
            this.rbOrigin.UseVisualStyleBackColor = true;
            // 
            // panelPostType
            // 
            this.panelPostType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPostType.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPostType.Controls.Add(this.cbPostType);
            this.panelPostType.Location = new System.Drawing.Point(162, 26);
            this.panelPostType.Margin = new System.Windows.Forms.Padding(0);
            this.panelPostType.Name = "panelPostType";
            this.panelPostType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelPostType.Size = new System.Drawing.Size(146, 30);
            this.panelPostType.TabIndex = 47;
            // 
            // cbPostType
            // 
            this.cbPostType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPostType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPostType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPostType.FormattingEnabled = true;
            this.cbPostType.Items.AddRange(new object[] {
            "__Select__",
            "Afficial",
            "Free"});
            this.cbPostType.Location = new System.Drawing.Point(0, 0);
            this.cbPostType.Name = "cbPostType";
            this.cbPostType.Size = new System.Drawing.Size(146, 29);
            this.cbPostType.TabIndex = 0;
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPaymentType.AutoSize = true;
            this.lbPaymentType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentType.Location = new System.Drawing.Point(468, 31);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(110, 20);
            this.lbPaymentType.TabIndex = 50;
            this.lbPaymentType.Text = "Payment Type";
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.Location = new System.Drawing.Point(88, 107);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(61, 20);
            this.lbWeight.TabIndex = 48;
            this.lbWeight.Text = "Weight";
            // 
            // lbPackageType
            // 
            this.lbPackageType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPackageType.AutoSize = true;
            this.lbPackageType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPackageType.Location = new System.Drawing.Point(31, 67);
            this.lbPackageType.Name = "lbPackageType";
            this.lbPackageType.Size = new System.Drawing.Size(113, 20);
            this.lbPackageType.TabIndex = 49;
            this.lbPackageType.Text = "Package Type";
            // 
            // panelPackageType
            // 
            this.panelPackageType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPackageType.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPackageType.Controls.Add(this.cbPackageType);
            this.panelPackageType.Location = new System.Drawing.Point(162, 63);
            this.panelPackageType.Margin = new System.Windows.Forms.Padding(0);
            this.panelPackageType.Name = "panelPackageType";
            this.panelPackageType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelPackageType.Size = new System.Drawing.Size(146, 30);
            this.panelPackageType.TabIndex = 47;
            // 
            // cbPackageType
            // 
            this.cbPackageType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPackageType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPackageType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPackageType.FormattingEnabled = true;
            this.cbPackageType.Items.AddRange(new object[] {
            "__Select__",
            "Afficial",
            "Free"});
            this.cbPackageType.Location = new System.Drawing.Point(0, 0);
            this.cbPackageType.Name = "cbPackageType";
            this.cbPackageType.Size = new System.Drawing.Size(146, 29);
            this.cbPackageType.TabIndex = 0;
            // 
            // lbPostType
            // 
            this.lbPostType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPostType.AutoSize = true;
            this.lbPostType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostType.Location = new System.Drawing.Point(68, 31);
            this.lbPostType.Name = "lbPostType";
            this.lbPostType.Size = new System.Drawing.Size(76, 20);
            this.lbPostType.TabIndex = 49;
            this.lbPostType.Text = "Post Type";
            // 
            // panelWeight
            // 
            this.panelWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.panelWeight.Controls.Add(this.txtWeight);
            this.panelWeight.Location = new System.Drawing.Point(162, 102);
            this.panelWeight.Margin = new System.Windows.Forms.Padding(0);
            this.panelWeight.Name = "panelWeight";
            this.panelWeight.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelWeight.Size = new System.Drawing.Size(112, 30);
            this.panelWeight.TabIndex = 46;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeight.Location = new System.Drawing.Point(0, 0);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(112, 27);
            this.txtWeight.TabIndex = 0;
            // 
            // panelNumber
            // 
            this.panelNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.panelNumber.Controls.Add(this.numUDNumber);
            this.panelNumber.Controls.Add(this.txtNumber);
            this.panelNumber.Location = new System.Drawing.Point(631, 102);
            this.panelNumber.Margin = new System.Windows.Forms.Padding(0);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelNumber.Size = new System.Drawing.Size(110, 30);
            this.panelNumber.TabIndex = 46;
            // 
            // numUDNumber
            // 
            this.numUDNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numUDNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDNumber.Location = new System.Drawing.Point(0, 0);
            this.numUDNumber.Name = "numUDNumber";
            this.numUDNumber.Size = new System.Drawing.Size(110, 27);
            this.numUDNumber.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumber.Location = new System.Drawing.Point(0, 0);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(110, 27);
            this.txtNumber.TabIndex = 0;
            // 
            // lbNumber
            // 
            this.lbNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(516, 106);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(67, 20);
            this.lbNumber.TabIndex = 48;
            this.lbNumber.Text = "Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Kg";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(920, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.panelPaymentStatus);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lbCondition);
            this.panel1.Controls.Add(this.lbPaymentStatus);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lbOrderDate);
            this.panel1.Controls.Add(this.panelOrderDate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.panelCondition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelOrderID);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 143);
            this.panel1.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageIndex = 1;
            this.btnNext.ImageList = this.imageList;
            this.btnNext.Location = new System.Drawing.Point(896, 98);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 42);
            this.btnNext.TabIndex = 52;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelPaymentStatus
            // 
            this.panelPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPaymentStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPaymentStatus.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPaymentStatus.Location = new System.Drawing.Point(241, 133);
            this.panelPaymentStatus.Name = "panelPaymentStatus";
            this.panelPaymentStatus.Size = new System.Drawing.Size(257, 4);
            this.panelPaymentStatus.TabIndex = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.rbPaid);
            this.groupBox2.Controls.Add(this.rbUnpaid);
            this.groupBox2.Location = new System.Drawing.Point(241, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 29);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(19, 2);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(62, 25);
            this.rbPaid.TabIndex = 0;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            this.rbPaid.Leave += new System.EventHandler(this.rbPaid_Leave);
            this.rbPaid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbPaid_MouseDown);
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Location = new System.Drawing.Point(138, 1);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(85, 25);
            this.rbUnpaid.TabIndex = 0;
            this.rbUnpaid.TabStop = true;
            this.rbUnpaid.Text = "Unpaid";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            // 
            // lbCondition
            // 
            this.lbCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCondition.AutoSize = true;
            this.lbCondition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCondition.Location = new System.Drawing.Point(580, 111);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(80, 20);
            this.lbCondition.TabIndex = 45;
            this.lbCondition.Text = "Condition";
            // 
            // lbPaymentStatus
            // 
            this.lbPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPaymentStatus.AutoSize = true;
            this.lbPaymentStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentStatus.Location = new System.Drawing.Point(109, 111);
            this.lbPaymentStatus.Name = "lbPaymentStatus";
            this.lbPaymentStatus.Size = new System.Drawing.Size(119, 20);
            this.lbPaymentStatus.TabIndex = 45;
            this.lbPaymentStatus.Text = "Payment Status";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnCancel.Image = global::ShippingManagementApp.Properties.Resources.Close_red1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(770, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderDate.Location = new System.Drawing.Point(585, 63);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(88, 20);
            this.lbOrderDate.TabIndex = 50;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // panelOrderDate
            // 
            this.panelOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOrderDate.BackColor = System.Drawing.Color.Gainsboro;
            this.panelOrderDate.Controls.Add(this.panelBirthDate);
            this.panelOrderDate.Controls.Add(this.dateOrderDate);
            this.panelOrderDate.Controls.Add(this.textBox1);
            this.panelOrderDate.Location = new System.Drawing.Point(714, 70);
            this.panelOrderDate.Margin = new System.Windows.Forms.Padding(0);
            this.panelOrderDate.Name = "panelOrderDate";
            this.panelOrderDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelOrderDate.Size = new System.Drawing.Size(155, 30);
            this.panelOrderDate.TabIndex = 51;
            // 
            // panelBirthDate
            // 
            this.panelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBirthDate.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBirthDate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBirthDate.Location = new System.Drawing.Point(0, 27);
            this.panelBirthDate.Name = "panelBirthDate";
            this.panelBirthDate.Size = new System.Drawing.Size(155, 3);
            this.panelBirthDate.TabIndex = 48;
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOrderDate.Location = new System.Drawing.Point(0, 0);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Size = new System.Drawing.Size(155, 27);
            this.dateOrderDate.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 27);
            this.textBox1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::ShippingManagementApp.Properties.Resources.Done_white;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(603, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTitle.Location = new System.Drawing.Point(40, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(162, 36);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Add Order";
            // 
            // panelCondition
            // 
            this.panelCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCondition.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCondition.Controls.Add(this.cbCondition);
            this.panelCondition.Location = new System.Drawing.Point(686, 106);
            this.panelCondition.Margin = new System.Windows.Forms.Padding(0);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelCondition.Size = new System.Drawing.Size(190, 30);
            this.panelCondition.TabIndex = 38;
            // 
            // cbCondition
            // 
            this.cbCondition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "__Select__",
            "Afficial",
            "Free"});
            this.cbCondition.Location = new System.Drawing.Point(0, 0);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(190, 29);
            this.cbCondition.TabIndex = 0;
            this.cbCondition.Leave += new System.EventHandler(this.cbCondition_Leave);
            this.cbCondition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbCondition_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 3);
            this.label1.TabIndex = 2;
            // 
            // panelOrderID
            // 
            this.panelOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOrderID.BackColor = System.Drawing.Color.Gainsboro;
            this.panelOrderID.Controls.Add(this.txtOrderID);
            this.panelOrderID.Location = new System.Drawing.Point(241, 70);
            this.panelOrderID.Margin = new System.Windows.Forms.Padding(0);
            this.panelOrderID.Name = "panelOrderID";
            this.panelOrderID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panelOrderID.Size = new System.Drawing.Size(260, 30);
            this.panelOrderID.TabIndex = 35;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrderID.Location = new System.Drawing.Point(0, 0);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(260, 27);
            this.txtOrderID.TabIndex = 0;
            // 
            // lbOrderID
            // 
            this.lbOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderID.Location = new System.Drawing.Point(106, 75);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(72, 20);
            this.lbOrderID.TabIndex = 45;
            this.lbOrderID.Text = "Order ID";
            // 
            // frm_Orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 750);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.tlpPanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Orders";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Orders_Load);
            this.tlpPanelTop.ResumeLayout(false);
            this.tlpPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAddPage1.ResumeLayout(false);
            this.gbReceiverPorfile.ResumeLayout(false);
            this.gbReceiverPorfile.PerformLayout();
            this.panelReceiver.ResumeLayout(false);
            this.panelReceiver.PerformLayout();
            this.panelReceiverName.ResumeLayout(false);
            this.panelReceiverName.PerformLayout();
            this.panelMobileReceiver.ResumeLayout(false);
            this.panelMobileReceiver.PerformLayout();
            this.panelReceiverID.ResumeLayout(false);
            this.panelReceiverAddress.ResumeLayout(false);
            this.panelReceiverAddress.PerformLayout();
            this.gbSenderPorfile.ResumeLayout(false);
            this.gbSenderPorfile.PerformLayout();
            this.panelSender.ResumeLayout(false);
            this.panelSender.PerformLayout();
            this.panelSenderName.ResumeLayout(false);
            this.panelSenderName.PerformLayout();
            this.panelMobileSender.ResumeLayout(false);
            this.panelMobileSender.PerformLayout();
            this.panelSenderID.ResumeLayout(false);
            this.panelSenderAddress.ResumeLayout(false);
            this.panelSenderAddress.PerformLayout();
            this.panelAddPage2.ResumeLayout(false);
            this.panelAddPage2.PerformLayout();
            this.panelTotalCost.ResumeLayout(false);
            this.panelTotalCost.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.gbOrderCost.ResumeLayout(false);
            this.gbOrderCost.PerformLayout();
            this.panelAdministrativeCosts.ResumeLayout(false);
            this.panelAdministrativeCosts.PerformLayout();
            this.panelShippingCosts.ResumeLayout(false);
            this.panelShippingCosts.PerformLayout();
            this.panelServiceCosts.ResumeLayout(false);
            this.panelServiceCosts.PerformLayout();
            this.panelDiscount.ResumeLayout(false);
            this.panelDiscount.PerformLayout();
            this.gbOrderInformation.ResumeLayout(false);
            this.gbOrderInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPostType.ResumeLayout(false);
            this.panelPackageType.ResumeLayout(false);
            this.panelWeight.ResumeLayout(false);
            this.panelWeight.PerformLayout();
            this.panelNumber.ResumeLayout(false);
            this.panelNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelOrderDate.ResumeLayout(false);
            this.panelOrderDate.PerformLayout();
            this.panelCondition.ResumeLayout(false);
            this.panelOrderID.ResumeLayout(false);
            this.panelOrderID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPanelTop;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelAddPage1;
        private System.Windows.Forms.Panel panelAddPage2;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Panel panelOrderDate;
        private System.Windows.Forms.Label panelBirthDate;
        private System.Windows.Forms.DateTimePicker dateOrderDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbPaymentStatus;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Label panelPaymentStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.GroupBox gbReceiverPorfile;
        private System.Windows.Forms.Label lbReceiverID;
        private System.Windows.Forms.Panel panelReceiver;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.Panel panelReceiverName;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Panel panelMobileReceiver;
        private System.Windows.Forms.TextBox txtMobileReceiver;
        private System.Windows.Forms.Panel panelReceiverID;
        private System.Windows.Forms.ComboBox cbReceiverID;
        private System.Windows.Forms.Label lbReceiverAddress;
        private System.Windows.Forms.Label lbReceiverName;
        private System.Windows.Forms.Panel panelReceiverAddress;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.Label lbMobileReceiver;
        private System.Windows.Forms.GroupBox gbSenderPorfile;
        private System.Windows.Forms.Label lbSenderID;
        private System.Windows.Forms.Panel panelSender;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.Panel panelSenderName;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Panel panelMobileSender;
        private System.Windows.Forms.TextBox txtMobileSender;
        private System.Windows.Forms.Panel panelSenderID;
        private System.Windows.Forms.ComboBox cbSenderID;
        private System.Windows.Forms.Label lbSenderAddress;
        private System.Windows.Forms.Label lbSenderName;
        private System.Windows.Forms.Panel panelSenderAddress;
        private System.Windows.Forms.TextBox txtSenderAddress;
        private System.Windows.Forms.Label lbMobileSender;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Panel panelTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.GroupBox gbOrderCost;
        private System.Windows.Forms.Label lbAdministrativeCosts;
        private System.Windows.Forms.Panel panelAdministrativeCosts;
        private System.Windows.Forms.TextBox txtAdministrativeCosts;
        private System.Windows.Forms.Label lbServiceCosts;
        private System.Windows.Forms.Label lbShippingCosts;
        private System.Windows.Forms.Panel panelShippingCosts;
        private System.Windows.Forms.TextBox txtShippingCosts;
        private System.Windows.Forms.Panel panelServiceCosts;
        private System.Windows.Forms.TextBox txtServiceCosts;
        private System.Windows.Forms.Panel panelDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.GroupBox gbOrderInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label panelPaymentType;
        private System.Windows.Forms.RadioButton rbDestination;
        private System.Windows.Forms.RadioButton rbOrigin;
        private System.Windows.Forms.Panel panelPostType;
        private System.Windows.Forms.ComboBox cbPostType;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbPackageType;
        private System.Windows.Forms.Panel panelPackageType;
        private System.Windows.Forms.ComboBox cbPackageType;
        private System.Windows.Forms.Label lbPostType;
        private System.Windows.Forms.Panel panelWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel panelNumber;
        private System.Windows.Forms.NumericUpDown numUDNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNext;
    }
}