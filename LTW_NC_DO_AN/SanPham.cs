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
    public partial class SanPham : DevExpress.XtraEditors.XtraForm
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void sALE_SAN_PHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_SAN_PHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_SAN_PHAM' table. You can move, or remove it, as needed.
            this.sALE_SAN_PHAMTableAdapter.Fill(this.qlkho1DataSet.SALE_SAN_PHAM);

        }
    }
}