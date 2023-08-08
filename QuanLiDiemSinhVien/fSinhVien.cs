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
    public partial class fSinhVien : Form
    {
        private DataView dv_tblLop = new DataView();
        private DataView dv_dgv = new DataView();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;

        public fSinhVien()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(string filter = "")
        {
            string querySelect = "pr_Tonghop";
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
                                    dgvSV.AutoGenerateColumns = false;
                                    dgvSV.DataSource = tblMonHoc;
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
            string querySelect = "pr_DSKhoa";
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

                                    cbMaKhoa.DataSource = dv_tblLop;
                                    cbMaKhoa.ValueMember = "sMaK";// khoa chinh
                                                                     // truowngf hien thi len DisplayMemer
                                    cbMaKhoa.DisplayMember = "sMaK";
                                    cbMaKhoa.Text = string.Empty;// ko có giá trị trước
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
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            LoadDataToComboBox();
        }

        private void btnThenKhoa_Click(object sender, EventArgs e)
        {
            string gioitinh = "";

            if (rb_nam.Checked == true)// nếu dduwwocj check
            {
                gioitinh = "nam";

            }
            else if (rb_nu.Checked == true)// nếu được check
            {
                gioitinh = "nữ";
            }
            string iMa = txtMaSV.Text;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = Cnn.CreateCommand())
                {
                    cmd.CommandText = "IdMaSV";
                    cmd.CommandType = CommandType.StoredProcedure;
                    Cnn.Open();
                    cmd.Parameters.AddWithValue("@maSV", iMa);

                    var tmp = cmd.ExecuteScalar();
                    Cnn.Close();

                    if (tmp == null)
                    {
                        cmd.CommandText = "pr_InsertSV";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@sMaSV", this.txtMaSV.Text);
                        cmd.Parameters.AddWithValue("@sHoTen", this.txtTenSV.Text);
                        cmd.Parameters.AddWithValue("@sDiaChi", this.txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@sCMND", this.txtCMND.Text);
                        cmd.Parameters.AddWithValue("@sSDT", this.txtSdt.Text);
                        cmd.Parameters.AddWithValue("@sMaK", this.cbMaKhoa.Text);
                        cmd.Parameters.AddWithValue("@bGT", IsGender(gioitinh));
                        cmd.Parameters.AddWithValue("@dNgaySinh", this.dtpk_Ngaysinh.Value.ToString("yyyy/MM/d"));

                        Cnn.Open();
                        cmd.ExecuteNonQuery();
                        Cnn.Close();
                        MessageBox.Show("Thêm mới thành công");
                        LoadDataToGridView();
                    }
                    else
                    {
                        MessageBox.Show("Ma mon hoc " + iMa + " đã tồn tại");
                    }
                }
            }

        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            string gioitinh = "";

            if (rb_nam.Checked == true)// nếu dduwwocj check
            {
                gioitinh = "nam";

            }
            else if (rb_nu.Checked == true)// nếu được check
            {
                gioitinh = "nữ";
            }
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "pr_UpdateSV";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@sMaSV", this.txtMaSV.Text);
                    sqlCommand.Parameters.AddWithValue("@sHoTen", this.txtTenSV.Text);
                    sqlCommand.Parameters.AddWithValue("@sDiaChi", this.txtDiaChi.Text);
                    sqlCommand.Parameters.AddWithValue("@sCMND", this.txtCMND.Text);
                    sqlCommand.Parameters.AddWithValue("@sSDT", this.txtSdt.Text);
                    sqlCommand.Parameters.AddWithValue("@sMaK", this.cbMaKhoa.Text);
                    sqlCommand.Parameters.AddWithValue("@bGT", IsGender(gioitinh));
                    sqlCommand.Parameters.AddWithValue("@dNgaySinh", this.dtpk_Ngaysinh.Value.ToString("yyyy/MM/d"));

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
            int index = dgvSV.CurrentRow.Index;
           string maSV = dgvSV.Rows[index].Cells["sMaSV"].Value.ToString();
            try
            {

                DialogResult kq = MessageBox.Show("Bạn có muốn xóa Không", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = "pr_DeleteSV";
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
            catch(Exception ex)
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

        private void btnSearchKhoa_Click(object sender, EventArgs e)
        {
            string tim = "select * from tbl_SinhVien where sMaSV is not null";
            if (txtTimKhoa.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sMaSV like'%" + txtTimKhoa.Text + "%'";
            }
            else if (txtTimKhoa.Text != "")
            {
                tim = tim + " and sHoTen like'%" + txtTimKhoa.Text + "%'";
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(tim, cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvSV.DataSource = tb;
                    }

                }
            }

        }
        public static bool IsGender(string gioiTinh)
        {
            bool index;
            if (gioiTinh.ToLower() == "nam")
            {
                index = true;
            }
            else
            {
                index = false;
            }
            return index;
        }
        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgvSV.CurrentRow.Index;
            bool gioitinh =IsGender(dgvSV.Rows[index].Cells["bGT"].Value.ToString());
            txtMaSV.Text = dgvSV.Rows[index].Cells["sMaSV"].Value.ToString();
            txtTenSV.Text = dgvSV.Rows[index].Cells["sHoTen"].Value.ToString();
            
            txtDiaChi.Text = dgvSV.Rows[index].Cells["sDiaChi"].Value.ToString();
            txtSdt.Text = dgvSV.Rows[index].Cells["sSDT"].Value.ToString();
            dtpk_Ngaysinh.Text= dgvSV.Rows[index].Cells["dNgaySinh"].Value.ToString();
            txtCMND.Text = dgvSV.Rows[index].Cells["sCMND"].Value.ToString();
            cbMaKhoa.Text= dgvSV.Rows[index].Cells["sMaK"].Value.ToString();
            if (gioitinh)
            {
                rb_nam.Checked = true;
            }
            else
            {
                rb_nu.Checked = true;
            }
        }

        private void btnInKhoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
