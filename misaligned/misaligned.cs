using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int Colourcount = 0;
            Console.WriteLine("{0,-3} | {1,-7} | {2,-6}", "No", "Major", "Minor");
            for(int i = 0; i < majorColors.Length; i++) {
                for(int j = 0; j < minorColors.Length; j++) {
                    Console.WriteLine("{0,-3} | {1,-7} | {2,-6}", pairNumber, majorColors[i], minorColors[j]);
                    pairNumber++;
                }
            }
            Debug.Assert(pairNumber == majorColors.Length * minorColors.Length);
            Debug.Assert(pairNumber == 25);
            return pairNumber;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Debug.Assert(result > 0);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
