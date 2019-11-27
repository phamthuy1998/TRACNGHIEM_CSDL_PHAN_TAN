using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class frmBangDiem : Form
    {
        public static Boolean isCoSoKhac = false;
        public static String _coso = "";
        private String maLop = "", maMH = "";
        private int dem = 0;
        private int lan = 1;
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBangDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Program.connstr1 = Program.connstr;
            tNDataSet.EnforceConstraints = false;

            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            cbbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
            }
            else if (Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
            }
            dem++;

            this.dSLOPDKTableAdapter.Connection.ConnectionString = Program.connstr1;
            this.dSLOPDKTableAdapter.Fill(this.tNDataSet.DSLOPDK);
            if (dSLOPDK.Count > 0)
            {
                cbbLop.SelectedIndex = 0;
                this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                if (sP_DSMHDK.Count > 0)
                {
                    cbbMH.SelectedIndex = 0;

                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    if (sP_DSLanThiDK.Count > 0)
                    {
                        cbbLThi.SelectedIndex = 0;
                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));

                    }
                }
            }
            else
            {
                this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, null);
                this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, null, null, null);

            }

        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dSLOPDK.Count <= 0 || sP_DSMHDK.Count <= 0 || sP_DSLanThiDK.Count <= 0)
            {
                MessageBox.Show("Không có thông tin bảng điểm ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            rpBangDiem rpBD = new rpBangDiem(cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpBD.lbLop.Text = cbbLop.Text;
            rpBD.lbMH.Text = cbbMH.Text;
            rpBD.lbLanThi.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();

        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {

                    Console.WriteLine(cbbLop.SelectedValue.ToString());
                    this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                    cbbMH.SelectedIndex = 0;


                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    cbbLThi.SelectedIndex = 0;

                    this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                }
            }
            catch (Exception) { };
        }


        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {

                    Console.WriteLine(cbbLop.SelectedValue.ToString());

                    if (cbbMH.SelectedValue != null)
                    {

                        Console.WriteLine(cbbMH.SelectedValue.ToString());
                        this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                        cbbLThi.SelectedIndex = 0;

                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbLThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {
                    if (cbbMH.SelectedValue != null)
                    {
                        if (cbbLThi.SelectedValue != null)
                        {
                            // continuos
                            this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                            this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue != null && dem != 0)
            {
                Program.servername1 = cbbCoSo.SelectedValue.ToString();
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.dSLOPDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.dSLOPDKTableAdapter.Fill(this.tNDataSet.DSLOPDK);
                    if (dSLOPDK.Count > 0)
                    {
                        cbbLop.SelectedIndex = 0;
                        this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                        if (sP_DSMHDK.Count > 0)
                        {
                            cbbMH.SelectedIndex = 0;

                            this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                            this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                            if (sP_DSLanThiDK.Count > 0)
                            {
                                cbbLThi.SelectedIndex = 0;
                                this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                                this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
                            }
                        }
                    }
                    else
                    {
                        this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, null);
                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, null, null, null);

                    }
                }
            }
            if (Program.mCoSo != cbbCoSo.SelectedIndex) isCoSoKhac = true;
        }

    }
}
