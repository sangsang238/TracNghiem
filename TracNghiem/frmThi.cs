using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmThi : Form
    {
        List<itemCauHoi> list = new List<itemCauHoi>();
        int s = 0;//tong so giay
        int sct = 0;
        string td = "";
        bool timeOut = false;
        public frmThi()
        {
            InitializeComponent();
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            //fill thong tin SV
            label_MASV.Text = Program.username;
            label_TENSV.Text = Program.mHoten;
            GetMa_Ten();
            if (Program.mGroup == "Sinhvien")
            {
                comboBox_TD.Visible = false;
                spinEdit_SCT.Visible = false;
                dateEdit_NT.DateTime = DateTime.Now.Date;
                spinEdit_LAN.Value = spinEdit_LAN.Properties.MinValue;

                button_NOPBAI.Enabled = false;
            }
            else if (Program.mGroup == "Giangvien" || Program.mGroup == "Coso")
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);

                label_TT.Text = "Thông tin giáo viên";
                labelMaSV_GV.Text = "Mã GV";
                labelTenSV_GV.Text = "Tên GV";
                labelMaLop.Text = "Mã khoa";
                labelTenLop.Text = "Tên khoa";

                dateEdit_NT.Enabled = false;
                spinEdit_LAN.Enabled = false;
                label_TD.Visible = false;
                label_SCT.Visible = false;
                button_Find.Enabled = false;

                comboBox_TD.SelectedItem = -1;
                spinEdit_SCT.Value = spinEdit_SCT.Properties.MinValue;
                sct = (Int16)spinEdit_SCT.Value;
                //cho giao vien time max = 60p
                s = 60 * 60;
                label_Timer.Text = "60:00";
            }
        }

        private void GetMa_Ten()
        {
            string strLenh = "";
            if (Program.isGV)
            {
                strLenh = "SELECT MAKH,TENKH FROM KHOA WHERE MAKH in" +
                " (SELECT MAKH FROM GIAOVIEN WHERE MAGV= N'" + Program.username + "')";
            }
            else
            {
                strLenh = "SELECT MALOP,TENLOP FROM LOP WHERE MALOP in" +
                " (SELECT MALOP FROM SINHVIEN WHERE MASV= N'" + Program.username + "')";
            }
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false) return;
            label_MALOP.Text = Program.myReader.GetString(0);
            label_TENLOP.Text = Program.myReader.GetString(1);
            Program.myReader.Close();
        }

        private void loadCauHoiThi()
        {
            string strLenh = "EXEC SP_GETCAUHOITHI N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                    + td + "', "
                    + sct;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            list.Clear();
            flowLayoutPanel_THI.Controls.Clear();
            int i = 0;
            while (Program.myReader.Read() == true)
            {
                itemCauHoi ch = new itemCauHoi();
                ch.CauHoi = Program.myReader.GetInt32(0);
                ch.NoiDung = Program.myReader.GetString(1);
                ch.A = Program.myReader.GetString(2);
                ch.B = Program.myReader.GetString(3);
                ch.C = Program.myReader.GetString(4);
                ch.D = Program.myReader.GetString(5);
                ch.DapAn = Program.myReader.GetString(6);
                ch.Stt = i + 1;
                i++;
                list.Add(ch);
                flowLayoutPanel_THI.Controls.Add(ch);
            }
            Program.myReader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            int seconds = s % 60;
            int minutes = s / 60;
            string se = "" + seconds;
            string mi = "" + minutes;
            if (seconds < 10)
            {
                se = "0" + se;
            }
            if (minutes < 10)
            {
                mi = "0" + mi;
            }
            label_Timer.Text = mi + ":" + se;
            if (s == 0)
            {
                timeOut = true;
                button_NOPBAI.PerformClick();
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateEdit_NT.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày thi!", "", MessageBoxButtons.OK);
                dateEdit_NT.Focus();
                return;
            }
            if (dateEdit_NT.DateTime.Date != DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thi phải là hôm nay!", "", MessageBoxButtons.OK);
                dateEdit_NT.Focus();
                return;
            }
            //check sv da thi hay chua
            string strLenh1 = "EXEC SP_CHECKSVTRONGBANGDIEM N'" + Program.username
                + "', N'" + ComboBox_MAMH.SelectedValue.ToString() +
                "', " + spinEdit_LAN.Value;
            int kq = Program.ExecSqlNonQuery(strLenh1);
            if (kq != 0) return;
            //get gvdk
            string strLenh = "EXEC SP_CHECKTHONGTINTHI_SV N'" + label_MALOP.Text
                + "', N'" + ComboBox_MAMH.SelectedValue.ToString() +
                "', N'" + dateEdit_NT.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', " + spinEdit_LAN.Value;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false)
            {
                MessageBox.Show("Thông tin đăng ký thi không tồn tại!", "", MessageBoxButtons.OK);
            }
            else
            {
                td = Program.myReader.GetString(0);
                label_TD.Text = td;
                sct = Program.myReader.GetInt16(1);
                label_SCT.Text = sct.ToString();
                Int16 time = Program.myReader.GetInt16(2);
                label_Timer.Text = time.ToString() + ":00";
                s = time * 60;
                //phan quyen
                if (Program.mGroup == "Sinhvien")
                {
                    button_NOPBAI.Enabled = true;
                }
            }
            Program.myReader.Close();
        }

        private string getDapAn(itemCauHoi x)
        {
            string da = "";
            if (x.Rbtn_A.Checked == true)
            {
                da = "A";
            }
            else if (x.Rbtn_B.Checked == true)
            {
                da = "B";
            }
            else if (x.Rbtn_C.Checked == true)
            {
                da = "C";
            }
            else if (x.Rbtn_D.Checked == true)
            {
                da = "D";
            }
            return da;
        }

        private void setColorDapAn(itemCauHoi x, Color c)
        {
            if (x.DapAn == "A")
            {
                x.Rbtn_A.ForeColor = c;
            }
            else if (x.DapAn == "B")
            {
                x.Rbtn_B.ForeColor = c;
            }
            else if (x.DapAn == "C")
            {
                x.Rbtn_C.ForeColor = c;
            }
            else if (x.DapAn == "D")
            {
                x.Rbtn_D.ForeColor = c;
            }
        }

        private double tinhDiem()
        {
            int soCauDung = 0;
            foreach (itemCauHoi x in list)
            {
                string da = getDapAn(x);
                if (da == x.DapAn)
                {
                    soCauDung++;
                    setColorDapAn(x, Color.Blue);
                }
                else
                {
                    setColorDapAn(x, Color.Red);
                }
            }

            return Math.Round((soCauDung * 10) * 1.0 / sct, 1);
        }

        private int ghiBangDiem(double diem)
        {
            //ghi vao bang diem
            string strLenh = "EXEC SP_THEMBANGDIEM N'"
            + Program.username + "', N'"
            + ComboBox_MAMH.SelectedValue.ToString() + "', "
            + spinEdit_LAN.Value + ", N'"
            + dateEdit_NT.DateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', "
            + diem;
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0)
            {
                MessageBox.Show("Lỗi ghi bảng điểm!", "", MessageBoxButtons.OK);
            }
            return kq;
        }

        private void ghiCTBT()
        {
            foreach (itemCauHoi x in list)
            {
                string da = getDapAn(x);

                string strLenh = "EXEC SP_THEMCTBT N'"
                    + Program.username + "', N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', "
                    + spinEdit_LAN.Value + ", "
                    + x.Stt + ", " + x.CauHoi + ", N'"
                    + da.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0)
                {
                    MessageBox.Show("Lỗi ghi CTBT!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void button_NOPBAI_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false) //bat dau thi
            {
                if (Program.isGV)
                {
                    if (comboBox_TD.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn chưa chọn trình độ thi!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                //check them cho chac SCT
                string strLenh1 = "EXEC SP_CHECKSOCAUTHI N'"
                    + ComboBox_MAMH.SelectedValue.ToString() + "', N'"
                    + td + "', "
                    + sct;
                int kq1 = Program.ExecSqlNonQuery(strLenh1);
                if (kq1 == 1) return;

                button_NOPBAI.Text = "Nộp bài";
                timer1.Start();
                //load cau hoi thi, load giao dien thi
                loadCauHoiThi();

                if (Program.isGV)
                {
                    comboBox_TD.Enabled = false;
                    spinEdit_SCT.Enabled = false;
                }
                else
                {
                    button_Find.Enabled = false;
                    dateEdit_NT.Enabled = false;
                    spinEdit_LAN.Enabled = false;
                }
                ComboBox_MAMH.Enabled = false;
            }
            else //nop bai
            {
                if (timeOut == true || MessageBox.Show("Bạn có thật sự muốn nộp bài ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    button_NOPBAI.Text = "Bắt đầu thi";
                    timer1.Stop();
                    double diem = tinhDiem();
                    if (Program.mGroup == "Sinhvien")
                    {
                        //ghi bang diem
                        if (ghiBangDiem(diem) == 0)
                        {
                            //ghi chi tiet bai thi
                            ghiCTBT();
                        }
                    }
                    MessageBox.Show("Bạn đã đạt được " + diem + " điểm!", "", MessageBoxButtons.OK);
                    timeOut = false;

                    if (Program.isGV)
                    {
                        comboBox_TD.Enabled = true;
                        spinEdit_SCT.Enabled = true;
                        s = 60 * 60;
                        label_Timer.Text = "60:00";
                    }
                    else
                    {
                        button_Find.Enabled = true;
                        dateEdit_NT.Enabled = true;
                        spinEdit_LAN.Enabled = true;
                        button_NOPBAI.Enabled = false;
                    }
                    ComboBox_MAMH.Enabled = true;
                }
            }
        }

        private void comboBox_TD_SelectedIndexChanged(object sender, EventArgs e)
        {
            td = comboBox_TD.SelectedItem.ToString();
        }

        private void spinEdit_SCT_TextChanged(object sender, EventArgs e)
        {
            sct = (Int16)spinEdit_SCT.Value;
        }
    }
}
