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
    public partial class fKhoa : Form
    {
        private DataView dv_dgv = new DataView();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;

        public fKhoa()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(string filter = "")
        {
            string querySelect = "pr_DSKhoa";
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
                                    dgvKhoa.AutoGenerateColumns = false;
                                    dgvKhoa.DataSource = tblMonHoc;
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
        private void fKhoa_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThenKhoa_Click(object sender, EventArgs e)
        {
            string iMaMon = txtMaKhoa.Text;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = Cnn.CreateCommand())
                {
                    cmd.CommandText = "IdMaK";
                    cmd.CommandType = CommandType.StoredProcedure;
                    Cnn.Open();
                    cmd.Parameters.AddWithValue("@maKhoa", iMaMon);

                    var tmp = cmd.ExecuteScalar();
                    Cnn.Close();

                    if (tmp == null)
                    {
                        cmd.CommandText = "pr_InsertKhoa";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@maK", this.txtMaKhoa.Text);
                        cmd.Parameters.AddWithValue("@TenK", this.txtTenKhoa.Text);
                        cmd.Parameters.AddWithValue("@sSDT", this.txtSDT.Text);
                        cmd.Parameters.AddWithValue("@sDiaChi", this.txtDiaChi.Text);


                        Cnn.Open();
                        cmd.ExecuteNonQuery();
                        Cnn.Close();
                        MessageBox.Show("Thêm mới thành công");
                        LoadDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Ma mon hoc " + iMaMon + " đã tồn tại");
                    }
                }
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "pr_UpdateKhoa";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maK", this.txtMaKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@TenK", this.txtTenKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@sDiaChi", this.txtDiaChi.Text);
                    sqlCommand.Parameters.AddWithValue("@sSDT", this.txtSDT.Text);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    DialogResult dg = MessageBox.Show("Chỉnh sửa thành công");
                    LoadDataToGridView();
                }
            }

        }

        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa Không", "Thông báo", MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "pr_DeleteKhoa";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@maK", txtMaKhoa.Text);
                        
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

        private void btnSearchKhoa_Click(object sender, EventArgs e)
        {
            string tim = "select * from tbl_Khoa where sMaK is not null";
            if (txtTimKhoa.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaK like'%" + txtTimKhoa.Text + "%'";
            }
            else if (txtTimKhoa.Text != "")
            {
                tim = tim + " and sTenK like'%" + txtTimKhoa.Text + "%'";
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvKhoa.DataSource = tb;
                    }

                }
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhoa.CurrentRow.Index;
            txtMaKhoa.Text = dgvKhoa.Rows[index].Cells["sMaK"].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[index].Cells["sTenK"].Value.ToString();
            txtSDT.Text = dgvKhoa.Rows[index].Cells["sSDT"].Value.ToString();
            txtDiaChi.Text = dgvKhoa.Rows[index].Cells["sDiaChi"].Value.ToString();
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

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Length > 0)
            {
                btnThenKhoa.Enabled = true;
            }
            else
            {
                btnThenKhoa.Enabled = false;
            }
        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text.Length > 0)
            {
                btnThenKhoa.Enabled = true;
            }
            else
            {
                btnThenKhoa.Enabled = false;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSDT.Text))
            {
                btnThenKhoa.Enabled = true;
            }
            else
            {
                btnThenKhoa.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length > 0)
            {
                btnThenKhoa.Enabled = true;
            }
            else
            {
                btnThenKhoa.Enabled = false;
            }
        }
    }
}
