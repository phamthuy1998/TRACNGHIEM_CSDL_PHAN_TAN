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
    public partial class frmBangDiem : Form
    {
        private String maLop = "", maMH = "";
        private int lan = 1;
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBangDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiem.Fill(this.tNDataSet.BANGDIEM);
            cbbCoSo.DataSource = Program.bds_dspm;

        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void frmBangDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
