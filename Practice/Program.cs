using System;

namespace Std {
    class Sorting {
        static void Main (string[] args) {
            int[] myAverages = { 3, 2, 1, 4, 6, 8, 9 };

            for (int i = myAverages.Length - 2; i >= 0; i--) {
                // for (int j = 0; j < myAverages.Length; j++)
                // {

                 {
                    int a = myAverages[i];
                    myAverages[i] = myAverages[i + 1];
                    myAverages[i + 1] = a;
                    i = myAverages.Length - 2;
                }

                // if (myAverages[0] > myAverages[1])
                // {
                //     int a = myAverages[0];
                //     myAverages[0] = myAverages[1];
                //     myAverages[1] = a;
                }
                for (int i = 0; i < myAverages.Length; i++)
                {
                    Console.WriteLine (myAverages[i]);
                }

            

        }

    }
}