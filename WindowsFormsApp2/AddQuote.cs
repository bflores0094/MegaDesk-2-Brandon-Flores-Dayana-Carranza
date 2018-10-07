using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Desk newDesk = new Desk();
            newDesk.width = WidthInput.Text;
            newDesk.height = HeightInput.Text;
            newDesk.drawer = 2;
            int value;

            if (int.TryParse(newDesk.width, out value) && int.TryParse(newDesk.height, out value))
            {
                int convertWidth = System.Convert.ToInt32(newDesk.width);
                int convertHeight = System.Convert.ToInt32(newDesk.height);

                ValidateNums(convertWidth, convertHeight);

            }
            else if (!int.TryParse(newDesk.width, out value))
            {
                ValError.Text = "Width must be a number";
            }
            else
            {
                ValError.Text = "Height must be a number";

            }
        }

          


        private void ValidateNums(int width, int height)
        {
            if ((width > 23 && width < 97) && (height > 11 && height < 49))
            {
                DeskQuote newQuote = new DeskQuote();
                QuoteLabel.Text = newQuote.GetQuote().ToString() + '$';

            } else 
            {
                ValError.Text = "Width must be between 24-96 feet";

            } 


        }

        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && e.KeyChar > 12 && e.KeyChar < 48)
            {
                ValError.Text = "";
            } else
            {
                ValError.Text = "Height must be a number between 12-48 feet";

            }
        }
    }
}
