namespace afterquiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 arraydaki element sayini goster

            //int[] array =    { 0,9, 13, 234, 13, 45, 9, 13,0,0,13 };
            //int[] Newarray = {0   ,0,  0,   0,  0 ,0 ,0,0,0,0,0};
            //for (int i = 0; i < array.Length; i++)
            //{

            //    int t = array[i];
            //    int tcount = 0;
            //    if (Newarray[i] == 0)
            //    {
            //        for (int j = 0; j < array.Length; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                Newarray[j] = 1;

            //                tcount += 1;
            //            }
            //        }
            //        if (tcount > 1)
            //        {
            //            Console.WriteLine(t + " ededinden " + tcount + "eded var");
            //        }
            //    }

            //}



            //Task 2 consol write read
            Console.WriteLine("arrayin olcusunu daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            Console.WriteLine("yeni eded daxil edeceksense 'y' yaz eks halda her hansisa bir sey yaz");
            string yes = Console.ReadLine();
            if (yes == "y")
            {
                Console.WriteLine("ededleri daxil edin:");
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] =Convert.ToInt32(Console.ReadLine());
                }
            }
           

        }
    }
}

