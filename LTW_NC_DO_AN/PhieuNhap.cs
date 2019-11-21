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
    public partial class PhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void sALE_PHIEU_DAT_HANG_NCCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_PHIEU_DAT_HANG_NCCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_SAN_PHAM' table. You can move, or remove it, as needed.
            this.sALE_SAN_PHAMTableAdapter.Fill(this.qlkho1DataSet1.SALE_SAN_PHAM);
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_PHIEU_DAT_HANG_NCC' table. You can move, or remove it, as needed.
            this.sALE_PHIEU_DAT_HANG_NCCTableAdapter1.Fill(this.qlkho1DataSet1.SALE_PHIEU_DAT_HANG_NCC);
            // TODO: This line of code loads data into the 'qlkho1DataSet1.SALE_PHIEU_DAT_HANG_NCC' table. You can move, or remove it, as needed.
            this.sALE_PHIEU_DAT_HANG_NCCTableAdapter1.Fill(this.qlkho1DataSet1.SALE_PHIEU_DAT_HANG_NCC);
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_PHIEU_DAT_HANG_NCC' table. You can move, or remove it, as needed.
            //this.sALE_PHIEU_DAT_HANG_NCCTableAdapter.Fill(this.qlkho1DataSet.SALE_PHIEU_DAT_HANG_NCC);

        }

        private void iD_PHIEUSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}