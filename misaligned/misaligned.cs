using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int Colour Number =0;
            Console.WriteLine("{0,-3} | {1,-7} | {2,-6}", "Serial No", "Major", "Minor");
            int i = 0, j = 0;
            for(i = 0; i < majorColors.Length; i++) {
                for(j = 0; j < minorColors.Length; j++) {
                    Console.WriteLine("{0,-3} | {1,-7} | {2,-6}",Colour Number, majorColors[i], minorColors[j]);
                    Colour Number++;
                }
            }
            return Colour Number;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
