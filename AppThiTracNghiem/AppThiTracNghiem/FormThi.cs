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
        double Diem1,Diem=0.0;

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
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
           

            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                lb_1.Text = "MÃ GV:";
                lb_3.Text = "TÊN GV: ";
                lb_MASV.Text = Program.username;
                lb_MALOP.Text = Program.mHoten;
                lb_2.Visible = lb_TENSV.Visible
                    = lb_4.Visible = lb_TENLOP.Visible = false;


            }
            else
            {
                lb_MASV.Text = Program.username;
                lb_TENSV.Text = Program.mHoten;
                lb_MALOP.Text = Program.MaLopSV;
                lb_TENLOP.SelectedValue = Program.MaLopSV;


            }
            lb_MASV.Enabled = false;
            lb_TENSV.Enabled = false;
            lb_MALOP.Enabled = false;
            lb_TENLOP.Enabled = false;
            lb_TrinhDo.Enabled = false;
            lb_SoCauThi.Enabled = false;
            spin_LanThi.Enabled = false;
            date_NgayThi.Enabled = false;
            cmb_MonHoc.Enabled = false;
            lb_TrinhDo.Text = Program.TD;
            lb_SoCauThi.Text = Program.soCau;
            spin_LanThi.Text = Program.lanThi.ToString();
            date_NgayThi.Text = Program.ngayThi;
            cmb_MonHoc.SelectedItem = Program.MAMH;

            DataTable dt = Program.ExecSqlDataTable("SELECT TENLOP FROM LOP WHERE MALOP='" + Program.MaLopSV + "'");
            lb_TENLOP.DataSource = dt;
            lb_TENLOP.DisplayMember = "TENLOP";
            lb_TENLOP.ValueMember = "MALOP";
            lb_TENLOP.SelectedIndex = 0;
            dt = Program.ExecSqlDataTable("SELECT TENMH FROM MONHOC WHERE MAMH='" + Program.MAMH + "'");
            cmb_MonHoc.DataSource = dt;
            cmb_MonHoc.DisplayMember = "TENMH";
            cmb_MonHoc.ValueMember = "MAMH";
            cmb_MonHoc.SelectedIndex = 0;
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
                DaChon = "X"
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
        public bool CheckFullDA()
        {
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {
                if (item.Value.DaChon=="X")
                {
                    return false;
                }
            }
            return true;
        }
        private void btnNopBai_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (phut != 0 && giay != 0)
            {
                if (MessageBox.Show("Chưa hết thời gian, bạn có muốn nộp bài?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CheckFullDA()==false)
                        if (MessageBox.Show("Chưa chọn hết đáp án, bạn có muốn nộp bài?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            foreach (KeyValuePair<int, CauHoi> item in deThi)
                            {
                                if (item.Value.DaChon == item.Value.DapAn)
                                {
                                    Diem += Diem1;
                                }
                            }
                            if (Diem - Math.Floor(Diem) == 0) Diem = Math.Floor(Diem);
                            else
                            if (Diem - Math.Floor(Diem) > 0.5) Diem = Math.Floor(Diem) + 1;
                            else if (Diem - Math.Floor(Diem) < 0.5) Diem = Math.Floor(Diem) + 0.5;
                            InsertTableBangDiem();
                            timer1.Stop();
                            phut = 0;
                            giay = 0;
                            hienThiTG();
                            btnThoat.Enabled = true;
                            btnNopBai.Enabled = false;
                            rdbDA.Properties.Items.Clear();
                            rdbListQS.Properties.Items.Clear();
                            lblCauHoi.Text = "Điểm của bạn: " + Diem + " Điểm";
                            MessageBox.Show("Điểm của bạn: " + Diem, "Điểm", MessageBoxButtons.OK);
                        }
                        else
                            return;
                    else
                    {
                        foreach (KeyValuePair<int, CauHoi> item in deThi)
                        {
                            if (item.Value.DaChon == item.Value.DapAn)
                            {
                                Diem += Diem1;
                            }
                        }
                        if (Diem - Math.Floor(Diem) == 0) Diem = Math.Floor(Diem);
                        else if (Diem - Math.Floor(Diem) > 0.5) Diem = Math.Floor(Diem) + 1;
                        else if (Diem - Math.Floor(Diem) < 0.5) Diem = Math.Floor(Diem) + 0.5;
                        InsertTableBangDiem();
                        timer1.Stop();
                        phut = 0;
                        giay = 0;
                        hienThiTG();
                        btnThoat.Enabled = true;
                        btnNopBai.Enabled = false;
                        rdbDA.Properties.Items.Clear();
                        rdbListQS.Properties.Items.Clear();
                        lblCauHoi.Text = "Điểm của bạn: " + Diem + " Điểm";
                        MessageBox.Show("Điểm của bạn: " + Diem, "Điểm", MessageBoxButtons.OK);
                    }
                }
                else
                    return;
            }
        }

        

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
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
                case "X":
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

                if (Diem - Math.Floor(Diem) == 0) Diem = Math.Floor(Diem);
                else if(Diem - Math.Floor(Diem) > 0.5) Diem = Math.Floor(Diem) + 1;
                else if (Diem - Math.Floor(Diem) < 0.5) Diem = Math.Floor(Diem) + 0.5;
                InsertTableBangDiem();
                hienThiTG();

                btn_BatDau.Enabled = true;
                btnThoat.Enabled = true;
                btnNopBai.Enabled = false;
                rdbDA.Properties.Items.Clear();
                rdbListQS.Properties.Items.Clear();
                lblCauHoi.Text= "Điểm của bạn: " + Diem+ " Điểm";
                MessageBox.Show("Điểm của bạn: " + Diem, "Điểm", MessageBoxButtons.OK);
            }

            hienThiTG();
        }

        private void btn_BatDau_ItemClick(object sender, ItemClickEventArgs e)
        {
            btn_BatDau.Enabled = false;
            btnNopBai.Enabled = true;
            phut = Program.time - 1;
            giay = 60;
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC SP_ThiTracNghiem '" + Program.MAMH + "', '" + Program.TD + "', " + Program.soCau + "";

                dt = Program.ExecSqlDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thi \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);

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
            btn_BatDau.Enabled = false;
            btnThoat.Enabled = false;
            timer1.Start();
        }

   

        private void InsertTableBangDiem()
        {
            if (Program.mGroup == "SinhVien")
            {
                try
                {
                    int d,tp = 0;
                    

                    if (Diem - Math.Floor(Diem) == 0.5)  { d = ((int)Math.Floor(Diem)); tp = 5; } 
                    else { d = ((int)Math.Floor(Diem)); tp = 0; }


                        String sql = "EXEC SP_InsertTableBangDiem '" + Program.username + "','" + Program.MAMH + "','" + Program.lanThi + "'," + d+"."+tp;

                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        string strLenh = "EXEC SP_LayIDBaiThi '" + Program.username + "','" + Program.MAMH + "','" + Program.lanThi + "'";
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        int ID = Program.myReader.GetInt32(0);
                        Program.myReader.Close();
                        
                        foreach (KeyValuePair<int, CauHoi> item in deThi)
                        {
                            sql = "EXEC SP_InsertBaiThi '" + ID + "','" + int.Parse(item.Value.IDCauHoi) + "','" + item.Value.DaChon + "'";
                            if (Program.ExecSqlNonQuery(sql) != 0)
                                MessageBox.Show("Lỗi lưu bài thi!", "Thông báo", MessageBoxButtons.OK);
                        }


                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}