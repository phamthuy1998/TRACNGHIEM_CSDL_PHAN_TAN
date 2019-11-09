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
    public partial class frmKhoa : Form
    {
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
            TNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.tbGiaoVienADT.Fill(this.TNDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tNDataSet.KHOA' table. You can move, or remove it, as needed.
            this.tbKhoaADT.Fill(this.TNDataSet.KHOA);

        }
    }
}
