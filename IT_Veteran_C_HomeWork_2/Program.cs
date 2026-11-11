namespace IT_Veteran_C_HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 ------------------------------------------------------------
            int[] arr1 = { 15, 65, 79, 8, 89, -54, 258, -23 };
            PrintSummMultiplElementArr(arr1);
            var result = arrSummMultiplElement2(arr1);
            Console.WriteLine("Summa  element  of  arr = " + result.a);
            Console.WriteLine("Product elements of arr = " + result.b);
            Console.WriteLine();
            // task 2 ------------------------------------------------------------
            printArray(arr1);
            minMaxArray(arr1);
            printArray(arr1);

            //task 3 --------------------------------------------------------
            Console.WriteLine(firstElevent(arr1,false));



        }
        // 1 ----------------
        /// <summary>
        /// друкує сумму і добуток елеметів в масиві
        /// </summary>
        /// <param name="arr">масив</param>
        static void PrintSummMultiplElementArr(int[] arr)
        {
            long sum = 0;
            long mult = 1;
            foreach (var item in arr)
            {
                sum += item;
                mult *= item;
            }
            Console.WriteLine($"The  sum  of  the array  elements is equal to  {sum}");
            Console.WriteLine($"The product of the array elements is equal to  {mult}");
        }
        static (long a, long b) arrSummMultiplElement2(int[] arr)
        {
            long sum = 0;
            long mult = 1;
            foreach (var item in arr)
            {
                sum += item;
                mult *= item;
            }
            return (sum, mult);
        }
        static void minMaxArray(int[] arr)
        {
            int min_ = arr[0];
            int max_ = arr[0];
            int indexMin = 0;
            int indexMax = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min_)
                {
                    min_ = arr[i];
                    indexMin = i;
                }
                if (arr[i] > max_)
                {
                    max_ = arr[i];
                    indexMax = i;
                }
            }
            Console.WriteLine($"Max element = {max_} index old {indexMax}");
            Console.WriteLine($"Min element = {min_} index old {indexMin}");
            arr[indexMax] = min_;
            arr[indexMin] = max_;

        }
        static void Swap_(ref int a, ref int b)
        {
            int tmp = a;
            b = a;
            a = tmp;
        }
        static void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }

        static int firstElevent(int[] arr, bool flag = true)
        {
            if (flag)
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 0)
                        return arr[i];
                    else 
                        continue;
                }

            else
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                        return arr[i];
                    else 
                        continue;
                }
            if (flag)
                Console.WriteLine("not positive elevent ");
            else
                Console.WriteLine("Not negative elevent");
            return 0;
        }



    }
}
