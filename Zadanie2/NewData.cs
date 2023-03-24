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
    public partial class NewData : Form
    {
        DataBase_Connection DataBase = new DataBase_Connection();

        public NewData()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.OpenConnection();

            var nmb = nmbBox.Text;
            var name = nameBox.Text;

            var addquery = $"insert into Tel_Kniga (Nomer, FIO) values ('{nmb}', '{name}')";

            var command = new SqlCommand(addquery, DataBase.GetConnection());

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись успешно создана");
            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }

            DataBase.CloseConnection();
            this.Hide();
        }
    }
}
