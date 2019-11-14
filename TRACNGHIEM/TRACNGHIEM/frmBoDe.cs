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
        private int dem = 0;
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            tNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
            this.tbBaiThiADT.Connection.ConnectionString = Program.connstr;
            this.tbBaiThiADT.Fill(this.tNDataSet.BAITHI);
            // TODO: This line of code loads data into the 'tNDataSet.DSGIAOVIEN' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Connection.ConnectionString = Program.connstr;
            this.tbGiaoVienADT.Fill(this.tNDataSet.DSGIAOVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.DSMONHOC' table. You can move, or remove it, as needed.
            this.tbMonHocADT.Connection.ConnectionString = Program.connstr;
            this.tbMonHocADT.Fill(this.tNDataSet.DSMONHOC);
            // TODO: This line of code loads data into the 'tNDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.tbMonHoc.Connection.ConnectionString = Program.connstr;
            this.tbMonHoc.Fill(this.tNDataSet.MONHOC);
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.tbBoDe.Connection.ConnectionString = Program.connstr;
            this.tbBoDe.Fill(this.tNDataSet.BODE);
            cbbTenMonHocC.SelectedIndex = 0;

            dem++;

        }

        private void btnThoatBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form bộ đề?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void frmBoDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form bộ đề?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void btnThemBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBoDe.AddNew();
                //btnAdd.Enabled = btnEdit.Enabled
                //    = btnDel.Enabled = btnRefres     h.Enabled = btnExit.Enabled=false;
                //btnSave.Enabled = btnRevert.Enabled = true;
                //gcGiangVien.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đề thi " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnGhiBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBoDe.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsBoDe.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.tbBoDe.Update(this.tNDataSet.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề " + ex.Message, "", MessageBoxButtons.OK);
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
                    this.tbBoDe.Update(this.tNDataSet.BODE);
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
                this.tbBoDe.Fill(this.tNDataSet.BODE);
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
        }

        private void cbbTenMonHocC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenMonHocC.SelectedValue != null)
            {

                //Console.WriteLine(cbbMH.SelectedValue.ToString());
                //this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                //this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                //cbbLThi.SelectedIndex = 0;

                //this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                //this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
                try
                {
                    String kqTimkiem = "";
                    String strlenh = "SELECT CAUHOI FROM dbo.BODE WHERE MAMH = '" 
                        +cbbTenMonHocC.SelectedValue.ToString()+"'";
                    Program.myReader = Program.ExecSqlDataReader(strlenh);
                    while (Program.myReader.Read())
                    {
                        kqTimkiem += "'" + Program.myReader.GetString(0).Trim() + "',";
                    }
                    Program.conn.Close();
                    bdsBoDe.Filter = "MAMH IN (" + kqTimkiem + ")";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu theo môn học " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                }

            }
        }
    }
}
