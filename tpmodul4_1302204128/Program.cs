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
