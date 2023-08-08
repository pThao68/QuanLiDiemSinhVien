using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemSinhVien
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhoa fKhoa = new fKhoa();
            fKhoa.ShowDialog();
            
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMonHoc fMon = new fMonHoc();
            fMon.ShowDialog();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLopHoc fLop = new fLopHoc();
            fLop.ShowDialog();
        }

        private void bảngĐiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBangDiem fBang = new fBangDiem();
            fBang.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSinhVien fSinhVien = new fSinhVien();
            fSinhVien.ShowDialog();
        }

        private void reportSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.SinhVienReport sv_rp = new ReportForm.SinhVienReport();
            //sv_rp.MdiParent = this;
            //sv_rp.StartPosition = FormStartPosition.CenterScreen;
            sv_rp.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
