using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halısaha_otomasyonu
{
    public partial class main : Form
    {

        int userid,bakiye;
        public main(int uid,int bak)
        {
            InitializeComponent();
            userid = uid;
            bakiye = bak;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(userid);
            label4.Text = Convert.ToString(bakiye) + "TL";

            if (userid != 1)
                button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SahaSeçim f1 = new SahaSeçim(userid, bakiye);
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bakiye b1 = new Bakiye(userid, bakiye);
            this.Hide();
            b1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            raporlama r1 = new raporlama();
            r1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervasyonlar r1 = new Rezervasyonlar(userid, bakiye);
            this.Hide();
            r1.ShowDialog();
            this.Close();
        }
    }
}
