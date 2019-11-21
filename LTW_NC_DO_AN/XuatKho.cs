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
    public partial class XuatKho : DevExpress.XtraEditors.XtraForm
    {
        public XuatKho()
        {
            InitializeComponent();
        }

        private void sALE_SAN_PHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_SAN_PHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet1);

        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_PHIEU_DAT_HANG' table. You can move, or remove it, as needed.
            this.sALE_PHIEU_DAT_HANGTableAdapter.Fill(this.qlkho1DataSet1.SALE_PHIEU_DAT_HANG);
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_PHIEU_DAT_HANG' table. You can move, or remove it, as needed.
            this.sALE_PHIEU_DAT_HANGTableAdapter.Fill(this.qlkho1DataSet1.SALE_PHIEU_DAT_HANG);
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_SAN_PHAM' table. You can move, or remove it, as needed.
            this.sALE_SAN_PHAMTableAdapter.Fill(this.qlkho1DataSet1.SALE_SAN_PHAM);

        }
    }
}