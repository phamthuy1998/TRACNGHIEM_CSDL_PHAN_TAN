using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            TNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            // gán chuỗi kết nối được lấy từ form đăng nhập trước khi fiew dữ liêu về
            this.tbSinhVienADT.Connection.ConnectionString = Program.connstr;
            this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
            this.tbDSKhoaADT.Connection.ConnectionString = Program.connstr;
            this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
            // TODO: This line of code loads data into the 'tNDataSet.LOP' table. You can move, or remove it, as needed.
            this.tbLopADT.Connection.ConnectionString = Program.connstr;
            this.tbLopADT.Fill(this.TNDataSet.LOP);

        }

        private void tENKHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaKhoa.Text = cbbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi load dữ liệu khoa: "+ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
