using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace halısaha_otomasyonu
{
    public partial class Bakiye : Form
    {
        int userid,bakiye;
        public Bakiye(int uid,int bak)
        {
            InitializeComponent();
            userid = uid;
            bakiye = bak;
        }

        private NpgsqlConnection connection;
        private DataSet dataSet;
        private string sql;

        private void Bakiye_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=hsaha; User Id=postgres; Password=6123571;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToInt32(textBox2.Text) + bakiye;

            try
            {
                dataSet = new DataSet();
                sql = "update user_ set bakiye=" + bakiye + " where userid = " + userid + "";
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                add.Fill(dataSet);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL HATASI");
                connection.Close();
            }
            MessageBox.Show("Bakiye Yükleme Başarılı!");
            this.Hide();
            main m1 = new main(userid, bakiye);
            m1.ShowDialog();
            this.Close();

        }
    }
}
