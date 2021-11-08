using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of array");
            Console.WriteLine();
            int arraySize = int.Parse(Console.ReadLine());

            int[] inputArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Enter Element:- {0}",i+1);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the item to be Searched.!");
            int itemToBeSearched = int.Parse(Console.ReadLine());

            BinarySearch(inputArray, itemToBeSearched);


            int BinarySearch( int[] array,int item)
            {
                Array.Sort(array);
                int right = array.Length - 1;
                int left = 0;
                while (left <= right)
                {
                    int middle = (right + left) / 2;
                    if (array[middle] == item)
                    {
                        Console.WriteLine("index is: " + middle +" and item is: " + item);
                        return item ;
                    }
                    else if(array[middle] > item)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                Console.WriteLine("no items found");
                return -1;
            }
        }
    }
}

//Console.WriteLine("Enter number of  names");
//int number = int.Parse(Console.ReadLine());
//string[] arrayName = new string[number];

//for (int i = 0; i <= number - 1; i++)
//{
//    Console.WriteLine("Enter name{0}-", i);
//    arrayName[i] = Console.ReadLine();
//}
//Array.Sort(arrayName);
//Console.WriteLine();
//Array.ForEach(arrayName, Console.WriteLine);
//Console.WriteLine();
//Console.WriteLine("Enter the Name you want to search.?");

//string searchedName = Console.ReadLine();

//while (true)
//{
//    int middleIndex =
//            }