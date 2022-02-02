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
        DataTable data = new DataTable();

        public Form1()
        {
            InitializeComponent();


            dataGridView1.DataSource = data;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            data.Columns.Add("Name");
            data.Columns.Add("Roll");
            data.Columns.Add("CNIC");

            DataRow row1 = data.NewRow();

            row1["Name"] = name.Text;
            row1["Roll"] = roll.Text;
            row1["CNIC"] = cnic.Text;
            data.Rows.Add(row1);
            dataGridView1.Refresh();

        }
    }
}
