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
        private Boolean checkThem = false;
        private Boolean checkSua = false;

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

        }

        private void btnThemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsMonHoc.AddNew();
                gcMH.Enabled = false;
                edtTenMH.Enabled = edtMaMH.Enabled = true;
                edtMaMH.Focus();
                btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = false;
                checkThem = true;
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
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.tbMonHoc.Update(this.TNDataSet.MONHOC);
                this.tbMonHoc.Connection.ConnectionString = Program.connstr;
                this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
            }
            catch (Exception ex)
            {
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
                    ghiMH();
                    checkThem = false;
                }

            }
            else if (checkSua == true)
            {
                if (edtTenMH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên môn học không được để trống ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                String sql = "EXEC SP_KT_TEN_MONHOC_TON_TAI N'" + edtTenMH.Text.Trim() + "'";

                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtTenMH.Focus();
                    return;
                }
                else
                {
                    ghiMH();
                    checkThem = false;
                }

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
        }

        private void btnPhucHoiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsMonHoc.CancelEdit();
            checkSua = checkThem = false;
            gcMH.Enabled = true;
            edtTenMH.Enabled = false;
            edtMaMH.Enabled = false;
            btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = true;
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.TNDataSet.MONHOC);
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
                btnThemMH.Enabled = btnSuaMH.Enabled = btnXoaMH.Enabled = btnTim.Enabled = edtTim.Enabled = false;
                checkSua = true;
            }
        }

        private void edtTim_EditValueChanged(object sender, EventArgs e)
        {
            String tim = edtTim.Text.Trim();
            if (!tim.Equals(""))
            {
                String kqTimkiem = "";
                String strlenh = "SELECT MAMH from dbo.MONHOC WHERE MAMH = '"
                   + tim + "' OR TENMH  LIKE '%" + tim + "%'";
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
                String strlenh = "SELECT MAMH from dbo.MONHOC WHERE MAMH = '"
                   + tim + "' OR TENMH  LIKE '%" + tim + "%'";
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
    }
}

