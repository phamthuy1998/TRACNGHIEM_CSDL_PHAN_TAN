using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DevExpress.UserSkins;
using DevExpress.Skins;

using System.Data;
using System.Data.SqlClient;


namespace TRACNGHIEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TRACNGHIEM";
        public static String remotelogin = "sa";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoSo = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        //public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            // Trả về datable
            DataTable dt = new DataTable();
            //Nếu đang đóng thì mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            // Muốn gọi csdl phải thông qua SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            // Chạy lệnh cmd
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new frmDangNhap());
        }
    }
}
