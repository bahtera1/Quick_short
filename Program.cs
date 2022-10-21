

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
                while (i < j)
                {
                    //search for an element greater than pivot
                    while ((arr[i] <= pivot) && (i <= high))
                    {
                        i++;
                        cmp_count++;
                    }
                    cmp_count++;

                    //search fon an element less than or equal to pivot
                    while ((arr[j] > pivot) && (j >= low))
                    {
                        j--;
                        cmp_count++;
                    }
                    cmp_count++;

                    if (i < j) //if the greater element is on the left of the elemnt
                    {
                        //swap the elemnt at index i whit the element at index j
                        swap(i, j);
                        mov_count++;
                    }
                }
                //j now contains index ot the element in the sorted list

                if (low < j)
                {
                    //move the pivot to its correct position in the list
                    swap(low, j);
                    mov_count--;
                }
                //sort the list in the left of pivot using quick sort
                q_sort(low, j - 1);

                //sort the list on the right of pivot using quick sort
                q_sort(j + 1, high);
            }

            void display()
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Sorted Array Element");
                Console.WriteLine("--------------");

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr[j]);
                }
                Console.WriteLine("\nNumber Of comparisons: " + cmp_count);
                Console.WriteLine("\nNumber of data movements: " + mov_count);

            }















        }










    }
}