using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int serial Number =0
            int i = 0, j = 0;
            for(i = 0; i < majorColors.Length; i++) {
                for(j = 0; j < minorColors.Length; j++) {
                    Console.WriteLine("{0-3} | {1-7} | {2-6}",serial Number, majorColors[i], minorColors[j]);
                    serial Number++;
                }
            }
            return serial Number;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
