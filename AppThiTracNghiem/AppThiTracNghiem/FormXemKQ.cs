using DevExpress.XtraEditors;
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
    public partial class FormXemKQ : DevExpress.XtraEditors.XtraForm
    {
        public FormXemKQ()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormXemKQ_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            //if (bdsMH.Count == 0) cmbTenMH.SelectedIndex = -1;
             cmbTenMH.SelectedValue = cmbMAMH.Text;

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {
            //if (bdsMH.Count == 0) cmbTenMH.SelectedIndex = -1;
             cmbTenMH.SelectedValue = cmbMAMH.Text;
        }
    }
}