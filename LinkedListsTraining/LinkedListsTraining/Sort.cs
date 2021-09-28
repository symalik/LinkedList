﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for(var i =0; i < arr.Length - 1; i++)
            {
                for (var k = 0; k < arr.Length - 1 - i; k++)
                {
                    if(arr[k] > arr[k + 1])
                    {
                        var temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }

        public static void Selection(int[] arr)
        {
            int smallest, temp;
            
            for(int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;

                for(int k = i + 1; k < arr.Length; k++)
                {
                    if(arr[k] < arr[smallest])
                    {
                        smallest = k;
                    }

                }

                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;


            }
        }

        public static void Insertion(int[] arr)
        {
            
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while(j > 0 && arr[j].CompareTo(arr[j-1]) < 0)
                {
                    Swap(arr, j, j - 1);
                    j--;
                }

            }

            static void Swap<T>(T[] arr, int first, int second)
            {
                T temp = arr[first];
                arr[first] = arr[second];
                arr[second] = temp;
            }
        }


        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;
            //divide array in half

            //find a midpoint
            decimal midpoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midpoint));

            //Chop into to arrays
            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            var botOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combined = Combine(botOut, topOut);

            return combined;

        }

        private static int[]Combine(int[] bottom, int[] top)
        {
            var i = 0; //bottom
            var j = 0; //top
            var k = 0;
            var arr = new int[bottom.Length + top.Length];

            while(i < bottom.Length && j < top.Length)
            {
                if(bottom[i] < top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }
                else
                {
                    arr[k] = top[j];
                    j++;
                }

                k++;
            }

            while(i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while(j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }
            return arr;

        }
    }
}
