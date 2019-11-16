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
    public partial class frmGiangVienDangKy : Form
    {
        private int dem = 0;
        public static Boolean checkSave = true;
        private Boolean checkThem = false;
        private Boolean checkSua = false;

        public frmGiangVienDangKy()
        {
            InitializeComponent();
        }

        private void btnThemGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGiangVienDK.AddNew();

                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = false;
                gcDetail.Enabled = true;

                cbbTenGV.Enabled = true;
                cbbTenGV.SelectedIndex = 0;
                cbbTenMon.SelectedIndex = 0;
                cbbTenLop.SelectedIndex = 0;
                cbbTrinhDo.SelectedIndex = 0;
                cbbLan.SelectedIndex = 0;
                cbbThoiGian.SelectedIndex = 0;
                checkThem = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên đăng ký " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiGVDK()
        {
            try
            {
                bdsGiangVienDK.EndEdit();
                bdsGiangVienDK.ResetCurrentItem();
                this.tbGiangVienDK.Update(this.tNDataSet.GIAOVIEN_DANGKY);
                btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = true;
                gcDetail.Enabled = false;
                checkThem = checkSua = true;
                checkSave = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên " + ex.Message, "", MessageBoxButtons.OK);
            }

        }

        private void btnGhiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {

                if (edtNgayThi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập ngày thi", "", MessageBoxButtons.OK);
                    edtNgayThi.Focus();
                    return;
                }
                //câu thi
                if (edtSoCau.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập số câu thi", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }

                // ngày không hợp lệ
                var FromDate = edtNgayThi.DateTime;
                var ToDate = DateTime.Today;
                Console.WriteLine("ngay thi: " + FromDate);
                Console.WriteLine("ngay hien tai: " + ToDate);
                int compare = DateTime.Compare(ToDate, FromDate);
                if (compare > 0)
                {
                    MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                    return;
                }

                //số câu thi không hợp lệ
                int i = Decimal.ToInt32(edtSoCau.Value);


                if (i < 10 || i > 100)
                {
                    MessageBox.Show("Số câu thi phải >=10 và <=100 câu, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    edtSoCau.Focus();
                    return;
                }


                String sql = "EXEC SP_KT_MA_BO_DE '" + edtMaGV.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    cbbTenGV.Focus();
                    return;
                }
                else
                {
                    ghiGVDK();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {
                ghiGVDK();
                checkSua = false;
            }
            else
            {
                ghiGVDK();
            }
        }

        private void btnXoaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên "
                + ((DataRowView)this.bdsGiangVienDK.Current).Row["MAGV"].ToString() + " của môn "
                + ((DataRowView)this.bdsGiangVienDK.Current).Row["MAMH"].ToString()
                + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsGiangVienDK.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbGiangVienDK.Update(this.tNDataSet.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSuaGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            checkSua = true;
            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = false;
            gcDetail.Enabled = true;
            cbbTenGV.Enabled = false;
            checkSave = false;
        }

        private void btnPhuchoiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsGiangVienDK.CancelEdit();

            this.tbGiangVienDK.Connection.ConnectionString = Program.connstr1;
            this.tbGiangVienDK.Fill(this.tNDataSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
            this.tbDSLopADT.Connection.ConnectionString = Program.connstr1;
            this.tbDSLopADT.Fill(this.tNDataSet.DSLOP);

            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbDSMH.Connection.ConnectionString = Program.connstr1;
            this.tbDSMH.Fill(this.tNDataSet.DSMONHOC);
            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = false;

            btnThemGVDK.Enabled = btnXoaGVDK.Enabled = btnSuaGVDK.Enabled = btnTaiLaiGVDK.Enabled = true;
            gcDetail.Enabled = false;
            checkSave = true;
            checkThem = checkSua = true;
        }

        private void btnTaiLaiGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.tbGiangVienDK.Connection.ConnectionString = Program.connstr1;
                this.tbGiangVienDK.Fill(this.tNDataSet.GIAOVIEN_DANGKY);

                // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
                this.tbDSLopADT.Connection.ConnectionString = Program.connstr1;
                this.tbDSLopADT.Fill(this.tNDataSet.DSLOP);

                // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
                this.tbDSMH.Connection.ConnectionString = Program.connstr1;
                this.tbDSMH.Fill(this.tNDataSet.DSMONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lại danh sách giảng viên đăng ký: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        public void btnThoatGVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới giảng viên đăng ký, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa giảng viên đăng ký, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiGVDK_ItemClick(sender, e);
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

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiangVienDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmGiangVienDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.DSGIAOVIEN' table. You can move, or remove it, as needed.
            this.tbDSGiangVien.Fill(this.tNDataSet.DSGIAOVIEN);
            Program.connstr1 = Program.connstr;
            this.ControlBox = false;
            gcGVDK.UseDisabledStatePainter = false;
            tNDataSet.EnforceConstraints = false;

            this.tbGiangVienDK.Connection.ConnectionString = Program.connstr;
            this.tbGiangVienDK.Fill(this.tNDataSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
            this.tbDSLopADT.Connection.ConnectionString = Program.connstr;
            this.tbDSLopADT.Fill(this.tNDataSet.DSLOP);

            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbDSMH.Connection.ConnectionString = Program.connstr;
            this.tbDSMH.Fill(this.tNDataSet.DSMONHOC);

            gcDetail.Enabled = false;

            try
            {
                // Lấy kết danh sách phân mảnh đổ vào combobox
                cbbCoSo.DataSource = Program.bds_dspm.DataSource;
                cbbCoSo.DisplayMember = "TENCS";
                cbbCoSo.ValueMember = "TENSERVER";
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu cơ sở" + ex.Message, "", MessageBoxButtons.OK);
            }

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");
            cbbTrinhDo.SelectedValue = ((DataRowView)this.bdsGiangVienDK.Current).Row["TRINHDO"].ToString();

            cbbLan.Items.Add(1);
            cbbLan.Items.Add(2);
            cbbLan.SelectedValue = ((DataRowView)this.bdsGiangVienDK.Current).Row["LAN"].ToString();


            cbbThoiGian.Items.Add(15);
            cbbThoiGian.Items.Add(20);
            cbbThoiGian.Items.Add(25);
            cbbThoiGian.Items.Add(30);
            cbbThoiGian.Items.Add(35);
            cbbThoiGian.Items.Add(40);
            cbbThoiGian.Items.Add(45);
            cbbThoiGian.Items.Add(50);
            cbbThoiGian.Items.Add(55);
            cbbThoiGian.Items.Add(60);
            cbbThoiGian.SelectedValue = ((DataRowView)this.bdsGiangVienDK.Current).Row["THOIGIAN"].ToString();


            if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                btnThemGVDK.Visibility = btnGhiGVDK.Visibility = btnSuaGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                btnThemGVDK.Visibility = btnSuaGVDK.Visibility = btnGhiGVDK.Visibility = btnXoaGVDK.Visibility = btnPhuchoiGVDK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            dem++;
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
                        this.tbGiangVienDK.Connection.ConnectionString = Program.connstr1;
                        this.tbGiangVienDK.Fill(this.tNDataSet.GIAOVIEN_DANGKY);

                        // TODO: This line of code loads data into the 'tNDataSet.DSLOP' table. You can move, or remove it, as needed.
                        this.tbDSLopADT.Connection.ConnectionString = Program.connstr1;
                        this.tbDSLopADT.Fill(this.tNDataSet.DSLOP);

                        // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
                        this.tbDSMH.Connection.ConnectionString = Program.connstr1;
                        this.tbDSMH.Fill(this.tNDataSet.DSMONHOC);

                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMon.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaLop.Text = cbbTenLop.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaGV.Text = cbbTenGV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
