using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        private static int MAX_CAPACITY = 0;
        static bool flag = true;

        /// <summary>
        /// Static method to get the maximum capacity of the cache
        /// </summary>
        /// <returns></returns>
        public static int GetMaxCapacity()
        {
            Console.WriteLine("Returning MAX_CAPACITY");
            if (flag)
            {
                MAX_CAPACITY = CustomConsole.ReadInt();
                flag = false;
            }

            return MAX_CAPACITY;
        }
    }
}
