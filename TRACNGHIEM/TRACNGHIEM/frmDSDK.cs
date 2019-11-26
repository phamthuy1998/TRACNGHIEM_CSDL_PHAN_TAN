using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class frmDSDK : Form
         
    {
        public static Boolean status = false;
        public static String _coso = "";
        private  int dem = 0;
        //private DateTime _dateFrom;
        //private DateTime _dateTo;

        private String _dateFrom;
        private String _dateTo;

        public frmDSDK()
        {
            InitializeComponent();
        }

        private void frmDSDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.ControlBox = false;
            Program.connstr1 = Program.connstr;
            tNDataSet.EnforceConstraints = false;
            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbPRCoso.DataSource = Program.bds_dspm.DataSource;
            cbbPRCoso.DisplayMember = "TENCS";
            cbbPRCoso.ValueMember = "TENSERVER";
            

            if (Program.mGroup == "Truong")
            {
                cbbPRCoso.Enabled = true;
                cbbPRCoso.SelectedIndex = 1;
            }
            else if (Program.mGroup == "Coso")
            {
                cbbPRCoso.Enabled = false;
                cbbPRCoso.SelectedIndex = Program.mCoSo;
            }
            dem++;

        }

        private void cbbPRCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPRCoso.SelectedValue != null && dem != 0)
            {
                status = true;
                _coso = cbbPRCoso.SelectedValue.ToString();
            }
            
        }

        private void dateFrom_EditValueChanged(object sender, EventArgs e)
        {
            _dateFrom = dateFrom.Text;
            Console.WriteLine("test" + _dateFrom);
        }

        private void dateTo_EditValueChanged(object sender, EventArgs e)
        {
            _dateTo = dateTo.Text;
            Console.WriteLine("test" + _dateTo);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (dateFrom.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dateTo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var FromDate = dateFrom.DateTime;
            var ToDate = dateTo.DateTime;
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                // ngày bắt đầu không thể lớn hơn ngày kết thúc
                MessageBox.Show("ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            } else
            {
                if (cbbPRCoso.SelectedValue != null && dem != 0)
                {
                    Program.servername1 = cbbPRCoso.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0)
                    {
                        this.sP_DanhSach_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sP_DanhSach_DK_ThiTableAdapter.Fill(this.tNDataSet.SP_DanhSach_DK_Thi, FromDate, ToDate);
                    }
                    else
                    {
                        this.sP_DanhSach_DK_ThiTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_DanhSach_DK_ThiTableAdapter.Fill(this.tNDataSet.SP_DanhSach_DK_Thi, FromDate, ToDate);

                    }
                }
            }
           
        }

        private void btnInDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dateFrom.Text.ToString().Trim().Equals("") || dateTo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn phải chọn ngày bắt đầu và ngày kết thúc trước", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var FromDate = dateFrom.DateTime;
            var ToDate = dateTo.DateTime;
            var CoSo = cbbPRCoso.Text;
            rpDSDKThi rpDSDKT = new rpDSDKThi(FromDate, ToDate);

            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                // ngày bắt đầu không thể lớn hơn ngày kết thúc
                MessageBox.Show("ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }
            else
            {
                Console.WriteLine("nagy" + ToDate.ToString("dd/MM/yyyy"));
                rpDSDKT.lbCoso.Text = CoSo;
                rpDSDKT.lbDateFrom.Text = FromDate.ToString("dd/MM/yyyy");
                rpDSDKT.lbDateTo.Text = ToDate.ToString("dd/MM/yyyy");

                ReportPrintTool report = new ReportPrintTool(rpDSDKT);
                report.ShowPreviewDialog();
            }

           
        }

        private void btnThoatDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
