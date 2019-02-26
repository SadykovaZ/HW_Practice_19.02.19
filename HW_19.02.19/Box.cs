using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19._02._19
{
    public class Box
    {
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public Box()
        { }

        public Box(double len, double wid, double hei)
        {
            length = len;
            width = wid;
            height = hei;
        }

        public static bool operator ==(Box a, Box b)
        {
            bool status = false;
            if (a.length == b.length && a.width == b.width && a.height == b.height)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Box a, Box b)
        {
            bool status = false;
            if (a.length != b.length || a.width != b.width || a.height != b.height)
            {
                status = true;
            }
            return status;
        }

        public bool Equals(Box obj)
        {
            return (length == obj.length && width == obj.width && height == obj.height);
        }



    }
}
