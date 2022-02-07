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

            data.Columns.Add("Name");
            data.Columns.Add("Roll");
            data.Columns.Add("CNIC");
            dataGridView1.DataSource = data;
        }

       

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


           

            DataRow row1 = data.NewRow();

            row1["Name"] = name.Text;
            row1["Roll"] = roll.Text;
            row1["CNIC"] = cnic.Text;
            data.Rows.Add(row1);
            dataGridView1.Refresh();

            name.Text = "";
            roll.Text = "";
            cnic.Text = "";


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(name.Text) && !String.IsNullOrWhiteSpace(cnic.Text))
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["Roll"].ToString() == roll.Text)
                    {
                        row["Name"] = name.Text;
                        row["CNIC"] = cnic.Text;
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Kindly Fill the Requirements!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(roll.Text))
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["Roll"].ToString() == roll.Text)
                    {
                        data.Rows.Remove(row);
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Kindly Fill the Requirements!");
            }
        }
    }
    
}
