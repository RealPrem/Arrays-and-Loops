using System;

namespace Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 8, 9, 10, 11 };
            string[] Place = { "Home", "Motel", "School", "Factory", "Home", "Motel" };
            string[] names = { "John", "F", "Kennedy" };
            Console.WriteLine(string.Join(" ", FindDuplicate(Place)));
        }
        static void Question1()
        {   // looping  1 to 10
            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine(i);
            }

        }
        static void Question2()
        {
            for(int i = 100; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
        // This method prints the first and last integers in array
        static void PrintFirstAndLast(int[] numbers)
        {
            int First = 0;
            int Last = numbers.Length - 1;
            Console.WriteLine(numbers[First]);
            Console.WriteLine(numbers[Last]);
        }
        static void PrintAllNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i += 1)
            {
                Console.WriteLine(i + " : " + numbers[i]);
            }
        }
        static void PrintAverage(int [] numbers)
        {
            int Total = 0;
            double Average = 0.0;
            
            for (int i = 0; i < numbers.Length; i += 1)
            {
                Total += numbers[i];
            }
            Average = Total / numbers.Length;
            Console.WriteLine(Average);
        }
        static void PrintHighestLowest(int[] numbers)
        {
            Random rd = new Random();
            for (int i = 0; i < numbers.Length; i += 1)
            {
                int RandomNumber = rd.Next(100);
                numbers[i] = RandomNumber;
            }
            int Max = numbers[0];
            int Min = numbers[0];

            for(int i = 0; i < numbers.Length; i += 1)
            {
                if(numbers[i] > Max)
                {
                    Max = numbers[i];
                }
                else if(numbers[1] < Min)
                {
                    Min = numbers[i];
                }
            }
            Console.WriteLine("MAX: " + Max);
            Console.WriteLine("MIN: " + Min);
        }
        static bool IsNameFound(string[] names)
        {
            string FindName = "F";
            string Found = "F";
            for (int i = 0; i < names.Length; i += 1)
            {
                if (names[i] == FindName)
                {
                    Found = "T";
                }
            }
            if (Found == "T")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string[] FindDuplicate(string[] Place)
        {
            int NumOfDuplicates = 0;
            for (int i = 0; i < Place.Length; i += 1)
            {
                for(int y = 0; y < Place.Length; y += 1)
                {
                    if(Place[i] == Place[y] && i != y)
                    {
                        NumOfDuplicates += 1;
                    }
                }
            }
            int Num = 0;
            string[] Duplicates = new string[NumOfDuplicates];
            for (int i = 0; i < Place.Length; i += 1)
            {
                for (int y = 0; y < Place.Length; y += 1)
                {
                    if(Place[i] == Place[y] && i != y)
                    {
                        Duplicates[Num] = Place[i];
                        Num += 1;
                    }
                }
            }
            return Duplicates;
        }
    }
}
