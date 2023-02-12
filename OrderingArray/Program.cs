using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your array's length: ");
            var arrayLength = int.Parse(Console.ReadLine());

            var array = new int[arrayLength];
     
            for (int arrayElement = 0; arrayElement < arrayLength; arrayElement++)
            {
                Console.Write("Insert the element number " + (arrayElement + 1) + ": ");
                array[arrayElement] = int.Parse(Console.ReadLine());
            }

            BubbleSort(arrayLength, array);

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(i == 0 ? "Ordered Array: [" : "");
                Console.Write(i != arrayLength - 1 ? $"{array[i]}, " : $"{array[i]}]");
            }

            Console.ReadKey();
        }

        private static void BubbleSort(int arrayLength, int[] array)
        {
            int switchNumber;
            for (int fixedPosition = 0; fixedPosition < arrayLength; fixedPosition++)
                for (int positionToCompare = fixedPosition + 1; positionToCompare < arrayLength; positionToCompare++)
                    if (array[positionToCompare] < array[fixedPosition])
                    {
                        switchNumber = array[fixedPosition];
                        array[fixedPosition] = array[positionToCompare];
                        array[positionToCompare] = switchNumber;
                    }
        }
    }
}
