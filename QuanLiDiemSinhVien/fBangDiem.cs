using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemSinhVien
{
    public partial class fBangDiem : Form
    {
        private DataView dv_tblLop = new DataView();
        private DataView dv_dgv = new DataView();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;

        public fBangDiem()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(string filter = "")
        {
            string querySelect = "pr_DSDiem";
            try
            {
                // thuc hien cau lech neu loi nhay xuong catch
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        // su dung adapter de sao chep du lieu 
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable tblMonHoc = new DataTable())
                            {
                                adapter.Fill(tblMonHoc);
                                if (tblMonHoc.Rows.Count > 0)
                                {
                                    dv_dgv = tblMonHoc.DefaultView;
                                    // không hiển thị theo ý muốn 
                                    if (filter != null)
                                    {
                                        dv_dgv.RowFilter = filter;
                                    }
                                    //"sMaSV LIKE '%12' AND sHoTen LIKE '%Thao'"; // lọc trường, ko có % là tuyệt ffoid mã nào có số 12 trong đó mới được hiển thị lên
                                    dgvDiem.AutoGenerateColumns = false;
                                    dgvDiem.DataSource = tblMonHoc;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai ban ghi nao !");
                                }
                            }

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDataToComboBox()

        {
            string querySelect = "pr_DSLopHoc";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        // su dung adapter de sao chep du lieu 
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable tblLopHoc = new DataTable())
                            {
                                adapter.Fill(tblLopHoc);
                                if (tblLopHoc.Rows.Count > 0)
                                {
                                    //C1 bound: rằng buộc cơ sở dữ liệu

                                    dv_tblLop = tblLopHoc.DefaultView;// khoi tạo 

                                    cbMaLop.DataSource = dv_tblLop;
                                    cbMaLop.ValueMember = "sMaLp";// khoa chinh
                                                                  // truowngf hien thi len DisplayMemer
                                    cbMaLop.DisplayMember = "sMaLp";
                                    cbMaLop.Text = string.Empty;// ko có giá trị trước
                                                                 // C2: add ma lop vao unbound 
                                                                 //foreach(DataRow row in tblLopHoc.Rows)
                                                                 // {
                                                                 //     //ko bi rang buoc co so du lieu
                                                                 //     cBMaLopHC.Items.Add(row["sMaLop"]);
                                                                 // }
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai ban ghi nao !");
                                }
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fBangDiem_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            LoadDataToComboBox();
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDiem.CurrentRow.Index;
            txtMaSV.Text = dgvDiem.Rows[index].Cells["sMaSV"].Value.ToString();
            cbMaLop.Text = dgvDiem.Rows[index].Cells["sMaLp"].Value.ToString();
            txtKT.Text = dgvDiem.Rows[index].Cells["fKiemTra"].Value.ToString();
            txtChuyenCan.Text = dgvDiem.Rows[index].Cells["fChuyenCan"].Value.ToString();
            txtThi.Text = dgvDiem.Rows[index].Cells["fThi"].Value.ToString();
            txtTB.Text = dgvDiem.Rows[index].Cells["fDiemTB"].Value.ToString();
        }
        public void TinhDiem()
        {

        }
        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            
            
          

            //string iMaMon = txtMaKhoa.Text;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = Cnn.CreateCommand())
                {
                    //cmd.CommandText = "IdMaK";
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //Cnn.Open();
                    //cmd.Parameters.AddWithValue("@maKhoa", iMaMon);

                    //var tmp = cmd.ExecuteScalar();
                    //Cnn.Close();

                    //if (tmp == null)
                    //{
                        cmd.CommandText = "pr_InsertDiem";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@sMaSV", this.txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@sMaLp", this.cbMaLop.Text);
                        cmd.Parameters.AddWithValue("@fChuyenCan", this.txtChuyenCan.Text);
                        cmd.Parameters.AddWithValue("@fKiemTra", this.txtKT.Text);
                    cmd.Parameters.AddWithValue("@fThi", this.txtThi.Text);
                    cmd.Parameters.AddWithValue("@fDiemTB", this.txtTB.Text);
                    cmd.Parameters.AddWithValue("@xl", this.txtXepLoai.Text);
                    Cnn.Open();
                        cmd.ExecuteNonQuery();
                        Cnn.Close();
                        MessageBox.Show("Thêm mới thành công");
                        LoadDataToGridView();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ma mon hoc " + iMaMon + " đã tồn tại");
                    //}
                }
            }

        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {

            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "pr_UpdateDiem";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaSV", this.txtMaSV.Text);
                    sqlCommand.Parameters.AddWithValue("@sMaLp", this.cbMaLop.Text);
                    sqlCommand.Parameters.AddWithValue("@fChuyenCan", this.txtChuyenCan.Text);
                    sqlCommand.Parameters.AddWithValue("@fKiemTra", this.txtKT.Text);
                    sqlCommand.Parameters.AddWithValue("@fThi", this.txtThi.Text);
                   sqlCommand.Parameters.AddWithValue("@fDiemTB",this.txtTB.Text);
                    sqlCommand.Parameters.AddWithValue("@xl", this.txtXepLoai.Text);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    DialogResult dg = MessageBox.Show("Chỉnh sửa thành công");
                    LoadDataToGridView();
                }
            }

        }

        private void btnDeleteDiem_Click(object sender, EventArgs e)
        {
            int index = dgvDiem.CurrentRow.Index;
            string maSV = dgvDiem.Rows[index].Cells["sMaSV"].Value.ToString();
            try
            {

                DialogResult kq = MessageBox.Show("Bạn có muốn xóa Không", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "pr_DeleteDiem";
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@maSV", txtMaSV.Text);

                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            DialogResult dg = MessageBox.Show("Bạn đã xóa thành công ", "thông báo");
                            LoadDataToGridView();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("FK_Diem_SinhVien"))
                {
                    MessageBox.Show("Ma sinh vien " + maSV + " da phat sinh diem");
                }

                else if (error.Contains("40"))
                {
                    MessageBox.Show("Loi ket noi SQL");

                }
                else
                {
                    MessageBox.Show("Da co loi xay ra");
                }
            }
        }

        private void btnInDiem_Click(object sender, EventArgs e)
        {

        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nếu như chọn dữ liệu trong combobox sẽ tạo ra sự kiện gì đó 
            // 1 parameder ma lớp bằng mã lớp đã nhập
            int index = dgvDiem.CurrentRow.Index;// gia trị thứ bao nhiêu trogn comboBox
            string maSV = dgvDiem.Rows[index].Cells["sMaSV"].Value.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "MaSV_MaLop";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maSV", maSV);
                    sqlConnection.Open();
                    // cau lech thuwc thi
                    var s = sqlCommand.ExecuteScalar();// trar ve object
                    cbMaLop.Text = s.ToString();
                    sqlConnection.Close();

                }
            }
        }

        private void btnSearchDiem_Click(object sender, EventArgs e)
        {
            string tim = "select * from tbl_BangDiem where sMaK is not null";
            if (txtTimMonHoc.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaSV like'%" + txtTimMonHoc.Text + "%'";
            }
            else if (txtTimMonHoc.Text != "")
            {
                tim = tim + " and sMaLp like'%" + txtTimMonHoc.Text + "%'";
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvDiem.DataSource = tb;
                    }

                }
            }
        }
        private bool IsNumber(string value)
        {
            foreach (Char ch in value)
            {
                if (!Char.IsDigit(ch))// kiểm tra xem có phải là dạng số không phương thức của lớp char
                {

                    return false;
                }
            }
            return true;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double cc;
            double thi;
            double ktra;



            cc = Convert.ToDouble(txtChuyenCan.Text);
            thi = Convert.ToDouble(txtThi.Text);
            ktra = Convert.ToDouble(txtKT.Text);

            double tb = cc * 0.1 + thi * 0.7 + ktra * 0.2;
            string xl;


            if (tb >= 4)
            {
                xl = "Đỗ";
            }
            else
            {
                xl = "Trượt";
            }

            txtTB.Text = Convert.ToString(tb);

            txtXepLoai.Text = Convert.ToString(xl);
        }

        private void txtChuyenCan_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtChuyenCan.Text))
            {
                btnTinh.Enabled = true;
            }
            else
            {
                btnTinh.Enabled = false;
            }
        }

        private void txtKT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtKT.Text))
            {
                btnTinh.Enabled = true;
            }
            else
            {
                btnTinh.Enabled = false;
            }
        }

        private void txtTB_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtTB.Text))
            {
                btnTinh.Enabled = true;
            }
            else
            {
                btnTinh.Enabled = false;
            }
        }

        private void txtThi_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtThi.Text))
            {
                btnTinh.Enabled = true;
            }
            else
            {
                btnTinh.Enabled = false;
            }
        }
    }
}
