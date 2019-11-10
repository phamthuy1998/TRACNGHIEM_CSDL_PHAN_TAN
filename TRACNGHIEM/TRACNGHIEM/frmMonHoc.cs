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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            TNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.TNDataSet.BODE);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.COSO' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tNDataSet.COSO' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tNDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);

        }

        private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsMonHoc.AddNew();
                //btnAdd.Enabled = btnEdit.Enabled
                //    = btnDel.Enabled = btnRefres     h.Enabled = btnExit.Enabled=false;
                //btnSave.Enabled = btnRevert.Enabled = true;
                //gcGiangVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsMonHoc.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsMonHoc.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbMonHoc.Update(this.TNDataSet.MONHOC);
                MessageBox.Show("Ghi dữ liệu môn học thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Môn học này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDeMH.Count > 0)
            {
                MessageBox.Show("Môn học này đã có bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGiaoVienDkiMH.Count > 0)
            {
                MessageBox.Show("Môn học này đã có giảng viên đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học: " + ((DataRowView)this.bdsMonHoc.Current).Row["TENMH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsMonHoc.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbMonHoc.Update(this.TNDataSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsMonHoc.CancelEdit();
        }

        private void btnTaiLaiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
        }

        private void btnInDanhSachMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoatMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát môn học", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void frmMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát môn học", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }
    }
}
