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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private NpgsqlConnection connection;
        private DataSet dataSet;
        private string sql;

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                int bakiye;
                string username = textBox2.Text, pass = textBox1.Text,pass2;
                dataSet = new DataSet();
                sql = "select * from user_ where username = " + "'" + username + "'";
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection);
                add.Fill(dataSet);
                pass2 = Convert.ToString(dataSet.Tables[0].Rows[0]["password"]);
                int userid = Convert.ToInt32(dataSet.Tables[0].Rows[0]["userid"]);
                bakiye = Convert.ToInt32(dataSet.Tables[0].Rows[0]["bakiye"]);
                if (pass == pass2)
                {
                    main m1 = new main(userid,bakiye);
                    this.Hide();
                    m1.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("YANLIŞ KULLANICI ADI VEYA ŞİFRE");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL_HATASI");
                connection.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=hsaha; User Id=postgres; Password=6123571;");

            
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıt k = new Kayıt();
            k.Show();
        }
    }
}
