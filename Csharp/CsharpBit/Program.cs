using System;

namespace CsharpBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 123;
            int key = 401;

            int a = id ^ key;
            int b = a ^ key;

            Console.WriteLine(a);
            Console.WriteLine(b);

            // 비트 연산
        
        }
    }
}
