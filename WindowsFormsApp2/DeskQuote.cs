using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk
{
    class DeskQuote
    {
        
        public int cost { get; set; }
        public string name { get; set; }
        public int date { get; set; }
        public int shipping { get; set; }

        Desk testDesk = new Desk().CreateDesk();
        

        public int GetQuote()
        {
            int size = 30 * 30;
            int materialCost = 200;
            int drawerCost = testDesk.drawer * 50;
            int shippingCost = 60;
            
            int quote = 200 + size + materialCost + drawerCost + shippingCost;
            return quote;
        }
    }
}
