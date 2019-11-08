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
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
<<<<<<< Updated upstream
            if (bdsBoDeGV.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã làm bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGVDangKy.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã được đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDeGV.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã làm bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên "+ ((DataRowView)this.bdsGV.Current).Row["TEN"].ToString()+"?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsGV.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.gIAOVIENTableAdapter1.Update(this.tNDataSet.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
=======
           
>>>>>>> Stashed changes
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.tNDataSet.COSO);

            this.gIAOVIENTableAdapter1.Fill(this.tNDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.tNDataSet.BODE);
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.tNDataSet.BODE);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN' table. You can move, or remove it, as needed.

            //DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable("Select MACS from COSO");
            //BindingSource bdsCoSo = new BindingSource();
            //bdsCoSo.DataSource = dt;
            //Program.mTenCoSo = ((DataRowView) bdsCoSo[0])["MACS"].ToString();

            //cbbCoSoGV.DataSource = Program.bds_dspm;
            //cbbCoSoGV.DisplayMember = "TENCS";
            //cbbCoSoGV.ValueMember = "TENSERVER";
            //cbbCoSoGV.SelectedIndex = Program.mCoSo;
            //if (Program.mGroup == "Truong") cbbCoSoGV.Enabled = true;
            //else cbbCoSoGV.Enabled = false;

        }

        private void frmGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form giảng viên", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGV.AddNew();
                //btnAdd.Enabled = btnEdit.Enabled
                //    = btnDel.Enabled = btnRefres     h.Enabled = btnExit.Enabled=false;
                //btnSave.Enabled = btnRevert.Enabled = true;
                //gcGiangVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
<<<<<<< Updated upstream

        }

        private void btnRevert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGV.CancelEdit();
        }

        // Lấy dữ liệu mới nhất trong csdl 
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter1.Fill(this.tNDataSet.GIAOVIEN);
        }
=======
            if (bdsBoDeGV.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã làm bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGVDangKy.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã được đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
>>>>>>> Stashed changes

            if (bdsBoDeGV.Count > 0)
            {
                MessageBox.Show("Giảng viên này đã làm bộ đề, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên " + ((DataRowView)this.bdsGV.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsGV.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbGiaoVien.Update(this.TNDataSet.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGV.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsGV.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.gIAOVIENTableAdapter1.Update(this.tNDataSet.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGV.CancelEdit();
        }

        private void btnTailai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tbGiaoVien.Fill(this.TNDataSet.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lại danh sách giảng viên: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form giảng viên?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }
    }
}
