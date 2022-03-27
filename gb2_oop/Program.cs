using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            Console.WriteLine(ReverceString(String.Empty));
            Console.WriteLine(ReverceString("This is a test"));
            Console.WriteLine(ReverceString("AAppEEaa__^^"));
        }

        public static string ReverceString(string str)
        {
            char[] reversedAray = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                reversedAray[i] = str[str.Length - i - 1];
            }

            return new string(reversedAray);
        }
    }
}