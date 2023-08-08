
namespace QuanLiDiemSinhVien
{
    partial class fKhoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.sMaK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKhoa = new System.Windows.Forms.TextBox();
            this.btnSearchKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnDeleteKhoa = new System.Windows.Forms.Button();
            this.btnInKhoa = new System.Windows.Forms.Button();
            this.btnThenKhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa: ";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(99, 34);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 22);
            this.txtMaKhoa.TabIndex = 1;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(99, 81);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(100, 22);
            this.txtTenKhoa.TabIndex = 3;
            this.txtTenKhoa.TextChanged += new System.EventHandler(this.txtTenKhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khoa: ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(99, 132);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại: ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(99, 185);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKhoa);
            this.groupBox1.Location = new System.Drawing.Point(14, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaK,
            this.sTenK,
            this.sSDT,
            this.sDiaChi});
            this.dgvKhoa.Location = new System.Drawing.Point(6, 18);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.Size = new System.Drawing.Size(775, 183);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // sMaK
            // 
            this.sMaK.DataPropertyName = "sMaK";
            this.sMaK.HeaderText = "Mã Khoa";
            this.sMaK.MinimumWidth = 6;
            this.sMaK.Name = "sMaK";
            this.sMaK.Width = 125;
            // 
            // sTenK
            // 
            this.sTenK.DataPropertyName = "sTenK";
            this.sTenK.HeaderText = "Tên Khoa";
            this.sTenK.MinimumWidth = 6;
            this.sTenK.Name = "sTenK";
            this.sTenK.Width = 125;
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.MinimumWidth = 6;
            this.sSDT.Name = "sSDT";
            this.sSDT.Width = 125;
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimKhoa);
            this.groupBox2.Controls.Add(this.btnSearchKhoa);
            this.groupBox2.Controls.Add(this.btnSuaKhoa);
            this.groupBox2.Controls.Add(this.btnDeleteKhoa);
            this.groupBox2.Controls.Add(this.btnInKhoa);
            this.groupBox2.Controls.Add(this.btnThenKhoa);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenKhoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaKhoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 216);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
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
            // txtTimKhoa
            // 
            this.txtTimKhoa.Location = new System.Drawing.Point(376, 37);
            this.txtTimKhoa.Name = "txtTimKhoa";
            this.txtTimKhoa.Size = new System.Drawing.Size(100, 22);
            this.txtTimKhoa.TabIndex = 13;
            // 
            // btnSearchKhoa
            // 
            this.btnSearchKhoa.Location = new System.Drawing.Point(342, 95);
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
            // fKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fKhoa";
            this.Text = "fKhoa";
            this.Load += new System.EventHandler(this.fKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKhoa;
        private System.Windows.Forms.Button btnSearchKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnDeleteKhoa;
        private System.Windows.Forms.Button btnInKhoa;
        private System.Windows.Forms.Button btnThenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenK;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
    }
}