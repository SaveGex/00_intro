namespace _00_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rand = new Random();

            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                arr[i] = rand.Next(1, 9);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            
            for(int i = 0; i<arr.GetUpperBound(0); ++i)
            {
                for (int j=0; j<arr.GetUpperBound(0); j++)
                {
                    if (arr[i] < arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
