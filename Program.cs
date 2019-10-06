using System;
using System.Collections.Generic;

namespace Experimental1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //-----------------------------------Method-1-SearchInsert()------------------------------
            //int target = 5;
            //int[] nums = { 1, 3, 5, 6 };
            Console.WriteLine("Method-1-SearchInsert:Start");
            Console.WriteLine("Enter the Target:");
            string ka = Console.ReadLine();
            int target = int.Parse(ka);
            int[] arr1 = input_array();
            int x = Convert.ToInt32(SearchInsert(arr1, target));
            Console.WriteLine("Output:Position to insert target {0} is = {1}\n", target, SearchInsert(arr1, target));
            Console.Read();
            Console.WriteLine("--------------------------------------------------");
            //-----------------------------------Method-2-Intersect()------------------------------
            Console.WriteLine("Method-2-Intersect:");
            int[] nums1 = { 3,6,2 };
            int[] nums2 = { 6,3,6,7,3 };
            int[] intersect = Intersect(nums1, nums2);
            Console.WriteLine("Intersection of two arrays is: ");
            DisplayArray(intersect);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------");
            //-----------------------------------Method-3-LargestUniqueNumber()------------------------------
            Console.WriteLine("Method-3-LargestUniqueNumber:");
            int[] A = { -2,4,4,4,4,4,5,5,5,6,6,7,7,9,9,9 };
            Console.WriteLine("Output:Largest integer occuring once = {0}\n", LargestUniqueNumber(A));
            Console.WriteLine("--------------------------------------------------");
            //----------------------Method-4-CalculateTime()--------------------------------------------------
            Console.WriteLine("Method-4-CalculateTime:");
            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "mds";
            Console.WriteLine("Time taken to type with one finger is = {0} units.\n", CalculateTime(keyboard, word));
            Console.Read();
            Console.WriteLine("--------------------------------------------------");
            //----------------------Method-5-FlipAndInvertImage()---------------------------------------------
            Console.WriteLine("Method-5-FlipAndInvertImage:");
            int[,] image = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 0, 0 } };
            int[,] flipAndInvertedImage = FlipAndInvertImage(image);
            Console.WriteLine("The resulting flipped and inverted image is:\n");
            Display2DArray(flipAndInvertedImage);
            Console.Read();
            Console.WriteLine("--------------------------------------------------");
            //----------------------Method-6-MinMeetingRooms()---------------------------------------------
            Console.WriteLine("Method-6-MinMeetingRooms:");
            int a = 0;
            List<string> timeInput = new List<string>();
            Console.WriteLine("Please enter the number of meetings:");
            string n = Console.ReadLine();
            string input;
            for (int i = int.Parse(n) * 2; i > 0; i--)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Please enter start time: ");
                }
                else
                {
                    Console.WriteLine("Please enter end time: ");
                }
                input = Console.ReadLine();
                timeInput.Add(input);
                a++;
            }
            int k = 0;
            int[,] intervals = new int[timeInput.Count / 2, 2];
            for (int i = 0; i < (timeInput.Count / 2); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    intervals[i, j] = int.Parse(timeInput[k]);
                    k++;
                }
            }
            int meetingRoom = minMeetingRooms(intervals);
            Console.WriteLine("Minimum meeting rooms needed = {0}\n", meetingRoom);
            Console.WriteLine("--------------------------------------------------");
            //----------------------------Method-7-SortedSquares()------------------------------------------
            int[] arr = { -4, -1, 0, 3, 10 };
            Console.WriteLine("Method-7-SortedSquares");
            for (int i = 0; i < arr.Length && (arr[i] > arr[i + 1]); i++)
            {
                Console.WriteLine("Your input array is not in ascending order. Next time please enter in ascending order.");
                Console.ReadLine();
            }
            int[] sortedSquares = SortedSquares(arr);
            Console.WriteLine("Squares of the array in the sorted order is:");
            DisplayArray(sortedSquares);
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("--------------------------------------------------");
            //----------------------------Method-8-ValidPalindrome()------------------------------------------
            Console.WriteLine("Method-8-ValidPalindrome:");
            string str = "xerox";
            Console.WriteLine("THE input string to check for palindrome is \"{0}\" ", str);
            bool val = ValidPalindrome(str);
            Console.Write("\n");
            if (val == false)
            {
                Console.WriteLine("The input string \"{0}\" CANNOT be made PALINDROME", str);
            }
            else if (val == true)
            {
                Console.WriteLine("The input string \"{0}\" can be made PALINDROME ", str);
            }
            Console.WriteLine("--------------------------------------------------");
        }
        //----------------------Main Function Ends----------------------------------------------------
        //input_array_length() function used to calculate the length of the array 
        public static int input_array_length()
        {
            Console.WriteLine("Please enter the length of array");
            string arrlen = Console.ReadLine();
            int arrayLength = int.Parse(arrlen);
            return arrayLength;
        }
        /*input_array() function is used to read the single dimensional array from console and 
         *display that single dimensional array
         */
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
        /* Input2DArray() function is used to read the input from console and display that 2-dimentional array */
        public static int[,] Input2DArray()
        {
            Console.WriteLine("Enter No.of rows for 2D Array: ");
            string row = Console.ReadLine();
            int no_of_rows = int.Parse(row);
            Console.WriteLine("Enter No.of columns for 2D Array: ");
            string column = Console.ReadLine();
            int no_of_columns = int.Parse(column);
            int[,] array_input = new int[no_of_rows, no_of_columns];

            Console.WriteLine("\nRead 2D Array abd display the input matrix:");
            Console.WriteLine("------------------------------------");
            //Read the input array and store the elements in the array
            for (int i = 0; i < no_of_rows; i++)
            {
                for (int j = 0; j < no_of_columns; j++)
                {
                    Console.WriteLine("Write Array element - [{0},{1}]", i, j);
                    array_input[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe input Array is:");
            for (int i = 0; i < no_of_rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < no_of_columns; j++)
                {
                    Console.Write("{0}\t", array_input[i, j]);
                }
            }
            Console.WriteLine("\n");
            return array_input;
        }
        /* DisplayArray() function is used display the 1-dimentional array on the console*/
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        /* Display2DArray() function is used display the 2-dimentional array on the console*/
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
        //-----------------------------------Method-1-SearchInsert()------------------------------
        /* Given an array of distinct sorted integers sorted in ascending order and target value is is also provided.
         * Return the index of the target if it is found in the array. In case if not able to find the target, 
         * it will return the index where the target could be inserted so as the array still remains sorted.
         *
         *  Method completed by Munja Solanke 
         *  
         *  Self Reflection: Learned array manipulation and array sorting which gives the best time complexity. Developed the algorithm design methods.
         */
        public static int SearchInsert(int[] arr1, int key)
        {
            int[] inputArray = arr1;
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                //this mid is used to calculate the mid value of the range from min to max
                int mid = (min + max) / 2;
                //this condition checks the target value is equal to mid value or not, if it is equal, return the mid value
                if (key == inputArray[mid])
                {
                    return mid;
                }//if not above condition, then return the max = mid-1
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }//otherwise you need to return min value as mid+1
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
        //-----------------------------------Method-2-Intersect()------------------------------
        /* Given  two arrays and need to find the intersection of the two arrays.
         * Each element in the result should appear as many times as it shows in both arrays
         */
        
        /* Finished by Yusi Wei
        */
        //Self-reflection: Dictionary is a good way to solve this question because the time complexity is less than that of nest loop. 
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            //Create a list to store the results
            List<int> intersec = new List<int>();
            try
            {
                //Create a dictionary for num1
                Dictionary<int, int> mydictionary1 = new Dictionary<int, int>();
                //iterate through the array num1
                foreach (int num in nums1)
                {
                    if (!mydictionary1.ContainsKey(num))
                    {
                        mydictionary1.Add(num, 1);
                    }
                    else
                    {
                        mydictionary1[num]++;
                    }
                }
                //Compare the elements in num1 and num2 and add the same elements into the list
                foreach (int num in nums2)
                {
                    if (mydictionary1.ContainsKey(num) && mydictionary1[num] > 0)
                    {
                        intersec.Add(num);
                        mydictionary1[num]--;
                    }
                }
                return intersec.ToArray();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");
            }
            return new int[] { };
        }
        //-----------------------------------Method-3-LargestUniqueNumber()------------------------------
        /* Given an array of integers A, return the largest integer that only occurs once.
         * If no integer occurs once, return -1.
         */
        
        /* Finished by Yusi Wei
        */
        //Self-reflection: A counter is needed to record how many times the number is repeated. And return the largest integer that count is 1.
        //                 While using the while loop, I had to consider when i=0                 
        public static int LargestUniqueNumber(int[] A)
        {
            try
            {
                //This variable is used to return the result
                int t = 0;
                //This variable is used to record how many times the number is repeated.
                int count = 1;
                Array.Sort(A);
                int i = A.Length - 1;
                while (i >= 1 && i < A.Length)
                {
                    if (A[i] == A[i - 1])
                    {
                        count++;
                        i--;
                    }
                    //Restart the counter
                    else if (count > 1)
                    {
                        count = 1;
                        i--;
                    }
                    else
                    {
                        t = A[i];
                        break;
                    }
                }
                if (i == 0 && count == 1)
                {
                    t = A[i];
                }
                if (i == 0 && count > 1)
                {
                    t = -1;
                }
                return t;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing LargestUniqueNumber()");
            }
            return new int { };
        }
        //----------------------Method-4-CalculateTime()--------------------------------------------------
        /* Given a string keyboard of length 26 indicating the layout of the keyboard (indexed from 0 to 25), 
         * initially your finger is at index 0. To type a character, you have to move your finger to the index 
         * of the desired character. The time taken to move your finger from index i to index j is |i - j|.
         * You have to type a string word. below function calculates how much time it takes to type it with one finger.
         */
        
        /* Finished by Yusi Wei
        */
        //Self-reflection: I do not know how to use dictionary to solve this problem, so I solved the problem mathematically.
        public static int CalculateTime(string keyboard, string word)
        {
            int r = 0;
            if ((keyboard[0] - word[0]) > 0)
                r = 26 - (keyboard[0] - word[0]);
            else
                r = Math.Abs(keyboard[0] - word[0]);
            //Console.WriteLine(r);
            try
            {
                int a = 0;
                int b = 0;
                for (int j = 1; j < word.Length; j++)
                {
                    if ((keyboard[0] - word[j]) > 0 && (keyboard[0] - word[j - 1]) > 0)
                    {
                        a = 26 - (keyboard[0] - word[j]);
                        //Console.Write(a);
                        b = 26 - (keyboard[0] - word[j - 1]);
                        // Console.WriteLine(b);
                    }
                    else if ((keyboard[0] - word[j]) < 0 && (keyboard[0] - word[j - 1]) < 0)
                    {
                        a = Math.Abs(keyboard[0] - word[j]);
                        // Console.Write(a);
                        b = Math.Abs(keyboard[0] - word[j - 1]);
                        //Console.WriteLine(b);
                    }
                    else if ((keyboard[0] - word[j]) > 0 && (keyboard[0] - word[j - 1]) < 0)
                    {
                        a = 26 - (keyboard[0] - word[j]);
                        b = Math.Abs(keyboard[0] - word[j - 1]);
                    }
                    else if ((keyboard[0] - word[j]) < 0 && (keyboard[0] - word[j - 1]) > 0)
                    {
                        a = Math.Abs(keyboard[0] - word[j]);
                        b = 26 - (keyboard[0] - word[j - 1]);
                    }
                    r = r + Math.Abs(a - b);
                }
                return r;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing CalculateTime()");
            }
            return 0;
        }
        //----------------------Method-5-FlipAndInvertImage()---------------------------------------------
        /* Given a binary matrix A, we want to flip the image horizontally, then invert it, 
         * and return the resulting image
         */
        
        /*Finished by Yusi Wei
        */
        //Self-reflection: Fist step is to flip an image horizontally, and second step is to invert an image 
        public static int[,] FlipAndInvertImage(int[,] A)
        {
            int row = A.GetLength(0);
            int col = A.GetLength(1);
            int b, c, d;
            int[,] B = new int[row, col];
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                       //Flip the array
                        b = A[i, j];
                        c = A[i, col - j - 1];
                        d = b;
                        b = 0;
                        b = c;
                        c = d;
                        B[i, j] = b;
                       //Invert the array
                        if (B[i, j] == 0)
                            B[i, j] = 1;
                        else if (B[i, j] == 1)
                            B[i, j] = 0;
                    }
                }
                return B;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing FlipAndInvertImage()");
            }
            return new int[,] { };
        }
        //----------------------Method-6-MinMeetingRooms()---------------------------------------------
        /* Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei),
         * Below function finds the minimum number of conference rooms required.
         *
         *  Method completed by Nivedita Mangal
         */
        public static int minMeetingRooms(int[,] intervals)
    {

        int[] beg = new int[intervals.Length];
        int[] end = new int[intervals.Length];
        int nom = 0;
        try
        {
            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                beg[i] = intervals[i, 0];
                end[i] = intervals[i, 1];
            }
            Array.Sort(beg);
            Array.Sort(end);

            int k = 0, j = 0;
            while (k < intervals.Length)
            {
                if (beg[k] < end[j])
                    k++;
                else if (beg[k] > end[j])
                    j++;
                else
                {
                    k++;
                    j++;
                }
                nom = Math.Max(nom, k - j);
            }
            return nom;
        }
        catch
        {
            Console.WriteLine("Error in generating number of meeting rooms");
        }
        return 0;
    }
        //----------------------------Method-7-SortedSquares()------------------------------------------
        /* Given an array of integers sorted in non-decreasing order and return an array of the squares of each number 
         * in sorted non-decreasing order. 
         * 
         *  Method completed by Munja Solanke 
         *  
         *  Self Reflection: Learned to sort the array input and understood how to take the input from the console and use it in the program
         */
         
        public static int[] SortedSquares(int[] A)
        {
            try
            {
                //Initializing the array to store squares of the array elements 
                int[] SquareArr = new int[A.Length];
                //this for loop is used to calculate the square of the number
                for (int i = 0; i < A.Length; i++)
                {
                    int SqrNum = A[i] * A[i];
                    SquareArr[i] = (SqrNum);
                }
                //This will sort the squared array in ascending order
                Array.Sort(SquareArr);
                //Console.WriteLine("Your Squared array is:" + SquareArr);
                return SquareArr;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing SortedSquares()");
            }
            return new int[] { };
        }
        //----------------------------Method-8-ValidPalindrome()------------------------------------------
        /* A string is said to be a palindrome if the string read from left to right is equal to the string read from right to left.
         * You are given a non empty string. You need to check whether the given string can be made palindrome or not considering that 
         * you can delete maximum one character 
         *
         *  Method completed by Munja Solanke
         *  
         *  Self Reflection: Learned the logic for Palindrome function and how to pass the string from one function to another. 
         *  Learned to use minimum Loops to maintain the time complexity and space complexity. 
         */

        //This function checks whether the given input is palindrome or not.
        public static bool PalindromeValidityCheck(string s)
        {
            try
            {
                int a = 0;
                int b = s.Length - 1;
                //This loop checks the string input from both ends like starting end and ending end
                while (true)
                {
                    if (a > b)
                    {
                        return true;
                    }
                    char m = s[a];
                    char n = s[b];
                    //This condition checks whether two strings created in above are equal or not
                    if (char.ToLower(m) != char.ToLower(n))
                    {
                        return false;
                    }
                    a++;
                    b--;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing ValidPalindrome()");
            }
            return false;
        }
        public static bool ValidPalindrome(string s)
        {
            int b = s.Length - 1;
            int len = 0;
            //this will check the original string (before removing any character) palindrome or not 
            bool result = PalindromeValidityCheck(s);
            if (result == true)
            {
                return result;
            }
            else
            {
                //this loop will check the string palindrome or not
                while (len <= b)
                {
                    // create a string with the i-th character removed
                    var x = s.Remove(len++, 1);
                    // and test if it is a palindrome after removing i-th character.
                    bool result2 = PalindromeValidityCheck(x);
                    //if the result after deleting one character is true that means if it is possible 
                    //to make the string palindrome, then return result true.
                    if (result2 == true)
                    {
                        return result2;
                    }
                }
            }
            return false;
        }
    }
}
