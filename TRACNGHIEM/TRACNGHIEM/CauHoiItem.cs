using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class CauHoiItem : UserControl
    {
        public CauHoiItem()
        {
            InitializeComponent();
        }

        // câu số
        private int cauSo;
        private string cauHoi;
        private string cauA;
        private string cauB;
        private string cauC;
        private string cauD;
        private string daChon="";
        private string dapAn="";
        [Category("Custom Props")]
        public int CauSo
        {
            get { return cauSo; }
            set
            {
                cauSo = value;
                lbCauSo.Text = "Câu " + cauSo + ": ";
            }
        }
        //câu hỏi
        [Category("Custom Props")]
        public string CauHoi
        {
            get { return cauHoi; }
            set
            {
                cauHoi = value;
                lbNoiDungCH.Text = CauHoi;
            }
        }

        //câu A
        [Category("Custom Props")]
        public string CauA
        {
            get { return cauA; }
            set
            {
                cauA = value;
                rbA.Text = cauA;
            }
        }
        //câu B
        [Category("Custom Props")]
        public string CauB
        {
            get { return cauB; }
            set
            {
                cauB = value;
                rbB.Text = cauB;
            }
        }
        //câu C
        [Category("Custom Props")]
        public string CauC
        {
            get { return cauC; }
            set
            {
                cauC = value;
                rbC.Text = cauC;
            }
        }
        //câu D
        [Category("Custom Props")]
        public string CauD
        {
            get { return cauD; }
            set
            {
                cauD = value;
                rbD.Text = cauD;
            }
        }

        //câu đã chọn
        [Category("Custom Props")]
        public string CauDaChon
        {
            get { return daChon; }
            set { daChon = value; }
        }

        //câu đáp án
        [Category("Custom Props")]
        public string CauDapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "A";
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "B";
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "C";
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "D";
        }
    }

}
