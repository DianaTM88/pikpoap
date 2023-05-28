using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace pikpoap
{
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name_apteka = textBox_aptek.Text;
            var name_preparat = textBox_prepar.Text;
            var provider = textBox_post.Text;
            int count;
            int price;

            if(int.TryParse(textBox_st.Text, out price) && int.TryParse(textBox_colvo.Text, out count))
            {
                var addQuery = $"insert into ap_db (name_apteka, name_preparat, provider, count, price) values('{name_apteka}', '{name_preparat}', '{provider}', '{count}', '{price}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Entry create!");
            }
            else
            {
                MessageBox.Show("Error");
            }
           
            dataBase.closeConnection();
        }

        private void textBox_aptek_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
