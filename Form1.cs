using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace data_tables
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();//data = table
        string path = @"C:\Users\RANA ABOBAKAR\Desktop\table_data.txt";
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add("Name");
            data.Columns.Add("Roll");
            data.Columns.Add("CNIC");
            dataGridView1.DataSource = data;
            readfile();
        }

       

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


           

            DataRow row1 = data.NewRow();

            row1["Name"] = name.Text;//textBox1.Text
            row1["Roll"] = roll.Text;
            row1["CNIC"] = cnic.Text;
            data.Rows.Add(row1);
            dataGridView1.Refresh();
            write_file();

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
                        edit_file();
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
                        edit_file();
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Kindly Fill the Requirements!");
            }
        }

        //Write File
        public void write_file()
        {
            string path = @"C:\Users\RANA ABOBAKAR\Desktop\table_data.txt";
            FileStream fs = File.Open(path, FileMode.Append,FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                    sw.WriteLine(roll.Text);
                    sw.WriteLine(name.Text);
                    sw.WriteLine(cnic.Text);
            }
        }
        private void readfile()
        {
            string path = @"C:\Users\RANA ABOBAKAR\Desktop\table_data.txt";
            if (File.Exists(path))
            {
                FileStream fs = File.Open(path, FileMode.Open);
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        DataRow row = data.NewRow();
                        row["Roll"] = sr.ReadLine();
                        row["Name"] = sr.ReadLine();
                        row["CNIC"] = sr.ReadLine();
                        data.Rows.Add(row);
                    }

                }
            }
            else
            {
                FileStream file = new FileStream(path, FileMode.Create);
                file.Close();
            }
        }
        private void edit_file()
        {
            string path = @"C:\Users\RANA ABOBAKAR\Desktop\table_data.txt";
            if (File.Exists(path)) { File.Delete(path); }
            FileStream fs = File.Open(path, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (DataRow row in data.Rows) { 
                sw.WriteLine(row["Roll"]);
                sw.WriteLine(row["Name"]);
                sw.WriteLine(row["CNIC"]);
            }
            }
        }

    }
    
}
