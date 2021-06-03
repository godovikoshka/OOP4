using System;
using System.Threading;

namespace OOP4
{
    public class Lab4
    {
        static Mutex _mutex;

        public static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("mut");
            }
            catch
            {
                _mutex = new Mutex(true, "mut");
                return true;
            }

            return false;
        }

        public static int Main()
        {
            if (!IsSingleInstance())
            {
                Console.WriteLine("More than one instance");
                return -1;
            }
            else
            {
                Console.WriteLine("One instance");
                return 0;
            }
        }
    }
}