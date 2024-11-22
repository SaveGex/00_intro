namespace _00_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row1, row2;
            int[,] arr = new int[5, 10];
            Random rand = new Random();

            //indexs
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i < arr.GetLength(1); i++)
            {
                Console.Write(i.ToString() + ' ');
            }
            Console.ResetColor();
            Console.WriteLine();

            //filling a two dimmensional array
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rand.Next(1, 9);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Which rows you want to swap: ");
            do
            {
                Console.Write("Row(1): ");
                row1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row(2): ");
                row2 = Convert.ToInt32(Console.ReadLine());
            } while (!(row1 <= arr.GetUpperBound(0) || row1 >= arr.GetUpperBound(0)) ||
                     !(row2 <= arr.GetUpperBound(0) || row2 >= arr.GetUpperBound(0)));


            //here could pretty good looks some func with recursion. But idk how to create it xD
            for(int i = 0;i < arr.GetLength(0); ++i) 
            {
                if (i == row1)
                {


                    for (int j = 0; j < arr.GetLength(0); ++j)
                    {
                        if (j == row2)
                        {


                            for (int k = 0; k < arr.GetLength(1); ++k)
                            {
                                (arr[i, k], arr[j, k]) = (arr[j, k], arr[i, k]);
                            }
                        }
                    }
                }
            }
            //or anything func... 
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    if (i == row1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    if (i == row2)
                        Console.ForegroundColor = ConsoleColor.Green;
                    if (i != row1 && i != row2)
                        Console.ResetColor();

                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
