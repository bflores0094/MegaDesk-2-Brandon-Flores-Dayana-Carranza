using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MegaDesk
{
    class DeskQuote
    {
        public Desk Desk { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public decimal Shipping { get; set; }
        const decimal BASE_PRICE = 200;
        public decimal materialInt;

        
        List<decimal> shipList = new List<decimal>();
        int[,] shippingArray = new int[3, 3];




        public DeskQuote(Desk Desk, string Name, decimal shippingNum)
        {
            this.Desk = Desk;
            this.Name = Name;
            this.Date = DateTime.Now.ToString("d");
            decimal size = Desk.widthInput * Desk.heightInput;
            this.Shipping = CalcShipping(shippingNum, size);
            decimal materialCost = GetMatCost(Desk.materialNum);
            this.Cost = GetQuote(size, this.Shipping, materialCost);
            materialInt = Desk.materialNum;
            
        
        }

        public int[,] GetRushOrder()

        {
            

            try

            {
                StreamReader reader = new StreamReader("rushOrderPrices.txt");
                
                while (reader.EndOfStream == false)
                {

                    for (int row = 0; row < 3; row++)

                    {

                        for (int col = 0; col < 3; col++)

                        {

                            string line = reader.ReadLine();

                            shippingArray[row, col] = int.Parse(line);
                        }
                    }
                }
                reader.Close();
            }
            catch (FileNotFoundException)

            {
                System.Windows.Forms.MessageBox.Show("File not found");

            }
            return shippingArray;
        }



       

        public decimal CalcShipping(decimal shippingNum, decimal size)
        {
            decimal tempShip;
            GetRushOrder();

            if (shippingNum == 3)
            {
                if (size < 1000)
                {
                    tempShip = shippingArray[0, 0];
                }
                else if (size < 2001)
                {
                    tempShip = shippingArray[0, 1];
                }
                else
                {
                    tempShip = shippingArray[0, 2];
                }
            } else if (shippingNum == 5)
            {
                if (size < 1000)
                {
                    tempShip = shippingArray[1, 0];
                }
                else if (size < 2001)
                {
                    tempShip = shippingArray[1, 1];
                }
                else
                {
                    tempShip = shippingArray[1, 2];
                }
            } else
            {
                if (size < 1000)
                {
                    tempShip = shippingArray[2, 0];
                }
                else if (size < 2001)
                {
                    tempShip = shippingArray[2, 1];
                }
                else
                {
                    tempShip = shippingArray[2, 2];
                }
            }
            return tempShip;
        }
    

        public decimal GetMatCost(decimal matNum)
        {
            decimal tempMat;
            
            if (matNum == 1)
            {
                tempMat = 200;
            } else if (matNum == 2)
            {
                tempMat = 100;
            } else if (matNum == 3)
            {
                tempMat = 50;
            } else if (matNum == 4)
            {
                tempMat = 300;
            } else
            {
                tempMat = 125;
            }
            return tempMat;
        }

        public decimal GetQuote(decimal size, decimal shipping, decimal materialCost)
        {
            decimal cost;

            if (size < 1000)
            {
                cost = BASE_PRICE + shipping + materialCost;
            } else
            {
                cost = BASE_PRICE + size + shipping + materialCost;
            }
            return cost;
        }





    }
}
