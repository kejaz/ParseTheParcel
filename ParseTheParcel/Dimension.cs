using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel
{
    public class Dimensions
    {
        int length { get; set; }
        int breadth { get; set; }
        int height { get; set; }
        public Dimensions(int pLength, int pBreadth, int pHeight)
        {
            try
            {
                this.length = pLength;
                this.breadth = pBreadth;
                this.height = pHeight;
            }
            catch(Exception ex) {

                throw ex;
            }
        }
        public  int Length {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public  int Breadth {
            get
            {
                return breadth;
            }
            set
            {
                length = value;
            }
        }
        public  int Height {
            get
            {
                return height;
            }
            set
            {
                length = value;
            }
        }

    }
}
