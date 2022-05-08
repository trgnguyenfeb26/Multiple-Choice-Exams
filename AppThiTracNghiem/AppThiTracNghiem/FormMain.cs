using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
            
                f.Show();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}