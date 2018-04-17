using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Program.HammingDistance(x,y);
        }

        public static int HammingDistance(int x, int y)
        {
            //Score 78th percentile.
            int distance = 0;
            //Create two lists of the binary values.  Repetitive but didn't know how else to do it.
            //Requirements states to take ints as input.
            List<Int32> xBin = Convert.ToString(x, 2).Select(s => Int32.Parse(s.ToString())).ToList();
            List<Int32> yBin = Convert.ToString(y, 2).Select(s => Int32.Parse(s.ToString())).ToList();
            //Reverse the bits to be in proper binary.
            xBin.Reverse();
            yBin.Reverse();
            //Get which list is longer.
            int longestLength = (xBin.Count > yBin.Count) ? xBin.Count : yBin.Count;
            //Fill in shorter list with zeros.
            if (longestLength != xBin.Count) { xBin.AddRange(new Int32[longestLength-xBin.Count]); }
            else { yBin.AddRange(new Int32[longestLength-yBin.Count]);}
            //Compare bits and if they don't match increase distance.
            for (int i = 0; i < longestLength; i++)
            {
                if(xBin[i] != yBin[i]) { distance++;}
            }
            //return Hamming distance.
            return distance;
        }
    }
}
