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
using Newtonsoft.Json;

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
          //  StreamReader reader = new StreamReader("quotes.txt");
            DataTable quoteDt = new DataTable();
            string Date = "Date";
            string Name = "Name";
            string Quote = "Quote";
            string Material = "Material";
            List<DeskQuote> quoteList = new List<DeskQuote>();

            using (StreamReader file = File.OpenText("quotes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                DeskQuote currDeskQuote = (DeskQuote)serializer.Deserialize(file, typeof(DeskQuote));
                quoteList.Add(currDeskQuote);
            }
            

            quoteDt.Columns.Add(Date);
            quoteDt.Columns.Add(Name);
            quoteDt.Columns.Add(Quote);
            quoteDt.Columns.Add(Material);



           
            for (int i = 0; i < quoteList.Count; i++)
            { 
                string matStr = GetMatStr(quoteList[i].materialInt);
                quoteDt.Rows.Add(quoteList[i].Date, quoteList[i].Name,
                                 quoteList[i].Cost, matStr);
            }
          //  reader.Close();
            dataGridView1.DataSource = quoteDt;

        }

        public string GetMatStr(decimal mat)
        {
                string tempMat;

                if (mat == 1)
                {
                    tempMat = "Oak";
                }
                else if (mat == 2)
                {
                    tempMat = "Laminate";
                }
                else if (mat == 3)
                {
                    tempMat = "Pine";
                }
                else if (mat == 4)
                {
                    tempMat = "Rosewood";
                }
                else
                {
                    tempMat = "Veneer";
                }
                return tempMat;
            
        }
    }
}
