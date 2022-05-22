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
    public partial class FormChonMonThi : DevExpress.XtraEditors.XtraForm
    {
        public FormChonMonThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV_DK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormChonMonThi_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
          
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            if (Program.mGroup == "SinhVien")
            {
        
                    bdsGV_DK.Filter = "NGAYTHI = '" + DateTime.Now.ToShortDateString() + "' AND MALOP = '" + Program.MaLopSV + "'";
            }
                
            else
                bdsGV_DK.Filter = "NGAYTHI = '" + DateTime.Now.ToShortDateString() + "'";
            if (!gcMonThi.Focused)
            {
                btnStart.Enabled = false;
            }
        }

        private void btnStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.MAMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
            Program.TD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRINHDO").ToString();
            Program.soCau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOCAUTHI").ToString();
            Program.ngayThi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYTHI").ToString();
            Program.time = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "THOIGIAN").ToString());
            Program.lanThi = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LAN").ToString());

            string sql = "EXEC SP_CheckDaThi '" + Program.username + "', '" + Program.MAMH + "', " + Program.lanThi;
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                FormThi f = new FormThi();
            //    f.MdiParent = this;
                f.Show();
            }
            else return;
            btnStart.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void gcMonThi_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle != -1)
            {
                btnStart.Enabled = true;
            }
            if (bdsGV_DK.Count == 0) btnStart.Enabled = false;
        }
    }
}