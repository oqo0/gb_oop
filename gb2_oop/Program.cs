using System;

namespace gb2_oop
{
    class Oop
    {
        static void Main()
        {
            var a = new ACoder();
            var b = new BCoder();

            a._str = "ПростоТекст";
            b._str = "ПростоТекст";
            
            Console.WriteLine("decoded:");
            Console.WriteLine(a._str);
            Console.WriteLine(b._str);

            a.Encode();
            b.Encode();
            
            Console.WriteLine("\nencoded:");
            Console.WriteLine(a._str);
            Console.WriteLine(b._str);
            
            a.Decode();
            b.Decode();
            
            Console.WriteLine("\ndecoded:");
            Console.WriteLine(a._str);
            Console.WriteLine(b._str);
            
            Console.Read();
        }
    }
}