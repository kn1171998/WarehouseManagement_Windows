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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void sALE_NHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALE_NHAN_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlkho1DataSet);

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkho1DataSet.SALE_NHAN_VIEN' table. You can move, or remove it, as needed.
            this.sALE_NHAN_VIENTableAdapter.Fill(this.qlkho1DataSet.SALE_NHAN_VIEN);

        }
    }
}