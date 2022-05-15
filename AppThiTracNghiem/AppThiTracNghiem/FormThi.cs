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
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        int giay = 0;
        int so_cau_thi = 0;
        String trinhdo = "";
        bool timeOut = false;
        int maBD = 0;

        public FormThi()
        {
            InitializeComponent();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                lb_1.Text = "MÃ GV:";
                lb_3.Text = "TÊN GV: ";
                lb_MASV.Text = Program.username;
                lb_MALOP.Text = Program.mHoten;
                lb_2.Visible = lb_TENSV.Visible
                    = lb_4.Visible = lb_TENLOP.Visible = false;
                giay = 60 * 60;
                time_Thi.Text = "60:00";
                //  btn_Tim.Enabled = false;
        
            }
            else
            {
                lb_MASV.Text = Program.username;
                lb_TENSV.Text = Program.username;
                lb_MALOP.Text = Program.mHoten;
                lb_TENLOP.Text = Program.mGroup;
               
            }

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnNopBai_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                //loadCauHoiThi();
                btn_BatDau.Text = "NỘP BÀI";
                timer1.Start();

                
                btnThoat.Enabled = false;
            }
            else
            {
                if (timeOut == true || MessageBox.Show("Bạn có thật sự muốn nộp bài ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btn_BatDau.Text = "BẮT ĐẦU";
                    timer1.Stop();
                  //  double diem = tinhDiem();

                    if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
                    {
             //           MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;

                        cmb_MonHoc.Enabled = true;
                        date_NgayThi.Enabled = true;
                        spin_LanThi.Enabled = true;

                    }
                    else
                    {
                    //    if (insertBangDiem(diem) == 0)
                        {
                            //ghi chi tiet bai thi
                      //      insertBaiThi();

                        }

                 //       MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                        timeOut = false;
                        cmb_MonHoc.Enabled = true;
                        date_NgayThi.Enabled = true;
                        spin_LanThi.Enabled = true;

                    }

                    btn_BatDau.Enabled = false;
                   // btn_Tim.Enabled = true;
                    btnThoat.Enabled = true;

                }
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
    
}