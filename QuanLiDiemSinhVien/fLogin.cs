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
    public partial class fLogin : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDiem"].ConnectionString;

        public fLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //    {

            //        string tk = txtUserName.Text;
            //        string mk = txtPassWord.Text;
            //        using (SqlCommand sqlCommand= sqlConnection.CreateCommand())
            //        {
            //            sqlConnection.Open();
            //            sqlCommand.CommandText = "pr_DangNhap"; 
            //            sqlCommand.CommandType = CommandType.StoredProcedure;

            //            sqlCommand.Parameters.AddWithValue("@username", tk);
            //            sqlCommand.Parameters.AddWithValue("@pass", mk);
            //            sqlCommand.ExecuteNonQuery();
            //            sqlConnection.Close();
            //            fMenu f = new fMenu();
            //            this.Hide();
            //            f.ShowDialog();


            //        }
            //    }
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Đăng nhập sai tài khoản, thử lại", "Thông Báo");
            //}
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                string tk = txtUserName.Text;
                string mk = txtPassWord.Text;
                string sql = "select * from tblUser where tblUser.username='" + tk + "'and pass ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    fMenu f = new fMenu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

                else
                {
                    //dem++;
                    MessageBox.Show("Đăng nhập thất bại, thử lại", "Thông Báo");
                    //if (dem == 3)
                    //{
                    //    MessageBox.Show("Tài khoản của bạn bị khóa");
                    //    btnLogin.Enabled = false;
                    //    FormThatBai fm = new FormThatBai();
                    //    fm.Show();
                    //    this.Hide();
                    //}
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập sai tài khoản, thử lại", "Thông Báo");
            }

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
