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
    public partial class SahaSeçim : Form
    {
        int userid,bakiye;
        public SahaSeçim(int uid,int bak)
        {
            InitializeComponent();
            userid = uid;
            bakiye = bak;
        }

        private void saatseçim(int sahaid)
        {
            Saat_secim sc = new Saat_secim(sahaid,userid,bakiye);
            this.Hide();
            sc.ShowDialog();
        }




        private void button3_Click(object sender, EventArgs e) // boş
        {
            MessageBox.Show(Convert.ToString(userid));
        }

        private void button1_Click(object sender, EventArgs e) // bağcılar
        {
            saatseçim(1);
        }

        private void button3_Click_1(object sender, EventArgs e) // esenler
        {
            saatseçim(2);
        }

        private void button2_Click(object sender, EventArgs e) // bakırköy
        {
            saatseçim(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saatseçim(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saatseçim(6);
        }

        private void button4_Click(object sender, EventArgs e) // zeytinburnu
        {
            saatseçim(5);
        }
    }
}
