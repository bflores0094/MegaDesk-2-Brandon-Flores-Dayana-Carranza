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
    public partial class AddQuote : Form
    {
       
        public AddQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.MaterialState>();
            materials = Enum.GetValues(typeof(Desk.MaterialState)).Cast<Desk.MaterialState>().ToList();
            MaterialInput.DataSource = materials;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
           

            string strMaterial = MaterialInput.Text;
            decimal widthNum = WidthInput.Value;
            decimal heightNum = HeightInput.Value;
            decimal drawerNum = DrawerInput.Value;
            decimal shippingNum = Convert.ToDecimal(ShippingInput.Text);
            string custName = NameInput.Text;
            decimal materialNum;
            StreamWriter writer;



            if (strMaterial == "oak")
            {
                materialNum = 1;

            }
            else if (strMaterial == "laminate")
            {

                materialNum = 2;

            }
            else if (strMaterial == "pine")
            {

                materialNum = 3;

            }
            else if (strMaterial == "rosewood")
            {

                materialNum = 4;

            }
            else if (strMaterial == "veneer")
            {

                materialNum = 5;

            }
            else
            {

                materialNum = 1;

            }

            if (custName == "" || custName.All(char.IsDigit))
            {
                label6.Text = "Please enter a valid name";
            }
            else
            {

                try
                {


                    Desk newDesk = new Desk(widthNum, heightNum, drawerNum, materialNum);

                    DeskQuote newQuote = new DeskQuote(newDesk, custName, shippingNum);
                    writer = new StreamWriter("quotes.txt", true);
                    writer.Write(newQuote.Date.ToString("MM/dd/yyyy") + ", " +
                        newQuote.Name + ", " + newQuote.Cost + ", " + strMaterial + "\n");
                    writer.Close();

                    label5.Text = "Table quote created!";
                    label6.Text = "";



                }
                catch
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Table quote could not be made";

                }


            }
 



        }
    }

}
