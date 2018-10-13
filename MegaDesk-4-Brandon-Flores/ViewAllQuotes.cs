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

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void viewBack_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("quotes.txt");
            DataTable quoteDt = new DataTable();
            string Date = "Date";
            string Name = "Name";
            string Quote = "Quote";
            string Material = "Material";

            quoteDt.Columns.Add(Date);
            quoteDt.Columns.Add(Name);
            quoteDt.Columns.Add(Quote);
            quoteDt.Columns.Add(Material);



            string[] columns;
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                
                 columns = line.Split(',');
                quoteDt.Rows.Add(columns);


               

            }
            reader.Close();
            dataGridView1.DataSource = quoteDt;

        }
    }
}
