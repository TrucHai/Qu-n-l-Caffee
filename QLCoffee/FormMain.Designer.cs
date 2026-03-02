namespace QLCoffee
{
    partial class FormMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tabSystemChild = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBanDangChon = new System.Windows.Forms.Label();
            this.flowLayoutPanelBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.rbMangVe = new System.Windows.Forms.RadioButton();
            this.rbTaiCho = new System.Windows.Forms.RadioButton();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cbGiamGia = new System.Windows.Forms.ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblBan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.tabQuanLy = new System.Windows.Forms.TabPage();
            this.btnQuanLyBan = new System.Windows.Forms.Button();
            this.btnQuanLyMon = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabSystemChild.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.tabQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAccount);
            this.tabMain.Controls.Add(this.tabSystemChild);
            this.tabMain.Controls.Add(this.tabQuanLy);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1204, 598);
            this.tabMain.TabIndex = 0;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.txtPassword);
            this.tabAccount.Controls.Add(this.txtUsername);
            this.tabAccount.Controls.Add(this.cbRole);
            this.tabAccount.Controls.Add(this.label3);
            this.tabAccount.Controls.Add(this.label2);
            this.tabAccount.Controls.Add(this.label1);
            this.tabAccount.Controls.Add(this.btnDelete);
            this.tabAccount.Controls.Add(this.btnAdd);
            this.tabAccount.Controls.Add(this.btnEdit);
            this.tabAccount.Controls.Add(this.dgvAccount);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1196, 569);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            this.tabAccount.Click += new System.EventHandler(this.tabAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(561, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(561, 293);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 22);
            this.txtUsername.TabIndex = 8;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(561, 365);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 24);
            this.cbRole.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(736, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 49);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(545, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 49);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(312, 48);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(622, 239);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // tabSystemChild
            // 
            this.tabSystemChild.Controls.Add(this.tableLayoutPanel1);
            this.tabSystemChild.Location = new System.Drawing.Point(4, 25);
            this.tabSystemChild.Name = "tabSystemChild";
            this.tabSystemChild.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemChild.Size = new System.Drawing.Size(1196, 569);
            this.tabSystemChild.TabIndex = 1;
            this.tabSystemChild.Text = "Hệ thống";
            this.tabSystemChild.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelHoaDon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 563);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBanDangChon);
            this.panel1.Controls.Add(this.flowLayoutPanelBan);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 557);
            this.panel1.TabIndex = 0;
            // 
            // labelBanDangChon
            // 
            this.labelBanDangChon.AutoSize = true;
            this.labelBanDangChon.Location = new System.Drawing.Point(3, 0);
            this.labelBanDangChon.Name = "labelBanDangChon";
            this.labelBanDangChon.Size = new System.Drawing.Size(192, 16);
            this.labelBanDangChon.TabIndex = 1;
            this.labelBanDangChon.Text = "Bàn đang chọn: Chưa chọn bàn";
            // 
            // flowLayoutPanelBan
            // 
            this.flowLayoutPanelBan.Location = new System.Drawing.Point(3, 33);
            this.flowLayoutPanelBan.Name = "flowLayoutPanelBan";
            this.flowLayoutPanelBan.Size = new System.Drawing.Size(288, 524);
            this.flowLayoutPanelBan.TabIndex = 0;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.rbMangVe);
            this.panelHoaDon.Controls.Add(this.rbTaiCho);
            this.panelHoaDon.Controls.Add(this.btnThanhToan);
            this.panelHoaDon.Controls.Add(this.nmDiscount);
            this.panelHoaDon.Controls.Add(this.lblTotalPrice);
            this.panelHoaDon.Controls.Add(this.label5);
            this.panelHoaDon.Controls.Add(this.label6);
            this.panelHoaDon.Controls.Add(this.txtThanhTien);
            this.panelHoaDon.Controls.Add(this.cbGiamGia);
            this.panelHoaDon.Controls.Add(this.lblDiscount);
            this.panelHoaDon.Controls.Add(this.btnXoa);
            this.panelHoaDon.Controls.Add(this.btnSua);
            this.panelHoaDon.Controls.Add(this.dtpNgayVao);
            this.panelHoaDon.Controls.Add(this.cbNhanVien);
            this.panelHoaDon.Controls.Add(this.lblBan);
            this.panelHoaDon.Controls.Add(this.label4);
            this.panelHoaDon.Controls.Add(this.lblNhanVien);
            this.panelHoaDon.Controls.Add(this.lblNgay);
            this.panelHoaDon.Controls.Add(this.dgvHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDon.Location = new System.Drawing.Point(740, 3);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(447, 557);
            this.panelHoaDon.TabIndex = 1;
            // 
            // rbMangVe
            // 
            this.rbMangVe.AutoSize = true;
            this.rbMangVe.Location = new System.Drawing.Point(123, 24);
            this.rbMangVe.Name = "rbMangVe";
            this.rbMangVe.Size = new System.Drawing.Size(80, 20);
            this.rbMangVe.TabIndex = 23;
            this.rbMangVe.TabStop = true;
            this.rbMangVe.Text = "Mang về";
            this.rbMangVe.UseVisualStyleBackColor = true;
            // 
            // rbTaiCho
            // 
            this.rbTaiCho.AutoSize = true;
            this.rbTaiCho.Location = new System.Drawing.Point(230, 24);
            this.rbTaiCho.Name = "rbTaiCho";
            this.rbTaiCho.Size = new System.Drawing.Size(73, 20);
            this.rbTaiCho.TabIndex = 22;
            this.rbTaiCho.TabStop = true;
            this.rbTaiCho.Text = "Tại chỗ";
            this.rbTaiCho.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(181, 507);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(122, 38);
            this.btnThanhToan.TabIndex = 21;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(187, 453);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(70, 22);
            this.nmDiscount.TabIndex = 20;
            this.nmDiscount.ValueChanged += new System.EventHandler(this.nmDiscount_ValueChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(342, 429);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(15, 16);
            this.lblTotalPrice.TabIndex = 19;
            this.lblTotalPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(187, 476);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(170, 22);
            this.txtThanhTien.TabIndex = 16;
            // 
            // cbGiamGia
            // 
            this.cbGiamGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiamGia.FormattingEnabled = true;
            this.cbGiamGia.Items.AddRange(new object[] {
            "Phần trăm (%)"});
            this.cbGiamGia.Location = new System.Drawing.Point(259, 452);
            this.cbGiamGia.Name = "cbGiamGia";
            this.cbGiamGia.Size = new System.Drawing.Size(98, 24);
            this.cbGiamGia.TabIndex = 15;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(103, 454);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(64, 16);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Giảm giá:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(118, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 24);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(10, 397);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 24);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpNgayVao.Enabled = false;
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVao.Location = new System.Drawing.Point(85, 87);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(218, 22);
            this.dtpNgayVao.TabIndex = 8;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVien.Location = new System.Drawing.Point(85, 58);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(218, 24);
            this.cbNhanVien.TabIndex = 7;
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(6, 36);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(62, 16);
            this.lblBan.TabIndex = 6;
            this.lblBan.Text = "Bàn số: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi tiết hóa đơn";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(6, 61);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(73, 16);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân viên: ";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(6, 87);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(46, 16);
            this.lblNgay.TabIndex = 3;
            this.lblNgay.Text = "Ngày: ";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenMon,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 115);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(441, 276);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellEndEdit);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Thực đơn";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numSoLuong);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.dgvMon);
            this.panel2.Controls.Add(this.btnThemMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 557);
            this.panel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tìm món";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(127, 487);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(304, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(121, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(177, 22);
            this.txtTim.TabIndex = 1;
            // 
            // dgvMon
            // 
            this.dgvMon.AllowUserToAddRows = false;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Location = new System.Drawing.Point(0, 68);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(431, 367);
            this.dgvMon.TabIndex = 0;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(296, 480);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(83, 34);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = "Chọn món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.btnQuanLyBan);
            this.tabQuanLy.Controls.Add(this.btnQuanLyMon);
            this.tabQuanLy.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLy.Size = new System.Drawing.Size(1196, 569);
            this.tabQuanLy.TabIndex = 2;
            this.tabQuanLy.Text = "Quản lý";
            this.tabQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.Location = new System.Drawing.Point(428, 221);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(306, 88);
            this.btnQuanLyBan.TabIndex = 1;
            this.btnQuanLyBan.Text = "Quản lý bàn";
            this.btnQuanLyBan.UseVisualStyleBackColor = true;
            this.btnQuanLyBan.Click += new System.EventHandler(this.btnQuanLyBan_Click);
            // 
            // btnQuanLyMon
            // 
            this.btnQuanLyMon.Location = new System.Drawing.Point(428, 115);
            this.btnQuanLyMon.Name = "btnQuanLyMon";
            this.btnQuanLyMon.Size = new System.Drawing.Size(306, 88);
            this.btnQuanLyMon.TabIndex = 0;
            this.btnQuanLyMon.Text = "Quản lý món";
            this.btnQuanLyMon.UseVisualStyleBackColor = true;
            this.btnQuanLyMon.Click += new System.EventHandler(this.btnQuanLyMon_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 594);
            this.Controls.Add(this.tabMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabSystemChild.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHoaDon.ResumeLayout(false);
            this.panelHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.tabQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage tabSystemChild;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBan;
        private System.Windows.Forms.Label labelBanDangChon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cbGiamGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbMangVe;
        private System.Windows.Forms.RadioButton rbTaiCho;
        private System.Windows.Forms.TabPage tabQuanLy;
        private System.Windows.Forms.Button btnQuanLyBan;
        private System.Windows.Forms.Button btnQuanLyMon;
    }
}