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
        private int dem = 0;
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


        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbCoSo.SelectedValue != null && dem != 0)
                {

                    Program.servername1 = cbbCoSo.SelectedValue.ToString();
                    if (Program.KetNoiCosoKhac() == 0) return;
                    else
                    {
                        Program.conn.ConnectionString = Program.connstr1;
                        // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
                        this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
                        // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                        this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
                        // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
                        // gán chuỗi kết nối được lấy từ form đăng nhập trước khi fiew dữ liêu về
                        this.tbSinhVienADT.Connection.ConnectionString = Program.connstr1;
                        this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
                        // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
                        this.tbDSKhoaADT.Connection.ConnectionString = Program.connstr1;
                        this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
                        // TODO: This line of code loads data into the 'tNDataSet.LOP' table. You can move, or remove it, as needed.
                        this.tbLopADT.Connection.ConnectionString = Program.connstr1;
                        this.tbLopADT.Fill(this.TNDataSet.LOP);
                    }
                }
            }
            catch (Exception) { };
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            TNDataSet.EnforceConstraints = false;

            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoSo;

            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
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

            // phân quyền
            // nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc trên cơ sở  đó , không được log vào cơ sở  khác,   
            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                btnThemSV.Visible = btnGhiSV.Visible = btnXoaSV.Visible = btnPhucHoiSV.Visible = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThemSV.Visible = btnGhiSV.Visible = btnXoaSV.Visible= btnPhucHoiSV.Visible= false;
            }
            dem++;
        }

        private void tENKHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaKhoa.Text = cbbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsSinhVien.AddNew();
                //btnAdd.Enabled = btnEdit.Enabled
                //    = btnDel.Enabled = btnRefres     h.Enabled = btnExit.Enabled=false;
                //btnSave.Enabled = btnRevert.Enabled = true;
                //gcGiangVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsSinhVien.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsSinhVien.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbSinhVienADT.Update(this.TNDataSet.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Sinh viên này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên : " + ((DataRowView)this.bdsSinhVien.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsSinhVien.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbSinhVienADT.Update(this.TNDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsLop.AddNew();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsLop.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsLop.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbLopADT.Update(this.TNDataSet.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Lớp học đã có sinh viên, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGiaoVienDK.Count > 0)
            {
                MessageBox.Show("Lớp học đã có giảng viên đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học : " + ((DataRowView)this.bdsLop.Current).Row["TENLOP"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsLop.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbLopADT.Update(this.TNDataSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp học " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsLop.CancelEdit();
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tbLopADT.Fill(this.TNDataSet.LOP);
        }

        private void btnInDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form lóp", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void frmLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form lớp", "", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            this.Close();
            //}
            //else e.Cancel = true;
        }

        private void btnTaiLaiSV_Click(object sender, EventArgs e)
        {
            this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsSinhVien.CancelEdit();
        }

    }
}
