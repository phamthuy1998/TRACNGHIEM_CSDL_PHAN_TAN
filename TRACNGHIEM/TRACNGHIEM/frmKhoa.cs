using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRACNGHIEM
{
    public partial class frmKhoa : Form
    {
        private int dem = 0;
        private Boolean checkThem = false;
        private Boolean checkXoa = false;
        private Boolean checkSua = false;
        private Boolean checkThemGV = false;
        private Boolean checkXoaGV = false;
        private Boolean checkSuaGV = false;
        private Boolean checkChuyenKhoa = false;

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
            cbbHocVi.Items.Add("Thạc sĩ");
            cbbHocVi.Items.Add("Nghiên cứu sinh");
            cbbHocVi.Items.Add("Tiến sĩ");
            cbbHocVi.Items.Add("Tiến sĩ khoa học");


            Program.connstr1 = Program.connstr;
            TNDataSet.EnforceConstraints = false;
            gcKhoa.UseDisabledStatePainter = false;
            gcGiaoVien.UseDisabledStatePainter = false;
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
                btnThemGV.Visible = btnChuyenKhoaGV.Enabled = btnSuaGV.Enabled = btnGhiGV.Visible = btnXoaGV.Visible = btnPhucHoiGV.Visible = false;
            }
            txtMaKH.Enabled = txtTenKH.Enabled = false;

            // ẩn sub form giảng viên
            edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled = edtDiachiGV.Enabled
                = cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
            cbbKhoaGV.SelectedValue = txtTenKH.Text;


            cbbHocVi.SelectedValue = ((DataRowView)this.bdsGiaoVien.Current).Row["HOCVI"].ToString();
            dem++;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsKhoa.AddNew();
                checkThem = true;
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = false;
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
                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled  = true;
                txtMaKH.Focus();
                btnGhi.Enabled = true;
                gcKhoa.Enabled = true;
                gcGiaoVien.Enabled = true;
                ctxMenuGV.Enabled = true;
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
            if (checkThem == true)
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
                    txtTenKH.Focus();
                    return;
                }

                String sql = "EXEC SP_KTKhoa_TONTAI '" + txtMaKH.Text.Trim() + "', N'" + txtTenKH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    txtMaKH.Focus();
                    return;
                }
                else
                {
                    ghiKhoa();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {

                if (txtTenKH.Text.Equals(""))
                {
                    MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                    txtTenKH.Focus();
                    return;
                }

                String sql = "EXEC SP_KT_TEN_Khoa_TONTAI N'" + txtTenKH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    txtTenKH.Focus();
                    return;
                }
                else
                {
                    ghiKhoa();
                    checkThem = false;
                }
            }
            else
            {
                ghiKhoa();
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
            btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled= false;
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
            btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled  = true;
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
            edtTimGV.Text = "";
        }

    

        private void btnThemGV_Click_1(object sender, EventArgs e)
        {
            try
            {
                checkThemGV = true;
                bdsGiaoVien.AddNew();
                edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled
                    = edtDiachiGV.Enabled = true;
                cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
                cbbKhoaGV.ValueMember = txtTenKH.Text;
                edtMaKHGV.Text = txtMaKH.Text;

                btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled = false;
                txtMaKH.Focus();
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                gcKhoa.Enabled = false;
                gcGiaoVien.Enabled = false;
                btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = false;
                txtMaKH.Enabled = txtTenKH.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaGV_Click_1(object sender, EventArgs e)
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

        private void btnGhiGV_Click_1(object sender, EventArgs e)
        {
            if (checkThemGV == true)
            {
                try
                {
                    if (edtMaGV.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Mã giảng viên không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }
                    
                    if (edtHoGV.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Họ giảng viên không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (edtTenGV.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Tên giảng viên không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (edtDiachiGV.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Địa chỉ giảng viên không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }

                    String sql = "EXEC SP_KTGV_TONTAI '" + edtMaGV.Text.Trim().ToString() + "'";

                    int kq = Program.ExecSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        edtMaGV.Focus();
                        return;
                    }
                    else
                    {
                        bdsGiaoVien.EndEdit();
                        //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                        bdsGiaoVien.ResetCurrentItem();
                        //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                        // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                        this.tbGiaoVienADT.Update(this.TNDataSet.GIAOVIEN);

                        edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled
                          = edtDiachiGV.Enabled = false;
                        cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
                        checkThemGV = false;

                        btnPhucHoi.Enabled = true;
                        btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = btnSuaK.Enabled  = true;
                        btnGhi.Enabled = true;
                        gcKhoa.Enabled = true;
                        gcGiaoVien.Enabled = true;
                        btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giáo viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else if (checkSuaGV == true)
            {
                try
                {
                    bdsGiaoVien.EndEdit();
                    //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                    bdsGiaoVien.ResetCurrentItem();

                    //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                    // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                    this.tbGiaoVienADT.Update(this.TNDataSet.GIAOVIEN);

                    edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled
                      = edtDiachiGV.Enabled = false;
                    cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
                    checkThemGV = false;

                    btnPhucHoi.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = btnSuaK.Enabled ;
                    btnGhi.Enabled = true;
                    gcKhoa.Enabled = true;
                    gcGiaoVien.Enabled = true;
                    btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giáo viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else if (checkChuyenKhoa == true)
            {
                try
                {
                    // chuyển kết nối về site chủ để chuyển khoa
                    Program.servername1 = "THUY";
                    if (Program.KetNoiCosoKhac() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối tới cơ sở để chuyển khoa ", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        string strLenh = "EXEC sp_chuyenKhoa '" + edtMaKHGV.Text + "','" + edtMaGV.Text + "'";
                        //Thực hiện sp
                        Program.myReader = Program.ExecSqlDataReader1(strLenh);

                        if (Program.myReader == null)
                        {
                            MessageBox.Show("Lỗi chuyển khoa ", "", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Chuyển khoa cho giảng viên thành công, vui lòng đợi 1p sau để dữ liệu được cập nhật! ", "", MessageBoxButtons.OK);
                        }

                        this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
                        tbGiaoVienADT.Connection.ConnectionString = Program.connstr;

                        edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled
                          = edtDiachiGV.Enabled = false;
                        cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
                        checkChuyenKhoa = false;

                        btnPhucHoi.Enabled = true;
                        btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnTaiLai.Enabled = btnSuaK.Enabled  = true;
                        btnGhi.Enabled = true;
                        gcKhoa.Enabled = true;
                        gcGiaoVien.Enabled = true;
                        btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển khoa " + ex.Message, "", MessageBoxButtons.OK);
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    bdsGiaoVien.EndEdit();
                    //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                    bdsGiaoVien.ResetCurrentItem();

                    //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                    // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                    this.tbGiaoVienADT.Update(this.TNDataSet.GIAOVIEN);

                    edtMaGV.Enabled = edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled
                      = edtDiachiGV.Enabled = false;
                    cbbKhoaGV.Enabled = edtMaKHGV.Enabled = false;
                    checkThemGV = false;

                    btnPhucHoi.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = btnSuaK.Enabled  = true;
                    btnGhi.Enabled = true;
                    gcKhoa.Enabled = true;
                    gcGiaoVien.Enabled = true;
                    btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giáo viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPhucHoiGV_Click_1(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGiaoVien.CancelEdit();
            checkSuaGV = false;
            checkThemGV = false;
            edtMaGV.Enabled = false;
            edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled = edtDiachiGV.Enabled = false;
            cbbKhoaGV.Enabled = false;
            edtMaKHGV.Enabled = false;

            btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnGhi.Enabled = btnSuaK.Enabled = true;
            btnGhi.Enabled = true;
            gcKhoa.Enabled = true;
            gcGiaoVien.Enabled = true;
            btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = true;
        }

        private void btnTaiLaiGV_Click_1(object sender, EventArgs e)
        {
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            cbbHocVi.SelectedValue = ((DataRowView)this.bdsGiaoVien.Current).Row["HOCVI"].ToString();
            edtMaGV.Enabled = false;
            edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled = edtDiachiGV.Enabled = true;
            cbbKhoaGV.Enabled = false;
            edtMaKHGV.Enabled = false;
            btnThemGV.Enabled = btnXoaGV.Enabled = btnSuaGV.Enabled = btnChuyenKhoaGV.Enabled = false;
        }

        private void btnChuyenKhoaGV_Click(object sender, EventArgs e)
        {
            checkChuyenKhoa = true;
            edtMaGV.Enabled = false;
            edtHoGV.Enabled = edtTenGV.Enabled = cbbHocVi.Enabled = edtDiachiGV.Enabled = false;
            cbbKhoaGV.Enabled = true;
            edtMaKHGV.Enabled = false;

            btnThem.Enabled = btnSuaK.Enabled = btnXoa.Enabled = btnTaiLai.Enabled 
                = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            gcKhoa.Enabled = false;
            gcGiaoVien.Enabled = false;
            btnSuaGV.Enabled = btnThemGV.Enabled = btnChuyenKhoaGV.Enabled = btnXoaGV.Enabled = false;
            txtMaKH.Enabled = txtTenKH.Enabled = false;
            try
            {
                string chuoiketnoi = "Data Source=THUY;Initial Catalog=TN;Integrated Security=True";
                Program.conn.ConnectionString = chuoiketnoi;
                Program.conn.Open();

                // Gọi view V_DS_COSO và trả về datable 
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH, MACS FROM dbo.KHOA");
                Program.bds_dspm.DataSource = dt;

                // Lấy kết quả đổ vào combobox
                cbbKhoaGV.DataSource = dt;
                cbbKhoaGV.DisplayMember = "TENKH";
                cbbKhoaGV.ValueMember = "MAKH";
                cbbKhoaGV.SelectedIndex = 1;
                cbbKhoaGV.SelectedIndex = 0;
            }
            catch (Exception ex) { }
        }

        private void cbbKhoaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaKHGV.Text = cbbKhoaGV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void edtTimGV_EditValueChanged(object sender, EventArgs e)
        {
            String tim = edtTimGV.Text.Trim();
            if (!tim.Equals(""))
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MAGV from dbo.GIAOVIEN WHERE MAGV = '"
                   + tim + "' OR HO  LIKE '%" + tim + "%' OR TEN LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.conn.Close();
                if (!kqTimkiem.Equals(""))
                    bdsGiaoVien.Filter = "MAGV IN (" + kqTimkiem + ")";
            }
            else
            {
                bdsGiaoVien.Filter = "";
                this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr1;
                this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
                // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            String tim = edtTimGV.Text.Trim();
            if (tim.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tìm kiếm", "", MessageBoxButtons.OK);
                this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
                this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
                // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.
                return;
            }
            else
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MAGV from dbo.GIAOVIEN WHERE MAGV = '"
                   + tim + "' OR HO  LIKE '%" + tim + "%' OR TEN LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }

                Program.conn.Close();
                bdsGiaoVien.Filter = "MAGV IN (" + kqTimkiem + ")";
            }
        }

        private void cbbCoSoAdd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtMaCS.Text = cbbCoSoAdd.SelectedValue.ToString();
        }
        
    }
}
