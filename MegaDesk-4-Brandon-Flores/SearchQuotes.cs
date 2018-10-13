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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void viewBack_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
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


            List<string> matList = new List<string>();
            matList.Add("All");
            matList.Add("Oak");
            matList.Add("Laminate");
            matList.Add("Pine");
            matList.Add("Rosewood");
            matList.Add("Veneer");

            matBox.DataSource = matList;

            string[] columns;
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();

                columns = line.Split(',');
                quoteDt.Rows.Add(columns);




            }
            reader.Close();
            dataGridView2.DataSource = quoteDt;

        }

        private void FilterMat(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
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

            string matCase = matBox.SelectedValue.ToString();
            switch (matCase)
            {
                case "Oak":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        
                        if (line.Contains("oak"))
                        {
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                        } else{}
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;
                    break;

                case "Laminate":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();


                        if (line.Contains("laminate"))
                        {
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                        }
                        else{}
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;
                    break;

                case "Pine":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();


                        if (line.Contains("pine"))
                        {
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                        }
                        else { }
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;
                    break;

                case "Rosewood":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();


                        if (line.Contains("rosewood"))
                        {
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                        }
                        else { }
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;
                    break;

                case "Veneer":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();


                        if (line.Contains("veneer"))
                        {
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                        }
                        else { }
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;
                    break;

                case "All":
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                            columns = line.Split(',');
                            quoteDt.Rows.Add(columns);
                      
                    }
                    reader.Close();
                    dataGridView2.DataSource = quoteDt;

                    break;
            }
            }
        }
    
    }

    

