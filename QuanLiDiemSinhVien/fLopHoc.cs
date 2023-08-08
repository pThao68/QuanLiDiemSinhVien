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
    public partial class fLopHoc : Form
    {
        private DataView dv_dgv = new DataView();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;

        public fLopHoc()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(string filter = "")
        {
            string querySelect = "pr_DSLopHoc";
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
                                    dgvLop.AutoGenerateColumns = false;
                                    dgvLop.DataSource = tblMonHoc;
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

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string iMaMon = txtMaKhoa.Text;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = Cnn.CreateCommand())
                {
                    cmd.CommandText = "IdMaLp";
                    cmd.CommandType = CommandType.StoredProcedure;
                    Cnn.Open();
                    cmd.Parameters.AddWithValue("@maLop", iMaMon);

                    var tmp = cmd.ExecuteScalar();
                    Cnn.Close();

                    if (tmp == null)
                    {
                        cmd.CommandText = "pr_InsertLop";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@maLp", this.txtMaLp.Text);
                        cmd.Parameters.AddWithValue("@TenLp", this.txtTenLop.Text);
                        cmd.Parameters.AddWithValue("@dTgHoc", this.dtpkThoiGianHoc.Value.ToString("yyyy/MM/d"));
                        cmd.Parameters.AddWithValue("@sMaMon", this.txtMaMon.Text);
                        cmd.Parameters.AddWithValue("@MaK", this.txtMaKhoa.Text);
                        cmd.Parameters.AddWithValue("@iSiSo", this.txtSiSo.Text);


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

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "pr_UpdateLop";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maLp", this.txtMaLp.Text);
                    sqlCommand.Parameters.AddWithValue("@TenLp", this.txtTenLop.Text);
                    sqlCommand.Parameters.AddWithValue("@dTgHoc", this.dtpkThoiGianHoc.Value.ToString("yyyy/MM/d"));
                    sqlCommand.Parameters.AddWithValue("@sMaMon", this.txtMaMon.Text);
                    sqlCommand.Parameters.AddWithValue("@MaK", this.txtMaKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@iSiSo", this.txtSiSo.Text);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    DialogResult dg = MessageBox.Show("Chỉnh sửa thành công");
                    LoadDataToGridView();
                }
            }

        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            //int index = dgvLop.CurrentRow.Index;
            //string maLp = dv_dgv[index]["sMaLp"].ToString();
            try
            {

                DialogResult kq = MessageBox.Show("Bạn có muốn xóa Không", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "pr_DeleteLop";
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@maLp", txtMaLp.Text);
                            
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
            catch
            {

            }
            
        }

        private void btnSearchMon_Click(object sender, EventArgs e)
        {
            string tim = "select * from tbl_LopHoc where sMaLp is not null";
            if (txtTimLopHoc.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaMon like'%" + txtTimLopHoc.Text + "%'";
            }
            else if (txtTimLopHoc.Text != "")
            {
                tim = tim + " and sTenMon like'%" + txtTimLopHoc.Text + "%'";
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvLop.DataSource = tb;
                    }

                }
            }
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvLop.CurrentRow.Index;
            txtMaLp.Text = dgvLop.Rows[index].Cells["sMaLp"].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[index].Cells["sTenLp"].Value.ToString();
            dtpkThoiGianHoc.Text = dgvLop.Rows[index].Cells["dTgHoc"].Value.ToString();
            txtMaMon.Text = dgvLop.Rows[index].Cells["sMaMon"].Value.ToString();
            txtMaKhoa.Text = dgvLop.Rows[index].Cells["sMaK"].Value.ToString();
            txtSiSo.Text = dgvLop.Rows[index].Cells["iSiSo"].Value.ToString();
        }

        private void fLopHoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        
    }
}
