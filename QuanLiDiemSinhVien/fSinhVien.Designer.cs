
namespace QuanLiDiemSinhVien
{
    partial class fSinhVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpk_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKhoa = new System.Windows.Forms.TextBox();
            this.btnSearchKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnDeleteKhoa = new System.Windows.Forms.Button();
            this.btnInKhoa = new System.Windows.Forms.Button();
            this.btnThenKhoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager1 = new QuanLiDiemSinhVien.data.DataSet1TableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpk_Ngaysinh);
            this.groupBox2.Controls.Add(this.rb_nu);
            this.groupBox2.Controls.Add(this.rb_nam);
            this.groupBox2.Controls.Add(this.cbMaKhoa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimKhoa);
            this.groupBox2.Controls.Add(this.btnSearchKhoa);
            this.groupBox2.Controls.Add(this.btnSuaKhoa);
            this.groupBox2.Controls.Add(this.btnDeleteKhoa);
            this.groupBox2.Controls.Add(this.btnInKhoa);
            this.groupBox2.Controls.Add(this.btnThenKhoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenSV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 216);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dtpk_Ngaysinh
            // 
            this.dtpk_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_Ngaysinh.Location = new System.Drawing.Point(100, 180);
            this.dtpk_Ngaysinh.Name = "dtpk_Ngaysinh";
            this.dtpk_Ngaysinh.Size = new System.Drawing.Size(133, 22);
            this.dtpk_Ngaysinh.TabIndex = 25;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(156, 132);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(47, 21);
            this.rb_nu.TabIndex = 24;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(82, 132);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(58, 21);
            this.rb_nam.TabIndex = 23;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(344, 172);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(104, 24);
            this.cbMaKhoa.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã Khoa: ";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(344, 122);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(104, 22);
            this.txtCMND.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "CMND: ";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(344, 78);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(104, 22);
            this.txtSdt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số điện thoại: ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(344, 29);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(104, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Địa chỉ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtTimKhoa
            // 
            this.txtTimKhoa.Location = new System.Drawing.Point(479, 45);
            this.txtTimKhoa.Name = "txtTimKhoa";
            this.txtTimKhoa.Size = new System.Drawing.Size(100, 22);
            this.txtTimKhoa.TabIndex = 13;
            // 
            // btnSearchKhoa
            // 
            this.btnSearchKhoa.Location = new System.Drawing.Point(479, 73);
            this.btnSearchKhoa.Name = "btnSearchKhoa";
            this.btnSearchKhoa.Size = new System.Drawing.Size(91, 32);
            this.btnSearchKhoa.TabIndex = 12;
            this.btnSearchKhoa.Text = "Tìm";
            this.btnSearchKhoa.UseVisualStyleBackColor = true;
            this.btnSearchKhoa.Click += new System.EventHandler(this.btnSearchKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(635, 57);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(91, 32);
            this.btnSuaKhoa.TabIndex = 11;
            this.btnSuaKhoa.Text = "Chỉnh sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnDeleteKhoa
            // 
            this.btnDeleteKhoa.Location = new System.Drawing.Point(635, 95);
            this.btnDeleteKhoa.Name = "btnDeleteKhoa";
            this.btnDeleteKhoa.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteKhoa.TabIndex = 10;
            this.btnDeleteKhoa.Text = "Xoá";
            this.btnDeleteKhoa.UseVisualStyleBackColor = true;
            this.btnDeleteKhoa.Click += new System.EventHandler(this.btnDeleteKhoa_Click);
            // 
            // btnInKhoa
            // 
            this.btnInKhoa.Location = new System.Drawing.Point(635, 133);
            this.btnInKhoa.Name = "btnInKhoa";
            this.btnInKhoa.Size = new System.Drawing.Size(91, 32);
            this.btnInKhoa.TabIndex = 9;
            this.btnInKhoa.Text = "In";
            this.btnInKhoa.UseVisualStyleBackColor = true;
            this.btnInKhoa.Click += new System.EventHandler(this.btnInKhoa_Click);
            // 
            // btnThenKhoa
            // 
            this.btnThenKhoa.Location = new System.Drawing.Point(635, 19);
            this.btnThenKhoa.Name = "btnThenKhoa";
            this.btnThenKhoa.Size = new System.Drawing.Size(91, 32);
            this.btnThenKhoa.TabIndex = 8;
            this.btnThenKhoa.Text = "Thêm";
            this.btnThenKhoa.UseVisualStyleBackColor = true;
            this.btnThenKhoa.Click += new System.EventHandler(this.btnThenKhoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính: ";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(116, 81);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 22);
            this.txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh Viên:  ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(116, 34);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên :";
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSV,
            this.sHoTen,
            this.bGT,
            this.dNgaySinh,
            this.sDiaChi,
            this.sSDT,
            this.sCMND,
            this.sMaK});
            this.dgvSV.Location = new System.Drawing.Point(22, 255);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 51;
            this.dgvSV.RowTemplate.Height = 24;
            this.dgvSV.Size = new System.Drawing.Size(775, 183);
            this.dgvSV.TabIndex = 11;
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // sMaSV
            // 
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã Sinh Viên";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            this.sMaSV.Width = 125;
            // 
            // sHoTen
            // 
            this.sHoTen.DataPropertyName = "sHoTen";
            this.sHoTen.HeaderText = "Họ tên";
            this.sHoTen.MinimumWidth = 6;
            this.sHoTen.Name = "sHoTen";
            this.sHoTen.Width = 125;
            // 
            // bGT
            // 
            this.bGT.DataPropertyName = "bGT";
            this.bGT.HeaderText = "Giới tính ";
            this.bGT.MinimumWidth = 6;
            this.bGT.Name = "bGT";
            this.bGT.Width = 125;
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày Sinh";
            this.dNgaySinh.MinimumWidth = 6;
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Width = 125;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.Width = 125;
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số Điện Thoại";
            this.sSDT.MinimumWidth = 6;
            this.sSDT.Name = "sSDT";
            this.sSDT.Width = 125;
            // 
            // sCMND
            // 
            this.sCMND.DataPropertyName = "sCMND";
            this.sCMND.HeaderText = "CMND";
            this.sCMND.MinimumWidth = 6;
            this.sCMND.Name = "sCMND";
            this.sCMND.Width = 125;
            // 
            // sMaK
            // 
            this.sMaK.DataPropertyName = "sMaK";
            this.sMaK.HeaderText = "Mã Khoa";
            this.sMaK.MinimumWidth = 6;
            this.sMaK.Name = "sMaK";
            this.sMaK.Width = 125;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_KhoaTableAdapter = null;
            this.tableAdapterManager1.tbl_SinhVienTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLiDiemSinhVien.data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.groupBox2);
            this.Name = "fSinhVien";
            this.Text = "fSinhVien";
            this.Load += new System.EventHandler(this.fSinhVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKhoa;
        private System.Windows.Forms.Button btnSearchKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnDeleteKhoa;
        private System.Windows.Forms.Button btnInKhoa;
        private System.Windows.Forms.Button btnThenKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaK;
        private System.Windows.Forms.DateTimePicker dtpk_Ngaysinh;
        private data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}