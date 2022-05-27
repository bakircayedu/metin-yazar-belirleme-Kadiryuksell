using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2106061686_KadirKağanYüksel
{
    public class heapSort
    {
        public void sort(int[] dizi)
        {
            int k = dizi.Length;


            for (int i = k / 2 - 1; i >= 0; i--)
                heapify(dizi, k, i);


            for (int i = k - 1; i > 0; i--)
            {

                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;


                heapify(dizi, i, 0);
            }
        }


        void heapify(int[] dizi, int n, int i)
        {
            int largest = i;
            int temp1 = 2 * i + 1;
            int temp2 = 2 * i + 2;


            if (temp1 < n && dizi[temp1] > dizi[largest])
                largest = temp1;

            if (temp2 < n && dizi[temp2] > dizi[largest])
                largest = temp2;

            if (largest != i)
            {
                int swap = dizi[i];
                dizi[i] = dizi[largest];
                dizi[largest] = swap;

                heapify(dizi, n, largest);
            }
        }

        static int printArray(int[] dizi)
        {
            int n = dizi.Length;
            for (int i = 0; i < n; i++)
            return dizi[i];
        }
    }
}
