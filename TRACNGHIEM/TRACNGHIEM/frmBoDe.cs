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
    public partial class frmBoDe : Form
    {
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        public static Boolean checkSave = true;
        private int dem = 0;
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.MONHOC' table. You can move, or remove it, as needed.

            this.ControlBox = false;
            gcBoDe.UseDisabledStatePainter = false;
            TNDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
            this.tbBaiThiADT.Connection.ConnectionString = Program.connstr;
            this.tbBaiThiADT.Fill(this.TNDataSet.BAITHI);
            // TODO: This line of code loads data into the 'tNDataSet.DSGIAOVIEN' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVienADT.Fill(this.TNDataSet.DSGIAOVIEN);

            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            if (Program.mGroup.Equals("Giangvien"))
            {
                this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                this.tbDSMHAdt.FillByMaGV(this.TNDataSet.DSMONHOC, Program.username);
                if (bdsDSMH.Count <= 0)
                {
                    MessageBox.Show("Giảng viên chưa có môn học đăng ký ", "Thông báo", MessageBoxButtons.OK);
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    bdsBoDe = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                        = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    this.tbBoDe.FillByGV_MH(this.TNDataSet.BODE, Program.username, cbbTenMonHocC.SelectedValue.ToString().Trim());
                }

            }
            else
            {
                this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                this.tbDSMHAdt.Fill(this.TNDataSet.DSMONHOC);
                if (bdsDSMH.Count <= 0)
                {
                    MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);
                    bdsBoDe = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                          = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    this.tbBoDe.FillBy(this.TNDataSet.BODE, cbbTenMonHocC.SelectedValue.ToString().Trim());
                }
            }

            this.tbmonHocADT.Connection.ConnectionString = Program.connstr;
            this.tbmonHocADT.Fill(this.TNDataSet.MONHOC);

            gcDetail.Enabled = false;

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");
            if (bdsBoDe != null)
                if (bdsBoDe.Count > 0)
                    cbbTrinhDo.SelectedValue = ((DataRowView)this.bdsBoDe.Current).Row["TRINHDO"].ToString();

            cbbDapAn.Items.Add("A");
            cbbDapAn.Items.Add("B");
            cbbDapAn.Items.Add("C");
            cbbDapAn.Items.Add("D");
            if (bdsBoDe != null)
                if (bdsBoDe.Count > 0)
                    cbbDapAn.SelectedValue = ((DataRowView)this.bdsBoDe.Current).Row["DAP_AN"].ToString();

            if (Program.mGroup == "Coso")
            {
                btnThemBD.Visibility = btnSuaBD.Visibility = btnGhiBD.Visibility = btnXoaBD.Visibility = btnPhucHoiBD.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "Truong")
            {
                btnThemBD.Visibility = btnSuaBD.Visibility = btnGhiBD.Visibility = btnXoaBD.Visibility = btnPhucHoiBD.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            dem++;

        }

        public void btnThoatBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (MessageBox.Show("Bạn đang tạo mới câu hỏi thi, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiBD_ItemClick(sender, e);
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
                if (MessageBox.Show("Bạn đang sửa câu hỏi thi, bạn có muốn ghi thông tin này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhiBD_ItemClick(sender, e);
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

        private void btnThemBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBoDe.AddNew();
                cbbTenMh.SelectedValue = cbbTenMonHocC.SelectedValue.ToString();
                edtMaMon.Text = cbbTenMonHocC.SelectedValue.ToString();

                checkThem = true;
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = false;
                gcBoDe.Enabled = false;
                checkSave = false;
                cbbTenMh.Enabled = false;

                gcDetail.Enabled = true;

                cbbTrinhDo.SelectedIndex = 0;
                cbbTenMonHocC.Enabled = false;
                edtMaCauHoi.Enabled = true;
                cbbDapAn.SelectedIndex = 0;
                if (Program.mGroup.Equals("Giangvien"))
                {
                    cbbTenGV.Enabled = false;
                    cbbTenGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbTenGV.Enabled = true;
                    cbbTenGV.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đề thi " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void ghiBD()
        {
            try
            {
                bdsBoDe.EndEdit();
                bdsBoDe.ResetCurrentItem();
                this.tbBoDe.Update(this.TNDataSet.BODE);
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = true;
                gcBoDe.Enabled = true;
                checkSave = true;
                gcDetail.Enabled = false;
                cbbTenMonHocC.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề thi " + ex.Message, "", MessageBoxButtons.OK);
            }

        }
        public void btnGhiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (edtMaCauHoi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                    edtMaCauHoi.Focus();
                    return;
                }
                if (edtNoiDung.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nội dung câu hỏi thi không được rỗng", "", MessageBoxButtons.OK);
                    edtNoiDung.Focus();
                    return;
                }
                //a
                if (edtA.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtA.Focus();
                    return;
                }
                //B
                if (edtB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtB.Focus();
                    return;
                }
                //c
                if (edtC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtC.Focus();
                    return;
                }
                //D
                if (edtD.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đáp án không được bỏ trống", "", MessageBoxButtons.OK);
                    edtD.Focus();
                    return;
                }

                String sql = "EXEC SP_KT_MA_BO_DE '" + edtMaCauHoi.Text.Trim() + "'";
              
                int kq = Program.ExecSqlNonQuery(sql);
                if (kq == 1)
                {
                    edtMaCauHoi.Focus();
                    return;
                }
                else
                {
                    ghiBD();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {
                ghiBD();
                checkSua = false;
            }
            else
            {
                ghiBD();
            }

        }

        private void btnXoaBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBoDe.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (bdsBaiThi.Count > 0)
            {
                MessageBox.Show("Câu này đã tồn tại trong bài thi của sinh viên, không được xóa", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi thi "
                + ((DataRowView)this.bdsBoDe.Current).Row["CAUHOI"].ToString()
                + "\n" + ((DataRowView)this.bdsBoDe.Current).Row["NOIDUNG"].ToString()
                + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //phải chạy lệnh del from where mới chính xác
                    bdsBoDe.RemoveCurrent();
                    //đẩy dữ liệu về adapter
                    this.tbBoDe.Update(this.TNDataSet.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi thi " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTaiLaiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
                this.tbBaiThiADT.Fill(this.TNDataSet.BAITHI);
                // TODO: This line of code loads data into the 'tNDataSet.DSGIAOVIEN' table. You can move, or remove it, as needed.
                this.tbGiaoVienADT.Fill(this.TNDataSet.DSGIAOVIEN);

                //// TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
                //if (Program.mGroup.Equals("Giangvien"))
                //{
                //    this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                //    this.tbDSMHAdt.FillByMaGV(this.TNDataSet.DSMONHOC, Program.username);
                //    if (bdsDSMH.Count <= 0)
                //    {
                //        MessageBox.Show("Giảng viên chưa có môn học đăng ký ", "Thông báo", MessageBoxButtons.OK);
                //        this.tbBoDe.Connection.ConnectionString = Program.connstr;
                //        bdsBoDe = null;
                //        btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                //            = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                //    }
                //    else
                //    {
                //        btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                //           = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                //        cbbTenMonHocC.SelectedIndex = 0;
                //        this.tbBoDe.Connection.ConnectionString = Program.connstr;
                //        this.tbBoDe.FillByGV_MH(this.TNDataSet.BODE, Program.username, cbbTenMonHocC.SelectedValue.ToString().Trim());
                //    }

                //}
                //else
                //{
                //    this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                //    this.tbDSMHAdt.Fill(this.TNDataSet.DSMONHOC);
                //    if (bdsDSMH.Count <= 0)
                //    {
                //        MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);
                //        bdsBoDe = null;
                //        btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                //           = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                //    }
                //    else
                //    {
                //        btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                //              = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                //        cbbTenMonHocC.SelectedIndex = 0;
                //        this.tbBoDe.Connection.ConnectionString = Program.connstr;
                //        this.tbBoDe.FillBy(this.TNDataSet.BODE, cbbTenMonHocC.SelectedValue.ToString().Trim());
                //    }
                //}

                //this.tbmonHocADT.Connection.ConnectionString = Program.connstr;
                //this.tbmonHocADT.Fill(this.TNDataSet.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lại danh sách đề thi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Hủy bỏ thao tác đang hiệu chỉnh
            bdsBoDe.CancelEdit();
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
            this.tbBaiThiADT.Connection.ConnectionString = Program.connstr;
            this.tbBaiThiADT.Fill(this.TNDataSet.BAITHI);
            // TODO: This line of code loads data into the 'tNDataSet.DSGIAOVIEN' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVienADT.Fill(this.TNDataSet.DSGIAOVIEN);

            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            if (Program.mGroup.Equals("Giangvien"))
            {
                this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                this.tbDSMHAdt.FillByMaGV(this.TNDataSet.DSMONHOC, Program.username);
                if (bdsDSMH.Count <= 0)
                {
                    MessageBox.Show("Giảng viên chưa có môn học đăng ký ", "Thông báo", MessageBoxButtons.OK);
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    bdsBoDe = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                        = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    this.tbBoDe.FillByGV_MH(this.TNDataSet.BODE, Program.username, cbbTenMonHocC.SelectedValue.ToString().Trim());
                }

            }
            else
            {
                this.tbDSMHAdt.Connection.ConnectionString = Program.connstr;
                this.tbDSMHAdt.Fill(this.TNDataSet.DSMONHOC);
                if (bdsDSMH.Count <= 0)
                {
                    MessageBox.Show("Danh sách môn học rỗng ", "Thông báo", MessageBoxButtons.OK);
                    bdsBoDe = null;
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                       = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = false;
                }
                else
                {
                    btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled
                          = btnGhiBD.Enabled = btnPhucHoiBD.Enabled = true;
                    cbbTenMonHocC.SelectedIndex = 0;
                    this.tbBoDe.Connection.ConnectionString = Program.connstr;
                    this.tbBoDe.FillBy(this.TNDataSet.BODE, cbbTenMonHocC.SelectedValue.ToString().Trim());
                }
            }

            this.tbmonHocADT.Connection.ConnectionString = Program.connstr;
            this.tbmonHocADT.Fill(this.TNDataSet.MONHOC);

            checkThem = checkSua = false;
            btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = true;
            gcBoDe.Enabled = true;
            checkSave = true;
            gcDetail.Enabled = false;
            cbbTenMonHocC.Enabled = true;
        }

        private void cbbTenMonHocC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenMonHocC.SelectedValue != null && dem > 0)
            {
                try
                {
                    this.tbBoDe.FillByGV_MH(this.TNDataSet.BODE, Program.username,cbbTenMonHocC.SelectedValue.ToString().Trim());
                    lbTenMH.Text = cbbTenMonHocC.SelectedValue.ToString().Trim();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnSuaBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBoDe.Count == 0)
            {
                MessageBox.Show("Không có Khoa để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                if (Program.mGroup.Equals("Giangvien"))
                {
                    cbbTenGV.Enabled = false;
                    cbbTenGV.SelectedValue = Program.username;
                }
                else
                {
                    cbbTenGV.Enabled = true;
                    cbbTenGV.SelectedValue = ((DataRowView)this.bdsBoDe.Current).Row["MAGV"].ToString();

                }
                checkSua = true;
                edtMaCauHoi.Enabled = false;
                btnThemBD.Enabled = btnSuaBD.Enabled = btnXoaBD.Enabled = false;
                gcBoDe.Enabled = false;

                gcDetail.Enabled = true;
                cbbTrinhDo.SelectedValue = ((DataRowView)this.bdsBoDe.Current).Row["TRINHDO"].ToString();
                cbbTenMh.Enabled = true;
                cbbTenMonHocC.Enabled = false;
                checkSave = false;
            }
        }

        private void cbbTenMh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaMon.Text = cbbTenMh.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                edtMaGV.Text = cbbTenGV.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

    }
}
