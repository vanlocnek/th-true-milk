using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Main
{
    class DBS
    {
        private string ConnectString = @"Data Source=VANLOC\SQLEXPRESS;Initial Catalog=QLBH_LOC;Integrated Security=True";
        private SqlConnection sqlConn;

        public void Connect()
        {
            this.sqlConn = new SqlConnection();
            this.sqlConn.ConnectionString = this.ConnectString;
            this.sqlConn.Open();
        }

        public void TestConnect()
        {
            try
            {
                this.sqlConn = new SqlConnection();
                this.sqlConn.ConnectionString = this.ConnectString;
                this.sqlConn.Open();
                MessageBox.Show("Kết nối máy chủ thành công, Nhấn OK để tiếp tục", "TH True Milk Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới máy chủ!!!", "TH True Milk Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Disconnect()
        {
            if (this.sqlConn.State == ConnectionState.Open)
            {
                this.sqlConn.Close();
                this.sqlConn.Dispose();
                this.sqlConn = null;
            }
        }

        public Boolean Get(string sqlGet, DataTable data)
        {
            bool isSuccess = false;
            SqlDataAdapter adapter;

            try
            {
                adapter = new SqlDataAdapter(sqlGet, this.sqlConn);
                adapter.Fill(data);

                if (data.Rows.Count != 0)
                    isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hàm GET chạy không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }

        public void Post(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = this.sqlConn;
            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hàm POST chạy không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
