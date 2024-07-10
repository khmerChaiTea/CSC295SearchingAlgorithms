namespace SearchingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            Console.WriteLine(arr1Result);

            int[] arr2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr2Result = BinarySearch(arr2,4);
            Console.WriteLine(arr2Result);

            int[] arr3 = { 7, 6, 9, 3, 5, 8, 0, 10, 1, 4};
            int arr3Result = LinearMinSearch(arr3);
            Console.WriteLine(arr3Result);
        }

        public static int LinearSearch(int[] arrToSearch, int target)
        {
            // int = 0 - initializing our loop conditional - in this case to 0
            // next we evaluate of the value mmets the condition
            // after each loop we run the update loop
            // Big O - O(n) worse case
            // Big Omega - O(1) best case
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }

        public static int BinarySearch(int[] arrToSearch, int target) 
        {
            // establish upper and lower bound
            int lower = 0;
            int upper = arrToSearch.Length - 1;

            while (lower <= upper)
            {
                // calculate the middle index
                int mid = (lower + upper) / 2;

                // if the middle element is the target, return its index
                if (arrToSearch[mid] == target)
                    return mid;
                // if the target is less than the middle element, adjust the upper bound
                else if (target < arrToSearch[mid])
                {
                    upper = mid - 1;
                }
                // if the target is greater than the middle element, adjust the lower bound (used else in this case)
                else
                {
                    lower = mid + 1;
                }
            }

            return -1;
        }

        public static int LinearMinSearch(int[] arrToSearch)
        {
            // Initialize the variable to store the lowest value found
            int lowest = arrToSearch[0];

            // Iterate through the array starting from the first element
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                // Compare each element with the current lowest value
                // If a smaller element is found, update the lowest variable
                if (arrToSearch[i] < lowest)
                {
                    lowest = arrToSearch[i];
                }
            }

            // Return the lowest value found in the array
            return lowest;
        }

    }
}
