using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk
{
    class DeskQuote
    {

        public Desk Desk { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Shipping { get; set; }


        public int GetQuote(Desk desk)
        {
            int size = 30 * 30;
            int materialCost = 200;
            int drawerCost = desk.drawer * 50;
            int shippingCost = 60;
            
            int quote = 200 + size + materialCost + drawerCost + shippingCost;
            return quote;
        }
    }
}
