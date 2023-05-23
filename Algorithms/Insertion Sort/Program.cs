using System;

namespace InsertionSort 
{
    internal class Program
    {
        public static List<int> InsertionSort(List<int> list)
        {
            int temp = 0;
            int j = 0;
            for (int i = 1; i < list.Count; i++)
            {
                temp = list[i];
                j = i - 1;

                while (temp < list[j] )
                {
                    list[j + 1] = list[j];
                    list[j] = temp;
                    j -= 1;
                    if (j < 0)
                        break;
                }
            }
            return list;
        }

        public static void Main(string[] args)
        {
            var list = new List<int>()
            {
                112,24, 3, 49, 555, 61, 74, 8, 99, 10
            };

            Console.WriteLine("Before Sorting : ");
            list.ForEach(item => Console.Write(item + " "));

            var sortingList = InsertionSort(list);

            Console.WriteLine("\nAfter Sorting : ");
            sortingList.ForEach(item => Console.Write(item + " "));


            Console.WriteLine("\n--------------------------------------------");

            List<int> list2 = new List<int>
            {
                10,9,8,7,6,5,4,3,2,1
            };

            Console.WriteLine("Before Sorting : ");
            list2.ForEach(item => Console.Write(item + " "));

            var sortingList2 = InsertionSort(list2);

            Console.WriteLine("\nAfter Sorting : ");
            sortingList2.ForEach(item => Console.Write(item + " "));
        }
    }
}