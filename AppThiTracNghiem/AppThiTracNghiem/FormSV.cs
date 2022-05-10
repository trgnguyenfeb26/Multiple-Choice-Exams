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
    public partial class FormSV : DevExpress.XtraEditors.XtraForm
    {
        private int index = 0;
        private string maLop = "";
        private string tenLop = "";
        private int vitri;
        private DataTable dt = new DataTable();
      //  private PhucHoi phucHoi = new PhucHoi();
        private Boolean isDangThem = false, isDangSua = false, suaLop = false;
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.tN.SINHVIEN);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.tN);

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN);

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.tN.SINHVIEN);

                cmbMaLop.DataSource = dt;
                cmbMaLop.DisplayMember = "TENLOP";
                cmbMaLop.ValueMember = "MALOP";
                cmbMaLop.SelectedIndex = 0;

                maLop = cmbMaLop.SelectedValue.ToString().Trim();
              

            }
        }
    }
}