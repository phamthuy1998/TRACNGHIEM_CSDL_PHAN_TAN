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
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.tNDataSet.BODE);

        }
    }
}
