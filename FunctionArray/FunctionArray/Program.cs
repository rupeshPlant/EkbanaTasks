using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionOrNot();
           
        }
        static void FunctionOrNot()
        {
            

                Console.WriteLine("how many number in array?");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] inputArray = new int[number];



                for (int i = 0; i < number; i++)
                {
                    Console.Write("element - {0}: ", i);
                    inputArray[i] = Convert.ToInt32(Console.ReadLine());

                }

                bool EveryElementGreaterThanZero()
                {
                    foreach (var items in inputArray)
                    {
                        if (items <= 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                bool EvenNumbers()
                {
                    foreach (var items in inputArray)
                    {
                        if (items % 2 == 0)
                        {

                            return true;
                        }
                    }
                    return false;
                }
                bool ExistAllSerialEvenNumbers()
                {
                    int[] evenNumberArray = new int[inputArray.Length];
                    int j = 0;


                for (int i = 0; i < inputArray.Length; i++)
                    {

                        if (inputArray[i] % 2 == 0) //making array of even numbers
                        {
                            evenNumberArray[j] = inputArray[i];
                            j++;
                        }

                    }

                    //Array.ForEach(evenNumberArray, Console.WriteLine);

                    int maxEvenNumber = evenNumberArray.Max();
                /*As j is incremented each time the array have even numbers
                    so for serialEvenNumber the count of j is half of the maxEvenNumber
                    that is if max number is 10 then j must be 5 (ie 10,8,6,4,2) for serial even numbers
                    that is if max number is 8 then j must be 4 (ie 8,6,4,2) for serial even numbers
                    if max number is 4 then j must be 2 (ie 4,2) for serial even numbers and so on.. */
                //if (maxEvenNumber / 2 == j)
                //{
                //    for (int k = 0; k < evenNumberArray.Length - 1; k++)
                //    {
                //        for (int l = 1; l < evenNumberArray.Length; l++)
                //        {
                //            if ((evenNumberArray[l] - evenNumberArray[k] == 2))
                //            {
                //                return true;
                //            }
                //        }
                //    }
                //}

                for (int k = 0; k < evenNumberArray.Length - 1; k++)
                {
                    for (int l = 1; l < evenNumberArray.Length; l++)
                    {
                        if ((evenNumberArray[l] - evenNumberArray[k] == 2))
                        {
                            return true;
                        }
                    }
                }
                return false;
                }
                if (EveryElementGreaterThanZero() && EvenNumbers() && ExistAllSerialEvenNumbers())
                {
                    Console.WriteLine("function array");
                    //Console.WriteLine("Zero is not present and one even number is present");
                }
                else
                {
                    Console.WriteLine("not function array");
                }

            }

        }
    }



