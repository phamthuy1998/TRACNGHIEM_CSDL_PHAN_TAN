using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TRACNGHIEM
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel MASO;
        public ToolStripStatusLabel HOTEN;
        public ToolStripStatusLabel NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private IContainer components;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThoatMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnDe;
        private DevExpress.XtraBars.BarButtonItem btnThiThu;
        private DevExpress.XtraBars.BarButtonItem btnBangdiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem btnDSDK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatMain = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangdiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MASO = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnThoat,
            this.barButtonItem2,
            this.btnBangDiemBaoCao,
            this.btnTaoTK,
            this.btnThoatMain,
            this.barButtonItem3,
            this.btnMonHoc,
            this.btnKhoa,
            this.btnLop,
            this.barButtonItem5,
            this.btnDe,
            this.btnThiThu,
            this.btnBangdiem,
            this.btnDSDK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.rbBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(2052, 346);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 2;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnBangDiemBaoCao
            // 
            this.btnBangDiemBaoCao.Caption = "Bảng điểm";
            this.btnBangDiemBaoCao.Id = 6;
            this.btnBangDiemBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangDiemBaoCao.ImageOptions.Image")));
            this.btnBangDiemBaoCao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangDiemBaoCao.ImageOptions.LargeImage")));
            this.btnBangDiemBaoCao.Name = "btnBangDiemBaoCao";
            this.btnBangDiemBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemBaoCao_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo tài khoản";
            this.btnTaoTK.Id = 7;
            this.btnTaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.ImageOptions.Image")));
            this.btnTaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.ImageOptions.LargeImage")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // btnThoatMain
            // 
            this.btnThoatMain.Caption = "Thoát";
            this.btnThoatMain.Id = 8;
            this.btnThoatMain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatMain.ImageOptions.Image")));
            this.btnThoatMain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatMain.ImageOptions.LargeImage")));
            this.btnThoatMain.Name = "btnThoatMain";
            this.btnThoatMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatMain_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng xuất";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 10;
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Id = 11;
            this.btnKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoa.ImageOptions.LargeImage")));
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 12;
            this.btnLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLop.ImageOptions.LargeImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Giảng viên đăng ký";
            this.barButtonItem5.Id = 13;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnDe
            // 
            this.btnDe.Caption = "Đề thi";
            this.btnDe.Id = 14;
            this.btnDe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDe.ImageOptions.LargeImage")));
            this.btnDe.Name = "btnDe";
            this.btnDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDe_ItemClick);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Caption = "Thi thử";
            this.btnThiThu.Id = 15;
            this.btnThiThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThiThu.ImageOptions.LargeImage")));
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThiThu_ItemClick);
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.Caption = "Bảng điểm";
            this.btnBangdiem.Id = 16;
            this.btnBangdiem.Name = "btnBangdiem";
            // 
            // btnDSDK
            // 
            this.btnDSDK.Caption = "Danh sách đăng kí thi ";
            this.btnDSDK.Id = 17;
            this.btnDSDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDK.ImageOptions.Image")));
            this.btnDSDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDK.ImageOptions.LargeImage")));
            this.btnDSDK.Name = "btnDSDK";
            this.btnDSDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDK_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tài khoản";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThoatMain);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup4,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnKhoa);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDe);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnThiThu);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "ribbonPageGroup12";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup10});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBangDiemBaoCao);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDSDK);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "ribbonPageGroup10";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASO,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2052, 46);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MASO
            // 
            this.MASO.Name = "MASO";
            this.MASO.Size = new System.Drawing.Size(103, 41);
            this.MASO.Text = "MASO";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(114, 41);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(111, 41);
            this.NHOM.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(2052, 1324);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmKhoa));
            if (form == null)
            {

                IsMdiContainer = true;
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmLop));
            if (form == null)
            {

                IsMdiContainer = true;
                frmLop f = new frmLop();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmMonHoc));
            if (form == null)
            {

                IsMdiContainer = true;
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmBoDe));
            if (form == null)
            {

                IsMdiContainer = true;
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmThi));
            if (form == null)
            {

                IsMdiContainer = true;
                frmThi f = new frmThi();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnBangDiemBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmBangDiem));
            if (form == null)
            {

                IsMdiContainer = true;
                frmBangDiem f = new frmBangDiem();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmDSDK));
            if (form == null)
            {

                IsMdiContainer = true;
                frmDSDK f = new frmDSDK();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmDangKy));
            if (form == null)
            {

                IsMdiContainer = true;
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;

                f.Show();
            }
            else form.Activate();
        }

        private void btnThoatMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        
    }
}