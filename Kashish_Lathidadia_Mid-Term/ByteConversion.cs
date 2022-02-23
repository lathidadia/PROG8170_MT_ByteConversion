using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kashish_Lathidadia_Mid_Term
{
    public static class ByteConversion
    {
        private static int Input { get; set; }

        public static double MegabytesToBytes(double Input)
        {
            double result = Input * Math.Pow(2,20);
            return result;
        }
        public static double GigabytesToMegabytes(double Input)
        {
            double result = Input * 1024;
            return result;
        }
        public static double TerabytesToGigabytes(double Input)
        {
            double result = Input * 1024;
            return result;
        }

    }
}
