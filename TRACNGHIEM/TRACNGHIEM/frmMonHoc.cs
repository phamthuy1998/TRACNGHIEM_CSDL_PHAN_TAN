using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace TRACNGHIEM
{
    public partial class frmMonHoc : Form
    {
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;
        private ArrayList arrPhucHoi = new ArrayList();
        private int viTri = 0;

        private String truocKhiUpdate;
        private String sauKhiUpdate;
        private PhucHoi phucHoi;


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

            this.ControlBox = false;
            TNDataSet.EnforceConstraints = false;
            gcMH.UseDisabledStatePainter = false;
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
            this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.tbBoDeADT.Connection.ConnectionString = Program.connstr;
            this.tbBoDeADT.Fill(this.TNDataSet.BODE);
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.tbGVDKyADT.Connection.ConnectionString = Program.connstr;
            this.tbGVDKyADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);

            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
            // phân quyền
            // nhóm CoSo thì ta chỉ cho phép toàn quyền làm việc trên cơ sở  đó , không được log vào cơ sở  khác,   
            if (Program.mGroup == "Coso")
            {
                btnRedo.Visibility = btnHuy.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnThemMH.Visibility = btnSuaMH.Visibility = btnGhiMH.Visibility = btnXoaMH.Visibility = btnPhucHoiMH.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                btnRedo.Visibility = btnHuy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThemMH.Visibility = btnSuaMH.Visibility = btnGhiMH.Visibility = btnXoaMH.Visibility = btnPhucHoiMH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (viTri <= 0)
            {
                btnPhucHoiMH.Enabled = btnRedo.Enabled = false;
            }
            else if (viTri < arrPhucHoi.Count)
            {
                btnRedo.Enabled = true;
            }
            else
            {
                btnPhucHoiMH.Enabled = true;
            }
        }

        private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsMonHoc.AddNew();
                gcMH.Enabled = false;
                edtTenMH.Enabled = edtMaMH.Enabled = true;
                edtMaMH.Focus();
                btnThemMH.Enabled = btnSuaMH.Enabled = btnTaiLaiMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = false;
                checkThem = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiMH()
        {
            gcMH.Enabled = true;
            edtTenMH.Enabled = false;
            edtMaMH.Enabled = false;
            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.tbMonHoc.Update(this.TNDataSet.MONHOC);
                edtTim.Text = "";
                // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
                this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
                this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
                // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
                this.tbBoDeADT.Connection.ConnectionString = Program.connstr;
                this.tbBoDeADT.Fill(this.TNDataSet.BODE);
                // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.tbGVDKyADT.Connection.ConnectionString = Program.connstr;
                this.tbGVDKyADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);

                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                checkSave = true;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi môn học" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (edtMaMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (edtTenMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                String sql = "EXEC SP_KT_MONHOC_TON_TAI '" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaMH.Focus();
                    return;
                }
                else
                {
                    arrPhucHoi.Add(new PhucHoi("N'" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'", null, "INSERT"));
                    ghiMH();
                    checkThem = false;

                    viTri++;
                    if (viTri < 0)
                    {
                        btnPhucHoiMH.Enabled = btnRedo.Enabled = false;
                    }
                    else if (viTri < arrPhucHoi.Count)
                    {
                        btnRedo.Enabled = true;
                    }
                    else
                    {
                        btnPhucHoiMH.Enabled = true;
                        btnRedo.Enabled = false;
                    }
                }
            }

            else if (checkSua == true)
            {
                if (edtTenMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                String sql = "EXEC SP_KT_TEN_MONHOC_TON_TAI '" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTenMH.Focus();
                    return;
                }
                else
                {
                    sauKhiUpdate = "N'" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'";
                    ghiMH();
                    checkSua = false;

                    arrPhucHoi.Add(new PhucHoi(sauKhiUpdate, truocKhiUpdate, "UPDATE"));
                    Console.WriteLine("trc update: " + truocKhiUpdate+"sau : "+ sauKhiUpdate);
                    viTri++;
                    if (viTri < 0)
                    {
                        btnPhucHoiMH.Enabled = btnRedo.Enabled = false;
                    }
                    else if (viTri < arrPhucHoi.Count)
                    {
                        btnRedo.Enabled = true;
                    }
                    else
                    {
                        btnPhucHoiMH.Enabled = true;
                        btnRedo.Enabled = false;
                    }
                }
            }
            else
            {
                ghiMH();
            }
        }

        private void btnXoaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMonHoc.Count == 0)
            {
                MessageBox.Show("Không có môn học để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
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
                        arrPhucHoi.Add(new PhucHoi("N'" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'", null, "DELETE"));

                        //phải chạy lệnh del from where mới chính xác
                        bdsMonHoc.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.tbMonHoc.Update(this.TNDataSet.MONHOC);
                        // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
                        this.tbBangDiemADT.Connection.ConnectionString = Program.connstr;
                        this.tbBangDiemADT.Fill(this.TNDataSet.BANGDIEM);
                        // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
                        this.tbBoDeADT.Connection.ConnectionString = Program.connstr;
                        this.tbBoDeADT.Fill(this.TNDataSet.BODE);
                        // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                        this.tbGVDKyADT.Connection.ConnectionString = Program.connstr;
                        this.tbGVDKyADT.Fill(this.TNDataSet.GIAOVIEN_DANGKY);

                        this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                        this.tbMonHoc.Fill(this.TNDataSet.MONHOC);

                        viTri++;
                       
                        if (viTri < 0)
                        {
                            btnPhucHoiMH.Enabled = btnRedo.Enabled = false;
                        }
                        else if (viTri < arrPhucHoi.Count)
                        {
                            btnRedo.Enabled = true;
                        }
                        else
                        {
                            btnPhucHoiMH.Enabled = true;
                            btnRedo.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa giảng viên " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("vi tri: " + viTri + " count: " + arrPhucHoi.Count);

            if (viTri == 0)
            {
                // Hủy bỏ thao tác đang hiệu chỉnh
                bdsMonHoc.CancelEdit();
                checkSua = checkThem = false;
                gcMH.Enabled = true;
                edtTenMH.Enabled = false;
                edtMaMH.Enabled = false;
                btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                checkSave = true;
                return;
            }
            else
            {
                if (arrPhucHoi.Count > 0)
                {

                    phucHoi = (PhucHoi)arrPhucHoi[viTri-1];

                    Console.WriteLine("vi tri redo: " + (viTri - 1));
                    if (phucHoi.LoaiCauLenh.Equals("INSERT"))
                    {
                        // ---> xóa
                        String sql = "EXEC SP_PhucHoiXoaMH " + phucHoi.cauLenh1;
                        int result = Program.ExecSqlNonQuery(sql);
                        //kiểm tra kết quả câu lệnh
                        if (result == 1)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã có trong bảng điểm, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã tồn tại trong bộ đề, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        if (result == 3)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã tồn tại trong giảng viên đăng ký, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        //Xóa môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                            MessageBox.Show("Phục hồi thành công, đã xóa môn học", "Thành công", MessageBoxButtons.OK);
                            viTri--;
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (phucHoi.LoaiCauLenh.Equals("UPDATE"))
                    {
                        // ---> sửa
                        String sql = "EXEC SP_PhucHoiSuaMH " + phucHoi.cauLenh2;
                        int result = Program.ExecSqlNonQuery(sql);

                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Tên môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        //Sửa môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                            MessageBox.Show("Phục hồi thành công, đã sửa lại môn học", "Thành công", MessageBoxButtons.OK);
                            viTri--;
                            Console.WriteLine("vi tri sua redo: " + (viTri));
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (phucHoi.LoaiCauLenh.Equals("DELETE"))
                    {
                        // ---> thêm
                        String sql = "EXEC SP_PhucHoiThemMH " + phucHoi.cauLenh1;
                        int result = Program.ExecSqlNonQuery(sql);

                        if (result == 1)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Mã môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Tên môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        //Thêm môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                            MessageBox.Show("Phục hồi thành công, đã thêm lại môn học", "Thành công", MessageBoxButtons.OK);
                            viTri--;
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                    {
                        // Hủy bỏ thao tác đang hiệu chỉnh
                        bdsMonHoc.CancelEdit();
                    }

                }
                else
                {
                    bdsMonHoc.CancelEdit();
                    this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                    this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                    checkSua = checkThem = false;
                    gcMH.Enabled = true;
                    edtTenMH.Enabled = false;
                    edtMaMH.Enabled = false;
                    btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                    checkSave = true;
                }
            }

            if (viTri == 0)
            {
                btnPhucHoiMH.Enabled = false;
                btnRedo.Enabled = true;
            }
            else if (viTri < arrPhucHoi.Count)
            {
                if (viTri >= 0)
                    btnRedo.Enabled = true;
                if (viTri > 0)
                    btnPhucHoiMH.Enabled = true;
                else
                    btnPhucHoiMH.Enabled = false;
            }
            else
            {
                btnRedo.Enabled = true;
                btnPhucHoiMH.Enabled  = false;
            }
        }


        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine("vi tri undo: " + viTri + " count: " + arrPhucHoi.Count);

            if (viTri < 0)
            {
                // Hủy bỏ thao tác đang hiệu chỉnh
                bdsMonHoc.CancelEdit();
                checkSua = checkThem = false;
                gcMH.Enabled = true;
                edtTenMH.Enabled = false;
                edtMaMH.Enabled = false;
                btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                return;
            }
            else
            {
                if (viTri < arrPhucHoi.Count)
                {
                    phucHoi = (PhucHoi)arrPhucHoi[(viTri )];
                    Console.WriteLine("vi tri undoáhjdgfhasgd: " + phucHoi.cauLenh1+"\n"+phucHoi.cauLenh2);

                    if (phucHoi.LoaiCauLenh.Equals("INSERT"))
                    {
                        // ---> thêm
                        String sql = "EXEC SP_PhucHoiThemMH " + phucHoi.cauLenh1;
                        int result = Program.ExecSqlNonQuery(sql);

                        if (result == 1)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Mã môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Tên môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        //Thêm môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thành công, đã thêm lại môn học", "Thành công", MessageBoxButtons.OK);
                            viTri++;
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (phucHoi.LoaiCauLenh.Equals("UPDATE"))
                    {
                        // ---> sửa
                        String sql = "EXEC SP_PhucHoiSuaMH " + phucHoi.cauLenh1;
                        int result = Program.ExecSqlNonQuery(sql);

                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Tên môn học đã tồn tại, không thể phục hồi", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }

                        //Sửa môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thành công, đã sửa lại môn học", "Thành công", MessageBoxButtons.OK);
                            viTri++;
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                            Console.WriteLine("vi tri sua undo: " + (viTri));
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (phucHoi.LoaiCauLenh.Equals("DELETE"))
                    {
                        // ---> xóa
                        String sql = "EXEC SP_PhucHoiXoaMH " + phucHoi.cauLenh1;
                        int result = Program.ExecSqlNonQuery(sql);

                        //kiểm tra kết quả câu lệnh
                        if (result == 1)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã có trong bảng điểm, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        if (result == 2)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã tồn tại trong bộ đề, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        if (result == 3)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Môn học đã tồn tại trong giảng viên đăng ký, không thể xóa", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                        //Xóa môn học thành công
                        if (result == 0)
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thành công, đã xóa môn học", "Thành công", MessageBoxButtons.OK);
                            viTri++;
                            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                            checkSua = checkThem = false;
                            gcMH.Enabled = true;
                            edtTenMH.Enabled = false;
                            edtMaMH.Enabled = false;
                            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                            checkSave = true;
                        }
                        else
                        {
                            Program.conn.Close();
                            MessageBox.Show("Phục hồi thất bại", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                    {
                        // Hủy bỏ thao tác đang hiệu chỉnh
                        bdsMonHoc.CancelEdit();
                    }

                }
                else
                {
                    bdsMonHoc.CancelEdit();
                    this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                    this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                    checkSua = checkThem = false;
                    gcMH.Enabled = true;
                    edtTenMH.Enabled = false;
                    edtMaMH.Enabled = false;
                    btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
                    checkSave = true;
                }
            }
            if (viTri == 0)
            {
                btnPhucHoiMH.Enabled = false;
               
            }
            else if (viTri < arrPhucHoi.Count)
            {
                if (viTri >= 0)
                    btnRedo.Enabled = true;
                if (viTri > 0)
                    btnPhucHoiMH.Enabled = true;
                else
                    btnPhucHoiMH.Enabled = false;
            }
            else
            {
                btnPhucHoiMH.Enabled = btnRedo.Enabled = false;
            }
        }

        private void btnTaiLaiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            edtTim.Text = "";
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
        }

        private void btnInDanhSachMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public void btnThoatMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới môn học, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiMH_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa môn học, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiMH_ItemClick(sender, e);
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

        private void btnSuaMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMonHoc.Count == 0)
            {
                MessageBox.Show("Không có môn học để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                gcMH.Enabled = true;
                edtTenMH.Enabled = true;
                edtMaMH.Enabled = false;
                btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = false;
                checkSua = true;
                checkSave = false;

                truocKhiUpdate = "N'" + edtMaMH.Text.Trim() + "', N'" + edtTenMH.Text.Trim() + "'";
               
            }
        }

        private void edtTim_EditValueChanged(object sender, EventArgs e)
        {
            String tim = edtTim.Text.Trim();
            if (!tim.Equals(""))
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MAMH from dbo.MONHOC WHERE MAMH LIKE '%"
                   + tim + "%' OR TENMH  LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.conn.Close();
                if (!kqTimkiem.Equals(""))
                {
                    bdsMonHoc.Filter = "MAMH IN (" + kqTimkiem + ")";
                    if (bdsMonHoc.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin môn học " + tim, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else 
            {
                bdsMonHoc.Filter = "";
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String tim = edtTim.Text.Trim();
            if (tim.Equals(""))
            {
                bdsMonHoc.Filter = "";
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
                return;
            }
            else
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MAMH from dbo.MONHOC WHERE MAMH  LIKE '%"
                   + tim + "%' OR TENMH  LIKE '%" + tim + "%'";
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                while (Program.myReader.Read())
                {
                    kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                }
                Program.conn.Close();
                if (!kqTimkiem.Equals(""))
                {
                    bdsMonHoc.Filter = "MAMH IN (" + kqTimkiem + ")";
                    if (bdsMonHoc.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin môn học " + tim, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsMonHoc.CancelEdit();
            checkSua = checkThem = false;
            gcMH.Enabled = true;
            edtTenMH.Enabled = false;
            edtMaMH.Enabled = false;
            btnThemMH.Enabled = btnTaiLaiMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
            checkSave = true;
        }
    }
}

