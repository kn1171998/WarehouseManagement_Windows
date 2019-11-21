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
    public partial class MeNu : DevExpress.XtraEditors.XtraForm
    {
        public MeNu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form frm = kiemtraform(typeof(PhieuNhap));
            //if (frm == null)
            //{
            //   PhieuNhap forms = new PhieuNhap();
            //    forms.MdiParent = this;
            //    forms.Dock = DockStyle.Fill;
            //    forms.Show();
     
            //}
            //else
            //{
            //    frm.Activate();
            //}
        }

        private void navBarItem20_ItemChanged(object sender, EventArgs e)
        {
            
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Form frm = kiemtraform(typeof(PN));
            //if (frm == null)
            //{
            //    PN forms = new PN();
            //    forms.MdiParent = this;
            //    forms.Dock = DockStyle.Fill;
            //    forms.Show();
              
            //}
            //else
            //{
            //    frm.Activate();
            //}
        }

        private void navNhapKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(PhieuNhap));
            if (frm == null)
            {
                PhieuNhap forms = new PhieuNhap();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(XuatKho));
            if (frm == null)
            {
                XuatKho forms = new XuatKho();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navTTSanPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(SanPham));
            if (frm == null)
            {
                SanPham forms = new SanPham();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navLoaiSanPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(LoaiSanPham));
            if (frm == null)
            {
                LoaiSanPham forms = new LoaiSanPham();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navNhaCungCap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(NhaCungCap));
            if (frm == null)
            {
                NhaCungCap forms = new NhaCungCap();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(NhanVien));
            if (frm == null)
            {
                NhanVien forms = new NhanVien();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(KiemKe));
            if (frm == null)
            {
               KiemKe forms = new KiemKe();
                forms.MdiParent = this;
                forms.Dock = DockStyle.Fill;
                forms.Show();

            }
            else
            {
                frm.Activate();
            }
        }
    }
}