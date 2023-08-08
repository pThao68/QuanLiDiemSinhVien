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
    public partial class fMonHoc : Form
    {
        private DataView dv_dgv_MH = new DataView();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;
        public fMonHoc()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(string filter = "")
        {
            string querySelect = "pr_DSMonHoc";
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
                                    dv_dgv_MH = tblMonHoc.DefaultView;
                                    // không hiển thị theo ý muốn 
                                    if (filter != null)
                                    {
                                        dv_dgv_MH.RowFilter = filter;
                                    }
                                    //"sMaSV LIKE '%12' AND sHoTen LIKE '%Thao'"; // lọc trường, ko có % là tuyệt ffoid mã nào có số 12 trong đó mới được hiển thị lên
                                    dgvMonHoc.AutoGenerateColumns = false;
                                    dgvMonHoc.DataSource = tblMonHoc;
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
        private void fMonHoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonHoc.CurrentRow.Index;
            txtMaMonHoc.Text = dgvMonHoc.Rows[index].Cells["sMaMon"].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[index].Cells["sTenMon"].Value.ToString();
            txtSoTC.Text = dgvMonHoc.Rows[index].Cells["iSoTC"].Value.ToString();
        }

        private void btnThenMon_Click(object sender, EventArgs e)
        {
            // ktra su ton tai khoa chinh
            string iMaMon = txtMaMonHoc.Text;
            using(SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = Cnn.CreateCommand())
                {
                    cmd.CommandText = "IdMaMon";
                    cmd.CommandType = CommandType.StoredProcedure;
                    Cnn.Open();
                    cmd.Parameters.AddWithValue("@maMon", iMaMon);

                    var tmp = cmd.ExecuteScalar();
                    Cnn.Close();
                    
                    if (tmp == null)
                    {
                        cmd.CommandText = "pr_InsertMonHoc";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@maMon", this.txtMaMonHoc.Text);
                        cmd.Parameters.AddWithValue("@TenMon", this.txtTenMH.Text);
                        cmd.Parameters.AddWithValue("@soTC", this.txtSoTC.Text);

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

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand= sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "pr_UpdateMonHoc";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@maMon", this.txtMaMonHoc.Text);
                    sqlCommand.Parameters.AddWithValue("@TenMon", this.txtTenMH.Text);
                    sqlCommand.Parameters.AddWithValue("@soTC", this.txtSoTC.Text);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    DialogResult dg = MessageBox.Show("Chỉnh sửa thành công");
                    LoadDataToGridView();
                }
            }
        }

        private void btnDeleteMon_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa Không", "Thông báo", MessageBoxButtons.YesNo);
            if(kq== DialogResult.Yes)
            {
                using (SqlConnection sqlConnection= new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "pr_DeleteMonHoc";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@mamon", txtMaMonHoc.Text);
                        DialogResult dg = MessageBox.Show("Bạn đã xóa thành công ", "thông báo");
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        LoadDataToGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSearchMon_Click(object sender, EventArgs e)
        {
            //string filter = "sMaMon IS NOT NULL";
            //if (txtMaMonHoc.Text != null)
            //{
            //    filter += string.Format(" AND sMaMon LIKE '%{0}%'", txtMaMonHoc.Text);

            //}
            //if (!string.IsNullOrEmpty(txtTenMH.Text))
            //{
            //    filter += string.Format(" AND sTenMon Like '%{0}%'", txtTenMH.Text);
            //}
            //if (!string.IsNullOrEmpty(txtTenMH.Text))
            //{
            //    filter += string.Format(" AND iSoTC Like '%{0}%'", txtSoTC.Text);
            //}

            //// các truowngf dữ liệu tương ứng với các control
            //LoadDataToGridView(filter);


            string tim = "select * from tbl_MonHoc where sMaMon is not null";
            if (txtTimMonHoc.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaMon like'%" + txtTimMonHoc.Text + "%'";
            }
            else if (txtTimMonHoc.Text != "")
            {
                tim = tim + " and sTenMon like'%" + txtTimMonHoc.Text + "%'";
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvMonHoc.DataSource = tb;
                    }

                }
            }
        }
    }
}
