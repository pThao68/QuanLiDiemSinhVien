
namespace QuanLiDiemSinhVien
{
    partial class fBangDiem
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
            this.txtTB = new System.Windows.Forms.TextBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimMonHoc = new System.Windows.Forms.TextBox();
            this.btnSearchDiem = new System.Windows.Forms.Button();
            this.btnSuaDiem = new System.Windows.Forms.Button();
            this.btnDeleteDiem = new System.Windows.Forms.Button();
            this.btnInDiem = new System.Windows.Forms.Button();
            this.btnThemDiem = new System.Windows.Forms.Button();
            this.txtChuyenCan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sXepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTinh);
            this.groupBox2.Controls.Add(this.txtXepLoai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTB);
            this.groupBox2.Controls.Add(this.cbMaLop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtThi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimMonHoc);
            this.groupBox2.Controls.Add(this.btnSearchDiem);
            this.groupBox2.Controls.Add(this.btnSuaDiem);
            this.groupBox2.Controls.Add(this.btnDeleteDiem);
            this.groupBox2.Controls.Add(this.btnInDiem);
            this.groupBox2.Controls.Add(this.btnThemDiem);
            this.groupBox2.Controls.Add(this.txtChuyenCan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 216);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(395, 153);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(100, 22);
            this.txtTB.TabIndex = 21;
            this.txtTB.TextChanged += new System.EventHandler(this.txtTB_TextChanged);
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(98, 74);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(101, 24);
            this.cbMaLop.TabIndex = 20;
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Điểm trung bình";
            // 
            // txtThi
            // 
            this.txtThi.Location = new System.Drawing.Point(289, 153);
            this.txtThi.Name = "txtThi";
            this.txtThi.Size = new System.Drawing.Size(100, 22);
            this.txtThi.TabIndex = 18;
            this.txtThi.TextChanged += new System.EventHandler(this.txtThi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "ĐIểm thi";
            // 
            // txtKT
            // 
            this.txtKT.Location = new System.Drawing.Point(158, 153);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(100, 22);
            this.txtKT.TabIndex = 16;
            this.txtKT.TextChanged += new System.EventHandler(this.txtKT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Điểm Kiểm Tra ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtTimMonHoc
            // 
            this.txtTimMonHoc.Location = new System.Drawing.Point(376, 37);
            this.txtTimMonHoc.Name = "txtTimMonHoc";
            this.txtTimMonHoc.Size = new System.Drawing.Size(100, 22);
            this.txtTimMonHoc.TabIndex = 13;
            // 
            // btnSearchDiem
            // 
            this.btnSearchDiem.Location = new System.Drawing.Point(500, 37);
            this.btnSearchDiem.Name = "btnSearchDiem";
            this.btnSearchDiem.Size = new System.Drawing.Size(91, 32);
            this.btnSearchDiem.TabIndex = 12;
            this.btnSearchDiem.Text = "Tìm";
            this.btnSearchDiem.UseVisualStyleBackColor = true;
            this.btnSearchDiem.Click += new System.EventHandler(this.btnSearchDiem_Click);
            // 
            // btnSuaDiem
            // 
            this.btnSuaDiem.Location = new System.Drawing.Point(635, 57);
            this.btnSuaDiem.Name = "btnSuaDiem";
            this.btnSuaDiem.Size = new System.Drawing.Size(91, 32);
            this.btnSuaDiem.TabIndex = 11;
            this.btnSuaDiem.Text = "Chỉnh sửa";
            this.btnSuaDiem.UseVisualStyleBackColor = true;
            this.btnSuaDiem.Click += new System.EventHandler(this.btnSuaDiem_Click);
            // 
            // btnDeleteDiem
            // 
            this.btnDeleteDiem.Location = new System.Drawing.Point(635, 95);
            this.btnDeleteDiem.Name = "btnDeleteDiem";
            this.btnDeleteDiem.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteDiem.TabIndex = 10;
            this.btnDeleteDiem.Text = "Xoá";
            this.btnDeleteDiem.UseVisualStyleBackColor = true;
            this.btnDeleteDiem.Click += new System.EventHandler(this.btnDeleteDiem_Click);
            // 
            // btnInDiem
            // 
            this.btnInDiem.Location = new System.Drawing.Point(635, 133);
            this.btnInDiem.Name = "btnInDiem";
            this.btnInDiem.Size = new System.Drawing.Size(91, 32);
            this.btnInDiem.TabIndex = 9;
            this.btnInDiem.Text = "In";
            this.btnInDiem.UseVisualStyleBackColor = true;
            this.btnInDiem.Click += new System.EventHandler(this.btnInDiem_Click);
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.Location = new System.Drawing.Point(635, 19);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(91, 32);
            this.btnThemDiem.TabIndex = 8;
            this.btnThemDiem.Text = "Thêm";
            this.btnThemDiem.UseVisualStyleBackColor = true;
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // txtChuyenCan
            // 
            this.txtChuyenCan.Location = new System.Drawing.Point(14, 152);
            this.txtChuyenCan.Name = "txtChuyenCan";
            this.txtChuyenCan.Size = new System.Drawing.Size(100, 22);
            this.txtChuyenCan.TabIndex = 5;
            this.txtChuyenCan.TextChanged += new System.EventHandler(this.txtChuyenCan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm Chuyên Cần ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp: ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(99, 34);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDiem);
            this.groupBox1.Location = new System.Drawing.Point(6, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 215);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSV,
            this.fKiemTra,
            this.fThi,
            this.fDiemTB,
            this.sMaLp,
            this.fChuyenCan,
            this.sXepLoai});
            this.dgvDiem.Location = new System.Drawing.Point(0, 21);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.Size = new System.Drawing.Size(775, 183);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(509, 153);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(100, 22);
            this.txtXepLoai.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Xếp Loại";
            // 
            // sMaSV
            // 
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã sinh viên";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            this.sMaSV.Width = 125;
            // 
            // fKiemTra
            // 
            this.fKiemTra.DataPropertyName = "fKiemTra";
            this.fKiemTra.HeaderText = "Kiểm Tra";
            this.fKiemTra.MinimumWidth = 6;
            this.fKiemTra.Name = "fKiemTra";
            this.fKiemTra.Width = 125;
            // 
            // fThi
            // 
            this.fThi.DataPropertyName = "fThi";
            this.fThi.HeaderText = "Thi";
            this.fThi.MinimumWidth = 6;
            this.fThi.Name = "fThi";
            this.fThi.Width = 125;
            // 
            // fDiemTB
            // 
            this.fDiemTB.DataPropertyName = "fDiemTB";
            this.fDiemTB.HeaderText = "Điểm Trung Bình";
            this.fDiemTB.MinimumWidth = 6;
            this.fDiemTB.Name = "fDiemTB";
            this.fDiemTB.Width = 125;
            // 
            // sMaLp
            // 
            this.sMaLp.DataPropertyName = "sMaLp";
            this.sMaLp.HeaderText = "Mã Lớp";
            this.sMaLp.MinimumWidth = 6;
            this.sMaLp.Name = "sMaLp";
            this.sMaLp.Width = 125;
            // 
            // fChuyenCan
            // 
            this.fChuyenCan.DataPropertyName = "fChuyenCan";
            this.fChuyenCan.HeaderText = "Chuyên cần";
            this.fChuyenCan.MinimumWidth = 6;
            this.fChuyenCan.Name = "fChuyenCan";
            this.fChuyenCan.Width = 125;
            // 
            // sXepLoai
            // 
            this.sXepLoai.DataPropertyName = "sXepLoai";
            this.sXepLoai.HeaderText = "Xếp Loai";
            this.sXepLoai.MinimumWidth = 6;
            this.sXepLoai.Name = "sXepLoai";
            this.sXepLoai.Width = 125;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(632, 182);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 24;
            this.btnTinh.Text = "Tính Điểm";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // fBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fBangDiem";
            this.Text = "fBangDiem";
            this.Load += new System.EventHandler(this.fBangDiem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimMonHoc;
        private System.Windows.Forms.Button btnSearchDiem;
        private System.Windows.Forms.Button btnSuaDiem;
        private System.Windows.Forms.Button btnDeleteDiem;
        private System.Windows.Forms.Button btnInDiem;
        private System.Windows.Forms.Button btnThemDiem;
        private System.Windows.Forms.TextBox txtChuyenCan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sXepLoai;
        private System.Windows.Forms.Button btnTinh;
    }
}