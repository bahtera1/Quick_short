

namespace QuickSort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comprasion
        private int mov_count = 0; //number data movements

        //number elements in array
        private int n;




        void input()
        {
            while (true)
            {
                {
                    Console.Write("Enter the number of elements array : ");
                    string s = Console.ReadLine();
                    n = Int32.Parse(s);
                    if (n <= 20)
                        break;
                    else
                        Console.WriteLine("\nArray can have maximum 20 elements \n");
                }
                Console.WriteLine("\n====================\n");
                Console.WriteLine("Enter Array elemnens");
                Console.WriteLine("\n====================\n");

                //get array elements
                for(int i = 0; i < n; i++)
                {
                    Console.Write("<"+(i+1)+">");
                    string s1 =Console.ReadLine();
                    arr[i] = Int32.Parse(s1);
                }
            }
            
            //swaps the elements at index x with the elemnts at index y
            void swap(int x, int y)
            {
                int temp;

                temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }

            public void q_sort(int low, int high)
            {
                int pivot, i, j;
                if (low > high)
                    return;

                //partition the list into two parts
                //one containing elemnts less that or equal to pivot
                //outher containing elements greater than pivot

                i = low + 1;
                j = high;

                pivot = arr[low];

            }

        }










    }
}