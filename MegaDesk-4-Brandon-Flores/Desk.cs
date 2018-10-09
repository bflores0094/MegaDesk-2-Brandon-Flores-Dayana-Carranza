using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    
    class Desk
    {
        enum materialState
        {
            oak,
            laminate,
            pine,
            rosewood,
            veneer
        };

        
        public string width { get; set; }
        public string height { get; set; }
        public string material { get; set; }
        public int drawer { get; set; }

        

        public Desk constructor()
        {
            this.width = width;
            this.height = height;
            this.material = material;
            this.drawer = drawer;
            return this;
        }

    }
}
