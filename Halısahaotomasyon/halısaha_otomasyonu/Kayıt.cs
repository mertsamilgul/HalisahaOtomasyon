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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        private NpgsqlConnection connection;
        private DataSet dataSet;
        private string sql;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox2.Text, pass = textBox1.Text, pass2=textBox3.Text;
                dataSet = new DataSet();
                if (pass == pass2)
                {
                    sql = "insert into user_ (username,password,bakiye) values('" + username + "','" + pass + "',0)";
                    NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                    add.Fill(dataSet);
                    MessageBox.Show("Kayıt Başarılı!");
                    this.Close();
                }
                else
                    MessageBox.Show("Girdiğiniz Şifreler Aynı Değil!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL HATASI");
                connection.Close();
            }
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=hsaha; User Id=postgres; Password=6123571;");
        }


    }
}
