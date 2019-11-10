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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            TNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'TNDataSet.BODE' table. You can move, or remove it, as needed.
            this.tbBoDeADT.Fill(this.TNDataSet.BODE);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienDKADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'TNDataSet.LOP' table. You can move, or remove it, as needed.
            this.tbLopADT.Fill(this.TNDataSet.LOP);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.
            this.tbKhoaADT.Fill(this.TNDataSet.KHOA);

            // phân quyền
            // nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc trên cơ sở  đó , không được log vào cơ sở  khác,   
            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong") cbbCoSo.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsKhoa.AddNew();
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsKhoa.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsKhoa.ResetCurrentItem();
                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbKhoaADT.Update(this.TNDataSet.KHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Khoa đã có lớp, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGiaoVien.Count > 0)
            {
                MessageBox.Show("Khoa đã có giáo viên, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.bdsKhoa.Current).Row["TENKH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsKhoa.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbKhoaADT.Update(this.TNDataSet.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsGiaoVien.AddNew();
                //btnAdd.Enabled = btnEdit.Enabled
                //    = btnDel.Enabled = btnRefres     h.Enabled = btnExit.Enabled=false;
                //btnSave.Enabled = btnRevert.Enabled = true;
                //gcGiangVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giáo viên này đã tồn tại trong bảng giảng viên đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Giảng viên này ra đề thi, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên: " + ((DataRowView)this.bdsGiaoVien.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsGiaoVien.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbGiaoVienADT.Update(this.TNDataSet.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnGhiGV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsGiaoVien.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsGiaoVien.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbGiaoVienADT.Update(this.TNDataSet.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnTaiLaiGV_Click(object sender, EventArgs e)
        {
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
        }

        private void btnPhucHoiGV_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGiaoVien.CancelEdit();
        }
    }
}
