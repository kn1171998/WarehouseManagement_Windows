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

namespace LTW_NC_DO_AN
{
    public partial class NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void sALE_NHA_CUNG_CAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_NHA_CUNG_CAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_NHA_CUNG_CAP' table. You can move, or remove it, as needed.
            this.sALE_NHA_CUNG_CAPTableAdapter.Fill(this.qlkho1DataSet.SALE_NHA_CUNG_CAP);

        }
    }
}