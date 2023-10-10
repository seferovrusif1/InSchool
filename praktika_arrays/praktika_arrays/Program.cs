namespace praktika_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -20, 25, -6, 6, 10 };

            //1. elementleri for loopda capa ver

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //2. menfilerin sayini tap

            //int negative = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]<0)
            //    {
            //        negative++;     
            //    }
            //}
            //Console.WriteLine(negative);


            //3. ededi orta tap

            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}

            //Console.WriteLine(sum/nums.Length);

            //4. arraydaki max ve min ededi topla

            //int minarray = nums[0];
            //int maxarray = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //{

            //    if (nums[i] < minarray)
            //    {
            //        minarray= nums[i];
            //    }
            //    if (nums[i] > maxarray)
            //    {
            //        maxarray = nums[i];
            //    }
            //}
            //Console.WriteLine(maxarray+minarray);

        }
    }
}