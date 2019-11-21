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
    public partial class LoaiSanPham : DevExpress.XtraEditors.XtraForm
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void sALE_LOAI_SAN_PHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_LOAI_SAN_PHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_LOAI_SAN_PHAM' table. You can move, or remove it, as needed.
            this.sALE_LOAI_SAN_PHAMTableAdapter.Fill(this.qlkho1DataSet.SALE_LOAI_SAN_PHAM);

        }
    }
}