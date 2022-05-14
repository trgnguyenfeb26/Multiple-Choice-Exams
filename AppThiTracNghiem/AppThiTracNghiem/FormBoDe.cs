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
    public partial class FormBoDe : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt = new DataTable();
        private bool dangThem;
        private Stack<string> UndoStack = new Stack<string>();
        private int vitri = 0;
        public FormBoDe()
        {
            InitializeComponent();
        }

 

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            
            

            // Kiểm tra ràng buộc
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DataTable1' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.dS.BAITHI);


            if (bdsBD.Count == 0
                || (Program.username != ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            string mgv = ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString();
            dt = Program.ExecSqlDataTable("SELECT HO+' '+TEN as hoten FROM GIAOVIEN WHERE MAGV='" + mgv + "'");
            cbxBB.DataSource = dt;
            cbxBB.DisplayMember = "hoten";
            cbxBB.ValueMember = "hoten";
            cbxBB.SelectedIndex = 0;
            lbTenGV.Text = cbxBB.Text;

            if (Program.mGroup == "TRUONG" )
            {
                
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = false;
                txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled =txtND.Enabled= false;
                cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;

            }
            else
            {

                txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;
                if (bdsBD.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }


        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

            dangThem = true;
            cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = true;

            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled =txtND.Enabled= true;
            bdsBD.AddNew();
            ((DataRowView)bdsBD[bdsBD.Position])["MAGV"] = Program.username; // Mã gv khi đăng nhập vào
            lbTenGV.Text = Program.mHoten; // tên gv tạo đề

            // Tạo mã câu hỏi
            int MaCH = int.Parse(((DataRowView)bdsBD[bdsBD.Count - 2])["CAUHOI"].ToString()) +1;
            ((DataRowView)bdsBD[bdsBD.Position])["CAUHOI"] = MaCH.ToString();

            cbxDA.SelectedIndex = 1; cbxDA.SelectedIndex = 0;
            cbxTD.SelectedIndex = 1; cbxTD.SelectedIndex = 0;

            dt = Program.ExecSqlDataTable("SELECT MAMH FROM MONHOC");
            cbxMM.DataSource = dt;
            cbxMM.DisplayMember = "MAMH";
            cbxMM.ValueMember = "MAMH";
            cbxMM.SelectedIndex = 0;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled =btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcBD.Enabled = false;

            //gcGV.Enabled = gcKhoa.Enabled = false;
            
            //dangThem = true;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (txtND.Text == "")
            {
                MessageBox.Show("Nội dung không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtND.Focus();
                return;
            }
            if (txtA.Text == "")
            {
                MessageBox.Show("Đáp án A không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Đáp án B không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtB.Focus();
                return;
            }
            if (txtC.Text == "")
            {
                MessageBox.Show("Đáp án C không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtC.Focus();
                return;
            }
            if (txtD.Text == "")
            {
                MessageBox.Show("Đáp án D không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtD.Focus();
                return;
            }
            try
            {

                bdsBD.EndEdit();
                bdsBD.ResetCurrentItem();
                this.bODETableAdapter.Update(this.dS.BODE);
               
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm câu hỏi thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemBD] '" + lbBD.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa câu hỏi thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;
                btnHuy.Enabled = btnGhi.Enabled = false;
        
                //pnGv.Enabled = false;
                gcBD.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi câu hỏi\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void gcBD_Click(object sender, EventArgs e)
        {
            if (bdsBD.Count == 0|| Program.mGroup == "TRUONG"
                || (Program.username != ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }

            string mgv = ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString();
            dt = Program.ExecSqlDataTable("SELECT HO+' '+TEN as hoten FROM GIAOVIEN WHERE MAGV='" + mgv + "'");
            cbxBB.DataSource = dt;
            cbxBB.DisplayMember = "hoten";
            cbxBB.ValueMember = "hoten";
                cbxBB.SelectedIndex = 0;
            lbTenGV.Text = cbxBB.Text;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = true;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = true;

            vitri = bdsBD.Position;

            UndoStack.Push("exec[dbo].[SP_UndoSuaBD] '" + lbBD.Text + "', N'"
                + cbxMM.Text + "', N'" + cbxTD.Text + "',N'" + txtND.Text + "',N'" + txtA.Text +"',N'" + txtB.Text + "',N'"+ txtC.Text +"',N'"+txtD+"',N'"+cbxDA.Text+"'");
            
            gcBD.Enabled = false;
           
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
          
            dangThem = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsBT.Count > 0)
            {
                MessageBox.Show("Câu hỏi " + lbBD.Text + " môn " + cbxMM.Text + " đã được sinh viên thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có muốn xóa câu hỏi: " + lbBD.Text + " môn " + cbxMM.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsBD.Position;
                    UndoStack.Push("exec[dbo].[SP_UndoXoaBD] '" + lbBD.Text + "', N'"
                        + cbxMM.Text + "', N'" + cbxTD.Text + "',N'" + txtND.Text + "',N'" + txtA.Text + 
                        "',N'" + txtB.Text + "',N'" + txtC.Text + "',N'" + txtD.Text + "',N'" + cbxDA.Text + "',N'" + lbMGV.Text + "'");
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dS.BODE);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa giáo viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Fill(this.dS.BODE);
                    bdsBD.Position = vitri;
                    return;
                }

            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;

            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.bODETableAdapter.Fill(this.dS.BODE);
                }

            }
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra ràng buộc
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS.DataTable1' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.dS.BAITHI);


            if (bdsBD.Count == 0
                || (Program.username != ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            string mgv = ((DataRowView)bdsBD[bdsBD.Position])["MAGV"].ToString();
            dt = Program.ExecSqlDataTable("SELECT HO+' '+TEN as hoten FROM GIAOVIEN WHERE MAGV='" + mgv + "'");
            cbxBB.DataSource = dt;
            cbxBB.DisplayMember = "hoten";
            cbxBB.ValueMember = "hoten";
            cbxBB.SelectedIndex = 0;
            lbTenGV.Text = cbxBB.Text;

            if (Program.mGroup == "TRUONG" )
            {

                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = false;
                txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;
                cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;

            }
            else
            {

                txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;
                if (bdsBD.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }

        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtND.Enabled = false;
            cbxDA.Enabled = cbxMM.Enabled = cbxTD.Enabled = false;
            if (dangThem) bdsBD.RemoveCurrent(); else bdsBD.CancelEdit();
            bdsBD.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;

            gcBD.Enabled  = true;
            if (UndoStack.Count > 0) { UndoStack.Pop(); btnPhucHoi.Enabled = true; }

            if ((btnThem.Enabled == false) || (btnSua.Enabled == false))
            {
                btnHuy.Enabled = true;
                btnGhi.Enabled = true;
            }
            else
            {
                btnHuy.Enabled = false;
                btnGhi.Enabled = false;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}