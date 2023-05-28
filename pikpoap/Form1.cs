using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pikpoap
{
    public partial class Form1 : Form
    {
        enum RoWState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        DataBase dataBase = new DataBase();

        int selectedRow;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name_apteka", "Наименование аптеки");
            dataGridView1.Columns.Add("name_preparat", "Наименование препарата");
            dataGridView1.Columns.Add("count", "Количество");
            dataGridView1.Columns.Add("price", "Стоимость");
            dataGridView1.Columns.Add("provider", "Наименование поставщика");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void ClearFields()
        {
            textBox.Text = "";
            textBoxapt.Text = "";
            textBoxprep.Text = "";
            textBoxcount.Text = "";
            textBoxstoim.Text = "";
            textBoxpostav.Text = "";
        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5), RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from ap_db";


            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox.Text = row.Cells[0].Value.ToString();
                textBoxapt.Text = row.Cells[1].Value.ToString();
                textBoxprep.Text = row.Cells[2].Value.ToString();
                textBoxcount.Text = row.Cells[3].Value.ToString();
                textBoxstoim.Text = row.Cells[4].Value.ToString();
                textBoxpostav.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            Add_Form add_Form = new Add_Form();
            add_Form.Show();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from ap_db where concat(id, name_apteka, name_preparat, provider, count, price) like '%" + textBox1.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.GetConnection());


            dataBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);

        }
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RoWState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RoWState.Deleted;

        }
        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView1.Rows[index].Cells[6].Value;
                if (rowState == RoWState.Existed)
                    continue;

                if (rowState == RoWState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from ap_db where id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
         
               
                }
            }
            dataBase.closeConnection();
        }
        private void buttondel_Click_1(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

        
    