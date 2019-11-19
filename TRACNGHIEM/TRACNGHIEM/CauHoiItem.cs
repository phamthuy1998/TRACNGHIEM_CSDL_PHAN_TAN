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
        //câu A
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

    }

}
