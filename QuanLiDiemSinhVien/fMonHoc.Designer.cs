
namespace QuanLiDiemSinhVien
{
    partial class fMonHoc
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimMonHoc = new System.Windows.Forms.TextBox();
            this.btnSearchMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnDeleteMon = new System.Windows.Forms.Button();
            this.btnInMon = new System.Windows.Forms.Button();
            this.btnThenMon = new System.Windows.Forms.Button();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.sMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimMonHoc);
            this.groupBox2.Controls.Add(this.btnSearchMon);
            this.groupBox2.Controls.Add(this.btnSuaMon);
            this.groupBox2.Controls.Add(this.btnDeleteMon);
            this.groupBox2.Controls.Add(this.btnInMon);
            this.groupBox2.Controls.Add(this.btnThenMon);
            this.groupBox2.Controls.Add(this.txtSoTC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenMH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaMonHoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 216);
            this.groupBox2.TabIndex = 10;
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
            // txtTimMonHoc
            // 
            this.txtTimMonHoc.Location = new System.Drawing.Point(376, 37);
            this.txtTimMonHoc.Name = "txtTimMonHoc";
            this.txtTimMonHoc.Size = new System.Drawing.Size(100, 22);
            this.txtTimMonHoc.TabIndex = 13;
            // 
            // btnSearchMon
            // 
            this.btnSearchMon.Location = new System.Drawing.Point(342, 95);
            this.btnSearchMon.Name = "btnSearchMon";
            this.btnSearchMon.Size = new System.Drawing.Size(91, 32);
            this.btnSearchMon.TabIndex = 12;
            this.btnSearchMon.Text = "Tìm";
            this.btnSearchMon.UseVisualStyleBackColor = true;
            this.btnSearchMon.Click += new System.EventHandler(this.btnSearchMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Location = new System.Drawing.Point(635, 57);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(91, 32);
            this.btnSuaMon.TabIndex = 11;
            this.btnSuaMon.Text = "Chỉnh sửa";
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnDeleteMon
            // 
            this.btnDeleteMon.Location = new System.Drawing.Point(635, 95);
            this.btnDeleteMon.Name = "btnDeleteMon";
            this.btnDeleteMon.Size = new System.Drawing.Size(91, 32);
            this.btnDeleteMon.TabIndex = 10;
            this.btnDeleteMon.Text = "Xoá";
            this.btnDeleteMon.UseVisualStyleBackColor = true;
            this.btnDeleteMon.Click += new System.EventHandler(this.btnDeleteMon_Click);
            // 
            // btnInMon
            // 
            this.btnInMon.Location = new System.Drawing.Point(635, 133);
            this.btnInMon.Name = "btnInMon";
            this.btnInMon.Size = new System.Drawing.Size(91, 32);
            this.btnInMon.TabIndex = 9;
            this.btnInMon.Text = "In";
            this.btnInMon.UseVisualStyleBackColor = true;
            // 
            // btnThenMon
            // 
            this.btnThenMon.Location = new System.Drawing.Point(635, 19);
            this.btnThenMon.Name = "btnThenMon";
            this.btnThenMon.Size = new System.Drawing.Size(91, 32);
            this.btnThenMon.TabIndex = 8;
            this.btnThenMon.Text = "Thêm";
            this.btnThenMon.UseVisualStyleBackColor = true;
            this.btnThenMon.Click += new System.EventHandler(this.btnThenMon_Click);
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(99, 132);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(100, 22);
            this.txtSoTC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tín chỉ: ";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(99, 81);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(100, 22);
            this.txtTenMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Môn Học: ";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(99, 34);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 22);
            this.txtMaMonHoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn Học:  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(6, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 215);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaMon,
            this.sTenMon,
            this.iSoTC});
            this.dgvMonHoc.Location = new System.Drawing.Point(6, 18);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(775, 183);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            // 
            // sMaMon
            // 
            this.sMaMon.DataPropertyName = "sMaMon";
            this.sMaMon.HeaderText = "MaMon";
            this.sMaMon.MinimumWidth = 6;
            this.sMaMon.Name = "sMaMon";
            this.sMaMon.Width = 125;
            // 
            // sTenMon
            // 
            this.sTenMon.DataPropertyName = "sTenMon";
            this.sTenMon.HeaderText = "Tên Môn";
            this.sTenMon.MinimumWidth = 6;
            this.sTenMon.Name = "sTenMon";
            this.sTenMon.Width = 125;
            // 
            // iSoTC
            // 
            this.iSoTC.DataPropertyName = "iSoTC";
            this.iSoTC.HeaderText = "Số Tín Chỉ";
            this.iSoTC.MinimumWidth = 6;
            this.iSoTC.Name = "iSoTC";
            this.iSoTC.Width = 125;
            // 
            // fMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fMonHoc";
            this.Text = "fMonHoc";
            this.Load += new System.EventHandler(this.fMonHoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimMonHoc;
        private System.Windows.Forms.Button btnSearchMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnDeleteMon;
        private System.Windows.Forms.Button btnInMon;
        private System.Windows.Forms.Button btnThenMon;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoTC;
    }
}