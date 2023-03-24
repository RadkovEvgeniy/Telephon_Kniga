using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zadanie2
{
    enum rowstate
    {
        existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        DataBase_Connection DataBase = new DataBase_Connection();

        int selectedrow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createcolumns();
            refreshdatagrid(dataGridView1);
            dataGridView1.BackgroundColor = Color.NavajoWhite;
        }

        private void createcolumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Nomer", "Номер телефона");
            dataGridView1.Columns.Add("FIO", "Имя");
            dataGridView1.Columns.Add("New", String.Empty);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void readsinglerow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), rowstate.ModifiedNew);
        }

        private void refreshdatagrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            String querystring = $"select * from Tel_Kniga";

            SqlCommand command = new SqlCommand(querystring, DataBase.GetConnection());

            DataBase.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readsinglerow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;

            if(e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];

                idBox.Text = row.Cells[0].Value.ToString();
                nomerBox.Text = row.Cells[1].Value.ToString();
                FIOBox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            String searchstr = $"select * from Tel_Kniga where concat (id, Nomer, FIO) like '%" + searchBox.Text + "%'";

            SqlCommand command = new SqlCommand(searchstr, DataBase.GetConnection());

            DataBase.OpenConnection();

            SqlDataReader read = command.ExecuteReader();

            while(read.Read())
            {
                readsinglerow(dgw, read);
            }
            read.Close();

            DataBase.CloseConnection();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            search(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewData nd = new NewData();
            nd.Show();
        }

        private void deleteData()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if(dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[3].Value = rowstate.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[3].Value = rowstate.Deleted;
        }

        private void updateData()
        {
            DataBase.OpenConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var row = (rowstate)dataGridView1.Rows[index].Cells[3].Value;

                if (row == rowstate.existed)
                    continue;

                if(row == rowstate.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deletequery = $"delete from Tel_Kniga where id = {id}";

                    var command = new SqlCommand(deletequery, DataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

                
                if(row == rowstate.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var nmb = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changequery = $"update Tel_Kniga set Nomer = '{nmb}', FIO = '{fio}' where id = '{id}'";

                    var command = new SqlCommand(changequery, DataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }

        private void changeData()
        {
            var selectedrowindex = dataGridView1.CurrentCell.RowIndex;

            var id = idBox.Text;
            var nmb = nomerBox.Text;
            var fio = FIOBox.Text;

            if(dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString() != string.Empty )
            {
                dataGridView1.Rows[selectedrowindex].SetValues(id, nmb, fio);
                dataGridView1.Rows[selectedrowindex].Cells[3].Value = rowstate.Modified;
            }
        }

        private void clear()
        {
            nomerBox.Text = "";
            FIOBox.Text = "";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deleteData();
            clear();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            changeData();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            updateData();
            refreshdatagrid(dataGridView1);
        }
    }
}
