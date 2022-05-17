using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
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
        int phut = 0;

        double Diem1,Diem;
        bool timeOut = false;
        int maBD = 0;
        Dictionary<int, CauHoi> deThi = new Dictionary<int, CauHoi>();
        BindingSource bdsDethi;

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
                lblTime.Text = "60:00";
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
        private CauHoi GetQS(int vitri)
        {
            CauHoi c = new CauHoi
            {
                IDCauHoi = ((DataRowView)bdsDethi[vitri])["CAUHOI"].ToString().Trim(),
                MaMH = ((DataRowView)bdsDethi[vitri])["MAMH"].ToString().Trim(),
                MaGV = ((DataRowView)bdsDethi[vitri])["MAGV"].ToString().Trim(),
                TrinhDo = ((DataRowView)bdsDethi[vitri])["TRINHDO"].ToString().Trim(),
                NoiDung = ((DataRowView)bdsDethi[vitri])["NOIDUNG"].ToString().Trim(),
                A = ((DataRowView)bdsDethi[vitri])["A"].ToString().Trim(),
                B = ((DataRowView)bdsDethi[vitri])["B"].ToString().Trim(),
                C = ((DataRowView)bdsDethi[vitri])["C"].ToString().Trim(),
                D = ((DataRowView)bdsDethi[vitri])["D"].ToString().Trim(),
                DapAn = ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim(),
                DaChon = "null"
            };
            return c;
        }
        public void RandomNumber(List<int> randLuaChon)
        {
            Random rand = new Random();
            int[] a = new int[4];
            int indexVuaRandom;
            int doDaiMang = 4;
            for (int i = 0; i < doDaiMang; i++)
            {
                a[i] = i;
            }

            while (doDaiMang != 0)
            {
                indexVuaRandom = rand.Next(0, doDaiMang - 1);
                randLuaChon.Add(a[indexVuaRandom]);

                a[indexVuaRandom] = a[doDaiMang - 1];
                doDaiMang--;
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
            phut = Program.time - 1;
            giay = 60;
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC SP_ThiTracNghiem '" + Program.MAMH + "', '" + Program.TD + "', " + Program.soCau + "";

                dt = Program.ExecSqlDataTable(sql);
            }
            catch (Exception)
            {
                throw;

            }
            bdsDethi = new BindingSource();
            bdsDethi.DataSource = dt;
            for (int i = 1; i <= bdsDethi.Count; i++)
            {
                rdbListQS.Properties.Items.Add(new RadioGroupItem(i, "" + i));
                deThi.Add(i, GetQS(i - 1));
            }

            rdbListQS.SelectedIndex = 0;
            Diem1 = 10.0 / Double.Parse(Program.soCau);
            btnXemKQ.Enabled = false;
            btnThoat.Enabled = false;
            timer1.Start();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rdbListQS_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbDA.SelectedIndex = -1;
            rdbDA.Properties.Items.Clear(); 
            lblCauHoi.Text = "Câu " + rdbListQS.EditValue.ToString() + ": " + deThi[rdbListQS.SelectedIndex + 1].NoiDung;
            
            rdbDA.Properties.Items.Add(new RadioGroupItem("A", "A. " + deThi[rdbListQS.SelectedIndex + 1].A));
            rdbDA.Properties.Items.Add(new RadioGroupItem("B", "B. " + deThi[rdbListQS.SelectedIndex + 1].B));
            rdbDA.Properties.Items.Add(new RadioGroupItem("C", "C. " + deThi[rdbListQS.SelectedIndex + 1].C));
            rdbDA.Properties.Items.Add(new RadioGroupItem("D", "D. " + deThi[rdbListQS.SelectedIndex + 1].D));

            switch (deThi[rdbListQS.SelectedIndex + 1].DaChon)
            {
                case "A":
                    rdbDA.SelectedIndex = 0;
                    break;
                case "B":
                    rdbDA.SelectedIndex = 1;
                    break;
                case "C":
                    rdbDA.SelectedIndex = 2;
                    break;
                case "D":
                    rdbDA.SelectedIndex = 3;
                    break;
                case "null":
                    rdbDA.SelectedIndex = -1;
                    break;
            }
        }

        private void rdbDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbDA.SelectedIndex != -1)
            {
                deThi[rdbListQS.SelectedIndex + 1].DaChon = rdbDA.EditValue.ToString();
                rdbListQS.Properties.Items.GetItemByValue(rdbListQS.SelectedIndex + 1).Description 
                 = rdbListQS.EditValue.ToString() + " - " + deThi[rdbListQS.SelectedIndex + 1].DaChon;
            }
        }
        public void hienThiTG()
        {
            if (giay < 10)
            {
                if (phut > 10)
                    lblTime.Text = phut + ":0" + giay;
                else
                    lblTime.Text = "0" + phut + ":0" + giay;
            }
            else
            {
                if (giay == 60)
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":00";
                    else
                        lblTime.Text = "0" + phut + ":00";
                }
                else
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":" + giay;
                    else
                        lblTime.Text = "0" + phut + ":" + giay;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (giay == 0)
            {
                phut--;
                giay = 60;
            }
            if (phut == 0 && giay == 0)
            {
                timer1.Stop();
                foreach (KeyValuePair<int, CauHoi> item in deThi)
                {
                    if (item.Value.DaChon == item.Value.DapAn)
                    {
                        Diem += Diem1;
                    }
                }
                luuVaoBangDiem();
                hienThiTG();
                updateDatagrid();
                lblDiem.Text = "Điểm: " + diem;

                btnXemKQ.Enabled = true;
                btnThoat.Enabled = true;
                btnNopBai.Enabled = false;
                //MessageBox.Show("Điểm của bạn: " + diem, "Điểm", MessageBoxButtons.OK);
            }

            hienThiTG();
        }
    }
    
}