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
    public partial class KiemKe : DevExpress.XtraEditors.XtraForm
    {
        public KiemKe()
        {
            InitializeComponent();
        }

        private void sALE_PHIEU_KIEM_KEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_PHIEU_KIEM_KEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void KiemKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_SAN_PHAM' table. You can move, or remove it, as needed.
            this.sALE_SAN_PHAMTableAdapter.Fill(this.qlkho1DataSet.SALE_SAN_PHAM);
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_PHIEU_KIEM_KE' table. You can move, or remove it, as needed.
            this.sALE_PHIEU_KIEM_KETableAdapter.Fill(this.qlkho1DataSet.SALE_PHIEU_KIEM_KE);

        }
    }
}