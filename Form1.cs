using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bulate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProdId.Clear();
            txtQuantity.Clear();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            frmRecordMgmt rec = new frmRecordMgmt();
            rec.ShowDialog();
        }
    }
}





