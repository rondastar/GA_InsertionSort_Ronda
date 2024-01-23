namespace GA_InsertionSort_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test insertion sort with int array
            int[] intArray = { 91, 72, 23, 14, 55, 96, 27, 88, 19, 10, 71, 42, 33, 64, 5 };
            PrintArray(intArray);
            InsertionSort(intArray);
            PrintArray(intArray);

            // test insertion sort with char array
            char[] charArray = { 'z', 'b', 'f', 'y', 'd', 'c', 'k', 'w', 'r' };
            PrintArray(charArray); 
            InsertionSort(charArray);
            PrintArray(charArray);

            // test insertion sort with string array
            string[] stringArray = { "This", "is", "a", "grammatical", "sentence,", "but", "it", "won't", "be." };
            PrintArray(stringArray);
            InsertionSort(stringArray); 
            PrintArray(stringArray);
        }

        static void InsertionSort<T>(T[] array)
        {
            // Get the length of the input array
            int arrayLength = array.Length;

            // Iterate through the array starting from the second element
            for (int i = 1; i < arrayLength; i++)
            {
                // Store the current element's value
                T currentValue = array[i];

                // Initialize the position for comparing the current element
                int previousIndex = i - 1;

                // Shift elements of the sorted part that are greater than currentValue
                while (previousIndex >= 0 && Comparer<T>.Default.Compare(array[previousIndex], currentValue) > 0)
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex--;
                } // while loop

                // Place the current element at its correct position
                array[previousIndex + 1] = currentValue;
            } // for loop
        } // InsertionSort

        static void PrintArray<T>(T[] array)
        {
            Console.Write("Array: ");
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
