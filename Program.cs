using System;
//ConsoleApp4
namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method-1 SearchInsert() 
            Console.WriteLine("Enter key:");
            string k = Console.ReadLine();
            int key = int.Parse(k);
            int[] arr1 = input_array();
            //Console.WriteLine("Enter press enter for the output :");
            int x = Convert.ToInt32(SearchInsert(arr1, key));
            Console.WriteLine("Output: " + x);
            Console.Read();
            //-----------------------------------Method-3-LargestUniqueNumber()------------------------------
            //int[] A = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
            int[] arr2 = input_array();
            //int len2 = input_array_length();
            Console.WriteLine("Largest integer occuring once = {0}\n", LargestUniqueNumber(arr2));
            Console.Read();
            //-----------------------------------Method--5LargestUniqueNumber()------------------------------

            //int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };
            Console.WriteLine("Please enter the binary array for method LargestUniqueMethod");
            int[] flip_arr_input = input_array();
            //Console.WriteLine("\n");
            int[] horizontal_arr = Flip_array(flip_arr_input);
            Console.WriteLine("The resulting flipped and inverted image is :", horizontal_arr);
            for (int i = 0; i < horizontal_arr.Length; i++)
            {
                Console.Write(Convert.ToInt32(horizontal_arr[i]));
            }
            Console.Read();
            Console.WriteLine("\n");
            //Display2DArray(flipAndInvertedImage);
            Console.Read();

            //----------------------------------------END-------------------------------------------------------
        }
        public static int input_array_length()
        {
            Console.WriteLine("Please enter the length of array");
            string arrlen = Console.ReadLine();
            int arrayLength = int.Parse(arrlen);
            return arrayLength;
        }
        public static int[] input_array()
        {
            //This loop is to read the array from console
            Console.WriteLine("Please enter the length of array");
            string arrlen = Console.ReadLine();
            int arrayLength = int.Parse(arrlen);
            int[] array = new int[arrayLength];
            Console.Write("Please enter elements of the input array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("This is your input array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(Convert.ToInt32(array[i]));
            }
            Console.Read();
            return (array);
        }
        public static void Display2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        //------------------------------Method-1-----------------------------------------------------------------------
        public static int SearchInsert(int[] arr1, int key)
        {
            int[] inputArray = arr1;

            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                //Console.WriteLine(mid);
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else if (key > inputArray[mid])
                {
                    min = mid + 1;
                }

            }

            int i = inputArray.Length - 1;
            while (i != -1)
            {
                if (key < inputArray[i])
                {
                    i--;
                }
                else
                    return (i + 1);
            }
            return (0);
        }
        //------------------------------Method-3-----------------------------------------------------------------------
        public static int LargestUniqueNumber(int[] A)
        {
            //int array_length = A.Length;
            try
            {
                int temp = 0;

                for (int m = 0; m < A.Length;m++)
                {
                    int count = 0;
                    for (int n = 0; n < A.Length;n++)
                    {
                        if (A[m] == A[n])
                        {
                            count++; 
                        }
                    }
                    if (count == 1 && temp < A[m])
                    {
                        temp = A[m];
                    }
                    else if (count > 1 && m != A.Length - 1)
                    {
                        temp = A[m];
                    }
                    else
                    {
                        temp = -1;
                    }
                }
                return temp;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing LargestUniqueNumber()");
            }
            return 0;
        }
        //------------------------------Method-5------------------------------------------------------------------------
        public static int[] FlipAndInvertImage(int[] B)
        {
            try
            {
                int[] C = new int[B.Length];
                for (int i =0;i<B.Length-1;i++)
                {
                    if (B[i] == 0)
                    {
                        C[i] = 1;
                    }
                    else
                        C[i] = 0;
                }
                Console.WriteLine("This is your Inverted array: ");
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write(Convert.ToInt32(C[i]));
                }
                Console.Read();
                return (C);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing FlipAndInvertImage()");
            }
            return new int[] { };
        }
        public static int[] Flip_array(int[] B)
        {
            //int[] C = new int[B.Length];
            //Array.Reverse(B);

            int[] array = new int[B.Length];
            int j = 0;
            int i = 0;
            for(i = B.Length-1,j = 0; i>=0 && j < B.Length; i--,j++)
            {
                array[j] = B[i];
            }
            Console.WriteLine("This is your Flipped array: ");
            for (int m = 0; m < B.Length; m++)
            {
                Console.Write(Convert.ToInt32(array[m]));
            }
            Console.Read();
            Console.WriteLine("\n");
            return (array);
        }
        //------------------------------Method---------------------------------


    }
}