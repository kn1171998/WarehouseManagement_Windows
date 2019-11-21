using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LTW_NC_DO_AN
{
    public partial class NhaSanXuat : DevExpress.XtraEditors.XtraForm
    {
        public NhaSanXuat()
        {
            InitializeComponent();
        }

        private void sALE_NHA_SAN_XUATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_NHA_SAN_XUATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_NHA_SAN_XUAT' table. You can move, or remove it, as needed.
            this.sALE_NHA_SAN_XUATTableAdapter.Fill(this.qlkho1DataSet.SALE_NHA_SAN_XUAT);

        }

        private void iD_NHA_SAN_XUATLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_NHA_SAN_XUATSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tEN_NHA_SAN_XUATLabel_Click(object sender, EventArgs e)
        {

        }

        private void tEN_NHA_SAN_XUATTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void eMAILLabel_Click(object sender, EventArgs e)
        {

        }

        private void eMAILTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void wEBSITELabel_Click(object sender, EventArgs e)
        {

        }

        private void wEBSITETextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mO_TALabel_Click(object sender, EventArgs e)
        {

        }

        private void mO_TATextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
