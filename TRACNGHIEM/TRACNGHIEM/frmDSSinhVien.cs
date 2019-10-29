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
    public partial class frmDSSinhVien : Form
    {
        public frmDSSinhVien()
        {
            InitializeComponent();
        }

        private void frmDSSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.tNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.LOP' table. You can move, or remove it, as needed.
            this.tableLop.Fill(this.tNDataSet.LOP);
            // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.tNDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.tNDataSet.COSO);

        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCoSo.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void btnThoatSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form sinh viên", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form sinh viên", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;

            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }
    }
}
