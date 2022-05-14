using DevExpress.XtraBars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    public partial class FormSV : DevExpress.XtraEditors.XtraForm
    {

        private Stack<string> UndoStack = new Stack<string>();
        private int vitri;
        Boolean dangThem;
        
       
        public FormSV()
        {
            InitializeComponent();
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
        private void FormSV_Load(object sender, EventArgs e)
        {


            dS.EnforceConstraints = false;


            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            
            if (Program.mGroup == "TRUONG")
            {
               
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled  =  true;
                btnPhucHoi.Enabled = btnGhi.Enabled=btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
                if (bdsSV.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
               
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            

            vitri = bdsSV.Position;
            bdsSV.AddNew();
           
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnSV.Enabled = true;
            gcSV.Enabled = gcLop.Enabled = false;
            btnRefresh.Enabled = false;
            txtMK.Enabled = true;
            txtXN.Enabled = true;
            gcLop.Enabled = false;
            dNgaySinh.EditValue = "";
            txtMaSv.Enabled = true;
            txtMaLop.Text = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            dangThem = true;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
           

            vitri = bdsSV.Position;
            UndoStack.Push("exec[dbo].[SP_UndoSuaSV] '" + txtMaSv.Text + "', N'"
                + txtHo.Text + "', N'" + txtTen.Text + "', '" + dNgaySinh.Text.ToString() + "', N'"
                + txtDiaChi.Text + "', '" + txtMaLop.Text + "'");
            pnSV.Enabled = true;
            gcLop.Enabled = false;
            gcSV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled= false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            txtMaSv.Enabled = false;
            dangThem = false;
            txtMK.Enabled = false;
            txtXN.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bdsSV.CancelEdit();
            if (dangThem) bdsSV.RemoveCurrent(); else bdsSV.CancelEdit();
            if (dangThem == false) bdsSV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled= true;
            
            pnSV.Enabled = false;
            gcSV.Enabled = gcLop.Enabled = true;
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

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtMaSv.Text.ToString().Trim()=="")
            {
                MessageBox.Show("Mã sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaSv.Focus();
                return;
            }
            if (txtHo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if(txtMK.Text.ToString()!= txtXN.Text.ToString())
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới ", "", MessageBoxButtons.OK);
                txtXN.Focus();
                return;
            }
            if (dNgaySinh.Text != "")
            if (DateTime.Compare(DateTime.Parse(dNgaySinh.Text.ToString()),
                 DateTime.Parse(DateTime.Now.ToShortDateString())) > 0)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!", "Lỗi ngày sinh", MessageBoxButtons.OK);
                return;
            }
            try
            {

                if (dangThem){
                   
                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaSV] '" + txtMaSv.Text + "'") == 1)
                    {
                        txtMaSv.Focus();
                        return;
                    }
                    ((DataRowView)bdsSV[bdsSV.Position])["MATKHAU"] = GetMD5(txtMK.Text);
                }
                
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm Sinh viên thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemSV] '" + txtMaSv.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Sinh viên thành công", "", MessageBoxButtons.OK);
                }

                
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled   = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled=btnGhi.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            if (bdsSV.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Sinh viên " + txtHo.Text + " " + txtTen.Text + " đang có điểm không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Sinh viên: " + txtHo.Text + " " + txtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    
                    vitri = bdsSV.Position;
                    UndoStack.Push("exec[dbo].[SP_UndoXoaSV] '" + txtMaSv.Text + "', N'"
                        + txtHo.Text + "', N'" + txtTen.Text + "', '" + dNgaySinh.Text.ToString() + "', N'"
                        + txtDiaChi.Text + "', '" + txtMaLop.Text + "'");
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    btnPhucHoi.Enabled = true;
                    
                }
                catch (Exception ex)
                {
                    UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Sinh viên \n"+ ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSV.Position = vitri;
                    return;
                }
               
            }
        }

        private void gcSV_Click(object sender, EventArgs e)
        {
     
        }

        private void gcLop_Click(object sender, EventArgs e)
        {
            if (bdsSV.Count == 0||Program.mGroup=="TRUONG"|| Program.mGroup == "GIANGVIEN")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {

            // Program.ExecSqlNonQuery(UndoStack.Pop());
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                }

            }
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
        }
            

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
        

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

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
            {
                MessageBox.Show("Lỗi kết nối về phòng ban mới!");
            }
            else
            {

                dS.EnforceConstraints = false;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

              //  maLop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
        }


    }
}