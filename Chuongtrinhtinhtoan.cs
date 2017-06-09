using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Chuongtrinhtinhtoan : Form
    {
        public Chuongtrinhtinhtoan()
        {
            InitializeComponent();
        }

        private void Chuongtrinhtinhtoan_Load(object sender, EventArgs e)
        {
            this.Text = "Chương trình tính toán";
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            string strSoa = ""; strSob = ""; strPhepToan = "";
            float soa = 0, sob = 0, ketqua = 0;
            strSoa = txtSoa.Text;
            strSob = txtSob.Text;
            strPhepToan = txtPhepToan.Text;
            if (strSoa.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập số a để thực hiện");
                txtSoa.Focus();
                return;
            }
            if (strSob.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập số b để thực hiện");
                txtSob.Focus();
                return;
            }
            if (string.IsNullOrEmpty(strPhepToan))
            {
                MessageBox.Show("Bạn cần phải chọn phép toán trước khi thực hiện");
                cboPhepToan.Focus();
                return;
            }
            soa = float.Parse(strSoa);
            sob = float.Parse(strSob);
            swich(strPhepToan)
            {
                case "Cộng":ketqua = soa + sob;
                break ;
                case "Trừ":ketqua= soa - sob;
                break ;
                case "Nhân":ketqua = soa * sob;
                break ;
                case "Chia":
                if(sob == 0)
                {
                    MessageBox .Show("Bạn cần phải nhập số b khác 0");
                    txtSob.Focus;
                    return;
                }
                ketqua = soa / sob;
                break ;
            }
            txtKetQua.Text = ketqua.ToString ();



        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
