using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("Roll");
            data.Columns.Add("CNIC");

            DataRow row1 = data.NewRow();

            row1["Name"] = "Ali";
            row1["Roll"] = "22";
            row1["CNIC"] = "24134513451345";
            data.Rows.Add(row1);


            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
