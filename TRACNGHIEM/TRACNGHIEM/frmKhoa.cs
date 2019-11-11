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
        private int dem = 0;
        private Boolean checkThem = false;
        private Boolean checkXoa = false;
        private Boolean checkSua = false;

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
            gcKhoa.UseDisabledStatePainter = false;
            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoSo;

            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCoSoAdd.DataSource = Program.bds_dspm.DataSource;
            cbbCoSoAdd.DisplayMember = "TENCS";
            cbbCoSoAdd.ValueMember = "MACS";
            cbbCoSoAdd.SelectedIndex = Program.mCoSo;
            cbbCoSoAdd.Enabled = false;
            txtMaCS.Text = cbbCoSoAdd.SelectedIndex.ToString();

            // TODO: This line of code loads data into the 'TNDataSet.BODE' table. You can move, or remove it, as needed.
            this.tbBoDeADT.Connection.ConnectionString = Program.connstr;
            this.tbBoDeADT.Fill(this.TNDataSet.BODE);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

            this.tbGiaoVienDKADT.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVienDKADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'TNDataSet.LOP' table. You can move, or remove it, as needed.

            this.tbLopADT.Connection.ConnectionString = Program.connstr;
            this.tbLopADT.Fill(this.TNDataSet.LOP);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN' table. You can move, or remove it, as needed.

            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.

            this.tbKhoaADT.Connection.ConnectionString = Program.connstr;
            this.tbKhoaADT.Fill(this.TNDataSet.KHOA);

            // phân quyền
            // nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc trên cơ sở  đó , không được log vào cơ sở  khác,   
            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                btnThemGV.Visible = btnGhiGV.Visible = btnXoaGV.Visible = btnPhucHoiGV.Visible = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThemGV.Visible = btnGhiGV.Visible = btnXoaGV.Visible = btnPhucHoiGV.Visible = false;
            }
            txtMaKH.Enabled = txtTenKH.Enabled = false;
            dem++;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsKhoa.AddNew();
                checkThem = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = btnInDS.Enabled = false;
                txtMaKH.Focus();
                btnGhi.Enabled = true;
                gcKhoa.Enabled = false;
                gcGiaoVien.Enabled = false;
                ctxMenuGV.Enabled = false;
                txtMaKH.Enabled = txtTenKH.Enabled = true;
                txtMaCS.Text = cbbCoSoAdd.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private int ghiKhoa()
        {
            try
            {
                bdsKhoa.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsKhoa.ResetCurrentItem();
                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbKhoaADT.Update(this.TNDataSet.KHOA);

                checkThem = false;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = btnInDS.Enabled = true;
                txtMaKH.Focus();
                btnGhi.Enabled = true;
                gcKhoa.Enabled = true;
                gcGiaoVien.Enabled = true;
                ctxMenuGV.Enabled = true;
                txtMaKH.Enabled = txtTenKH.Enabled = false;
                cbbCoSoAdd.Enabled = false;
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.Text.Equals(""))
            {
                MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Equals(""))
            {
                MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }

            //if ()
                ghiKhoa();
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
                        // TODO: This line of code loads data into the 'TNDataSet.BODE' table. You can move, or remove it, as needed.
                        this.tbBoDeADT.Connection.ConnectionString = Program.connstr1;
                        this.tbBoDeADT.Fill(this.TNDataSet.BODE);
                        // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.

                        this.tbGiaoVienDKADT.Connection.ConnectionString = Program.connstr1;
                        this.tbGiaoVienDKADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
                        // TODO: This line of code loads data into the 'TNDataSet.LOP' table. You can move, or remove it, as needed.

                        this.tbLopADT.Connection.ConnectionString = Program.connstr1;
                        this.tbLopADT.Fill(this.TNDataSet.LOP);
                        // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN' table. You can move, or remove it, as needed.

                        this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr1;
                        this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
                        // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.

                        this.tbKhoaADT.Connection.ConnectionString = Program.connstr1;
                        this.tbKhoaADT.Fill(this.TNDataSet.KHOA);

                        cbbCoSoAdd.SelectedIndex = Program.mCoSo;
                        txtMaCS.Text = cbbCoSoAdd.SelectedValue.ToString();
                    }
                }
            }
            catch (Exception) { };
        }

        private void btnSuaK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkSua = true;
            btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = btnInDS.Enabled = false;
            txtMaKH.Focus();
            btnGhi.Enabled = true;
            gcKhoa.Enabled = false;
            gcGiaoVien.Enabled = false;
            cbbCoSoAdd.Enabled = true;
            ctxMenuGV.Enabled = false;
            txtTenKH.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsKhoa.CancelEdit();
            btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = btnInDS.Enabled = true;
            txtMaKH.Focus();
            checkThem = false;
            btnGhi.Enabled = true;
            gcKhoa.Enabled = true;
            gcGiaoVien.Enabled = true;
            ctxMenuGV.Enabled = true;
            this.tbKhoaADT.Fill(this.TNDataSet.KHOA);
            txtMaKH.Enabled = txtTenKH.Enabled = false;
            cbbCoSoAdd.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo khoa mới, nếu không ghi khoa mới sẽ không được lưu, bạn có muốn ghi khoa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ghiKhoa();
                        // ghi xong đóng form
                        //Close();
                        //checkThem = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form lớp", "", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            //  this.Close();
            //}
            //else e.Cancel = true;
        }

        private void btnInDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tbKhoaADT.Fill(this.TNDataSet.KHOA);
        }

        private void cbbCoSoAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaCS.Text = cbbCoSoAdd.SelectedValue.ToString();
        }
    }
}
