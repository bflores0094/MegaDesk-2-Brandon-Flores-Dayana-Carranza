using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    
    public class Desk
    {

        public enum MaterialState
        {
            oak,
            laminate,
            pine,
            rosewood,
            veneer
        };
        public decimal widthInput;
        public decimal heightInput;
        public decimal drawerInput;
        public decimal materialNum;


        public Desk(decimal widthInput, decimal heightInput, decimal drawerInput, decimal materialNum)
        {
            this.widthInput = widthInput;
            this.heightInput = heightInput;
            this.drawerInput = drawerInput;
            this.materialNum = materialNum;

        }


    }
}
