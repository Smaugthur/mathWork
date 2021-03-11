using System;

namespace MATHMETHODS
{
    class basics
    {
        public static void factorization(long num)
        {
            long numTemp = num;
            long primeFactor= 0;
            long counter = 2;
            Console.Write($"{numTemp,-5}");
            while(numTemp!=1)
            {
                if(numTemp%counter==0)
                {
                    numTemp /= counter;
                    primeFactor = counter;
                    Console.WriteLine($"|{counter,-5}|");
                    Console.Write($"{numTemp,-5}");
                }
                else
                    counter ++;
            }
            if (numTemp>counter)
            {
                primeFactor = numTemp;
            }
        }
        public static void mcm(int[] array)
        {
            int[] numList = array; 
            int lcm = 1;
            int divisor = 2;
            int endLoop = 0;
            bool isDivisor = false;
            foreach(int i in numList)
            {
                Console.Write($"{i,-3}");
            }

            // While not all the numbers are iqual to 1 still calculating.
            while(endLoop != numList.Length)
            {   
                endLoop = 0;
                // Loop that cycle through each element of the list and divide it if possible.
                for(int i=0; i<numList.Length; i++)
                {
                    if(numList[i]%divisor == 0)
                    {
                        numList[i] /= divisor;
                        isDivisor = true;
                    }
                    // Increments <endLoop> if the number's value equals to1.
                    else if(numList[i]==1)
                        endLoop++;
                }
                // Check to verify if the divisor have to change or add it to the lcm.
                if(isDivisor)
                {
                    lcm*=divisor;
                    isDivisor=false;
                    Console.WriteLine($"|{divisor,-5}");
                    foreach(int i in numList)
                    {
                        Console.Write($"{i,-3}");
                    }
                }
                else
                    divisor++;
            }
            Console.WriteLine(lcm);
        }
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }
        public static int findGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++){
                result = gcd(arr[i], result);

                if(result == 1)
                {
                    return 1;
                }
            }
            return result;
        }
    }
}