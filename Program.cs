namespace SearchingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            Console.WriteLine(arr1Result);
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
    }
}
