using System;

namespace tp4
{
    class program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser("razzaq");
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo User " + inputUser);
        }
    }
}
using System;

namespace tp4
{
    class program
    {
        public static void Main(string[] args)
        {
            DataGeneric<int> nim = new DataGeneric<int>(1302204128);
            nim.Printdata();
        }
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T nim)
        {
            data = nim;
        }
        public void Printdata()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
}