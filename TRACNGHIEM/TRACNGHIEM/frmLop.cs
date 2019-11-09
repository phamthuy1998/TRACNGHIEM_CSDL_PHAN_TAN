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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TNDataSet);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            TNDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tNDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.TNDataSet.SINHVIEN);
            TNDataSet.EnforceConstraints = false; 
            // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
            this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);
            // TODO: This line of code loads data into the 'tNDataSet.LOP' table. You can move, or remove it, as needed.
            this.tbLopADT.Fill(this.TNDataSet.LOP);

        }

    }
}
