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
        private Boolean checkThem = false;
        private Boolean checkXoa = false;
        private Boolean checkSua = false;
        private Boolean checkThemSV = false;
        private Boolean checkXoaSV = false;
        private Boolean checkChuyenLop = false;
        private Boolean checkSuaSV = false;
        public static Boolean checkSave = true;

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
                        tbBangDiemADT.Connection.ConnectionString = Program.connstr1;
                        this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
                        // giao vien dang ky
                        this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr1;
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
            // TODO: This line of code loads data into the 'TNDataSet.DSLOP' table. You can move, or remove it, as needed.
            this.ControlBox = false;
            TNDataSet.EnforceConstraints = false;
            gcSinhVien.UseDisabledStatePainter = false;
            gcLop.UseDisabledStatePainter = false;
            // Lấy kết danh sách phân mảnh đổ vào combobox
            try
            {
                if (Program.bds_dspm.DataSource != null)
                {
                    cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                    cbbCoSo.DisplayMember = "TENCS";
                    cbbCoSo.ValueMember = "TENSERVER";
                    cbbCoSo.SelectedIndex = Program.mCoSo;
                }
                else
                {
                    MessageBox.Show("Lỗi load dữ liệu cơ sở ", "Lỗi", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu cơ sở " + ex.Message, "", MessageBoxButtons.OK);
            }
            this.tbDSLopADT.Connection.ConnectionString = Program.connstr;
            this.tbDSLopADT.Fill(this.TNDataSet.DSLOP);
            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);

            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
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
                btnThemSV.Visible = btnSuaSV.Visible = btnChuyenLop.Visible = btnGhiSV.Visible = btnXoaSV.Visible = btnPhucHoiSV.Visible = true;
                btnThem.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                btnThem.Visibility = btnSuaL.Visibility= btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThemSV.Visible = btnSuaSV.Visible = btnChuyenLop.Visible = btnGhiSV.Visible = btnXoaSV.Visible = btnPhucHoiSV.Visible = false;
            }
            dem++;
            pcSV.Enabled = pcLop.Enabled = false;
            if ((DataRowView)this.bdsSinhVien.Current != null)
            {
                cbbTenLop.SelectedItem = ((DataRowView)this.bdsLop.Current);
            }

        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                bdsSinhVien.AddNew();

                btnThem.Enabled = btnSuaL.Enabled = btnXoa.Enabled = btnGhi.Enabled
                    = btnPhucHoi.Enabled = btnTaiLai.Enabled = false;

                pcLop.Enabled = false;

                pcSV.Enabled = true;

                gcSinhVien.Enabled = gcLop.Enabled = false;

                btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = false;
                btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
                edtMaSV.Enabled = edtHo.Enabled = edtTen.Enabled = edtNgaySInh.Enabled = edtDiaChi.Enabled = true;
                cbbTenLop.Enabled = false;
                checkThemSV = true;
                // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
                cbbTenLop.SelectedValue = edtMaLop.Text;
                edtMaLopSV.Text = ((DataRowView)this.bdsLop.Current).Row["MALOP"].ToString();
                checkSave = false;
                panelTimGV.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiSinhVien()
        {
            try
            {
                bdsSinhVien.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsSinhVien.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbSinhVienADT.Update(this.TNDataSet.SINHVIEN);

                this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
                this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
                // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
                this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
                // gán chuỗi kết nối được lấy từ form đăng nhập trước khi fiew dữ liêu về
                this.tbSinhVienADT.Connection.ConnectionString = Program.connstr;
                this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
                this.tbDSKhoaADT.Connection.ConnectionString = Program.connstr;
                this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);

                btnThem.Enabled = btnSuaL.Enabled
                    = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnPhucHoi.Enabled = true;
                pcLop.Enabled = pcSV.Enabled = false;

                gcLop.Enabled = gcSinhVien.Enabled = true;
                checkThemSV = checkSuaSV = checkXoaSV = false;

                btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = true;
                btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
                checkSave = true;
                panelTimGV.Enabled = true;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (checkThemSV == true)
            {
                if (edtMaSV.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtHo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtTen.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtNgaySInh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtDiaChi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Địa chỉ của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                String sql = "EXEC SP_KTSV_TONTAI '" + edtMaSV.Text.Trim().ToString() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaSV.Focus();
                    return;
                }
                else
                {
                    ghiSinhVien();
                }

            }
            else if (checkSuaSV == true)
            {
                if (edtHo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtTen.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtNgaySInh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                if (edtDiaChi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Địa chỉ của sinh viên không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                checkSuaSV = false;
                ghiSinhVien();
            }
            else if (checkChuyenLop == true)
            {

                String sql = "EXEC SP_CHUYENLOP N'" + edtMaLopSV.Text.Trim() + "', N'" + edtMaSV.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                // thành công
                btnThem.Enabled = btnSuaL.Enabled
                    = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnPhucHoi.Enabled = true;
                pcLop.Enabled = pcSV.Enabled = false;

                gcLop.Enabled = gcSinhVien.Enabled = true;
                checkThemSV = checkSuaSV = checkXoaSV = false;

                btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = true;
                btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
                checkChuyenLop = false;
                this.tbDSLopADT.Connection.ConnectionString = Program.connstr;
                this.tbDSLopADT.Fill(this.TNDataSet.DSLOP);
                // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
                this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
                this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);

                // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
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
            }
            else
            {
                ghiSinhVien();
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
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
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gcLop.Enabled = gcSinhVien.Enabled = false;
                bdsLop.AddNew();
                btnThem.Enabled = btnSuaL.Enabled = btnXoa.Enabled = false;
                ctxMenuSV.Enabled = false;
                pcLop.Enabled = true;
                this.tbDSKhoaADT.Connection.ConnectionString = Program.connstr;
                this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
                cbbTenKhoa.SelectedIndex = 0;
                edtMaKH.Text = cbbTenKhoa.SelectedValue.ToString();
                edtMaLop.Enabled = edtTenLop.Enabled = true;
                checkThem = true;
                panelTimGV.Enabled = false;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiLop()
        {
            try
            {
                bdsLop.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsLop.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbLopADT.Update(this.TNDataSet.LOP);
                btnThem.Enabled = btnSuaL.Enabled
                   = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnPhucHoi.Enabled = true;
                pcLop.Enabled = pcSV.Enabled = false;

                gcLop.Enabled = gcSinhVien.Enabled = true;
                checkThem = checkSua = checkXoa = false;

                ctxMenuSV.Enabled = true;

                btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = true;
                btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
                checkSave = true;
                panelTimGV.Enabled = true;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi lớp" + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (edtMaLop.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã lớp không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                if (edtTenLop.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên lớp không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                String sql = "EXEC SP_KT_LOP_TONTAI N'" + edtMaLop.Text.Trim() + "', N'" + edtTenLop.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaLop.Focus();
                    return;
                }
                else
                {
                    ghiLop();
                    checkThem = false;
                }

            }
            else if (checkSua == true)
            {
                if (edtTenLop.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên lớp không được để trống, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }

                String sql = "EXEC SP_KTMALop_TONTAI '" + edtMaLop.Text.Trim() + "', N'" + edtTenLop.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTenLop.Focus();
                    return;
                }
                else
                {
                    ghiLop();
                    checkSua = false;
                }
            }
            else
            {
                ghiLop();
                checkSua = false;
                checkThem = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có lớp để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
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
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
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
            btnThem.Enabled = btnSuaL.Enabled
            = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnPhucHoi.Enabled = true;
            pcLop.Enabled = pcSV.Enabled = false;

            gcLop.Enabled = gcSinhVien.Enabled = true;
            checkThem = checkSua = checkXoa = false;

            ctxMenuSV.Enabled = true;
            panelTimGV.Enabled = true;

            btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            // gán chuỗi kết nối được lấy từ form đăng nhập trước khi fiew dữ liêu về
            this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
            this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
            // TODO: This line of code loads data into the 'tNDataSet.LOP' table. You can move, or remove it, as needed.
            this.tbLopADT.Fill(this.TNDataSet.LOP);
            edtTimSV.Text = "";
        }

        public void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới lớp, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else if (checkSua == true)
            {
                if (MessageBox.Show("Bạn đang sửa lớp, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            //Thêm mới giảng viên
            else if (checkThemSV == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới sinh viên, bạn có muốn lưu thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiSV_Click(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            //Sửa thông tin giảng viên
            else if (checkSuaSV == true)
            {
                if (MessageBox.Show("Bạn đang sửa sinh viên, bạn có muốn lưu thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiSV_Click(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else if (checkChuyenLop == true)
            {
                if (MessageBox.Show("Bạn đang chuyển lớp, bạn có muốn lưu thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiSV_Click(sender, e);
                    if (checkSave == true)
                        this.Close();
                    else
                        return;
                }
                else
                {
                    checkSave = true;
                    Close();
                }
            }
            else
            {
                checkSave = true;
                this.Close();
            }

        }

        private void btnTaiLaiSV_Click(object sender, EventArgs e)
        {
            edtTimSV.Text = "";
            this.tbSinhVienADT.Connection.ConnectionString = Program.connstr;
            this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsSinhVien.CancelEdit();

            // TODO: This line of code loads data into the 'TNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'TNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
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

            btnThem.Enabled = btnSuaL.Enabled
                    = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnPhucHoi.Enabled = true;
            pcLop.Enabled = pcSV.Enabled = false;

            gcLop.Enabled = gcSinhVien.Enabled = true;
            checkThemSV = checkSuaSV = checkXoaSV = false;
            panelTimGV.Enabled = true;

            btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = true;
            btnGhiSV.Enabled = btnPhucHoiSV.Enabled = btnTaiLaiSV.Enabled = true;
        }

        private void btnSuaL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có lớp để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                edtMaLop.Enabled = false;
                btnThem.Enabled = btnSuaL.Enabled = btnXoa.Enabled = false;
                ctxMenuSV.Enabled = false;
                pcLop.Enabled = true;
                gcLop.Enabled = gcSinhVien.Enabled = false;
                this.tbDSKhoaADT.Connection.ConnectionString = Program.connstr;
                this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
                cbbTenKhoa.SelectedValue = ((DataRowView)this.bdsLop.Current).Row["MAKH"].ToString();
                edtMaKH.Text = cbbTenKhoa.SelectedValue.ToString();
                checkSua = true;
                panelTimGV.Enabled = false;
                checkSave = false;
            }
        }

        private void cbbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaKH.Text = cbbTenKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                btnThem.Enabled = btnSuaL.Enabled = btnXoa.Enabled
                    = btnPhucHoi.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = false;
                pcLop.Enabled = false;
                gcLop.Enabled = gcSinhVien.Enabled = false;
                pcSV.Enabled = true;
                btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = false;
                edtMaSV.Enabled = false;
                edtHo.Enabled = edtTen.Enabled = edtNgaySInh.Enabled = edtDiaChi.Enabled = true;
                cbbTenLop.Enabled = false;
                checkSuaSV = true;
                checkSave = false;
                panelTimGV.Enabled = false;
            }
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                MessageBox.Show("Không có sinh viên để chuyển lớp!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                if (cbbTenLop.Items.Count == 0)
                {
                    MessageBox.Show("Không có lớp để chuyển!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    btnThem.Enabled = btnSuaL.Enabled = btnXoa.Enabled
                  = btnPhucHoi.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = false;
                    pcLop.Enabled = false;
                    pcSV.Enabled = true;
                    gcLop.Enabled = gcSinhVien.Enabled = false;
                    btnThemSV.Enabled = btnSuaSV.Enabled = btnChuyenLop.Enabled = btnXoaSV.Enabled = false;
                    edtMaSV.Enabled = false;
                    edtHo.Enabled = edtTen.Enabled = edtNgaySInh.Enabled = edtDiaChi.Enabled = false;
                    cbbTenLop.Enabled = true;
                    checkChuyenLop = true;
                    cbbTenLop.SelectedText = edtMaLopSV.Text;
                    checkSave = false;
                    panelTimGV.Enabled = false;
                }
            }
        }

        private void edtTimSV_EditValueChanged(object sender, EventArgs e)
        {
            String tim = edtTimSV.Text.Trim();
            if (!tim.Equals(""))
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MASV from dbo.SINHVIEN WHERE MASV  LIKE '%"
                   + tim + "%' OR HO  LIKE '%" + tim + "%' OR TEN LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.conn.Close();
                if (!kqTimkiem.Equals(""))
                    bdsSinhVien.Filter = "MASV IN (" + kqTimkiem + ")";
            }
            else
            {
                bdsSinhVien.Filter = "";
                this.tbSinhVienADT.Connection.ConnectionString = Program.connstr;
                this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String tim = edtTimSV.Text.Trim();
            if (tim.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tìm kiếm", "", MessageBoxButtons.OK);
                this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
                this.tbSinhVienADT.Fill(this.TNDataSet.SINHVIEN);
                return;
            }
            else
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MASV from dbo.SINHVIEN WHERE MASV LIKE '%"
                   + tim + "%' OR HO  LIKE '%" + tim + "%' OR TEN LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.conn.Close();
                if (!kqTimkiem.Equals(""))
                    bdsSinhVien.Filter = "MASV IN (" + kqTimkiem + ")";
            }
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaLopSV.Text = cbbTenLop.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
