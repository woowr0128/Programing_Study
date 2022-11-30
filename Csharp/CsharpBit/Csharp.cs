using System;

namespace CsharpBit
{
    class Csharp
    {
        //메소드 함수
        //static void HelloWorld()
        //{
        //    Console.WriteLine("HelloWorld");
        //}
        //-------------------------------------------------------------------

        //덧셈함수(예시)
        //static int Add(int a, int b)
        //{
        //    int result = a + b;
        //    return result;
        //}
        //static void Main(string[] args)
        //{
        //    //HelloWorld();
        //    //-----------------------------------------------------------------
        //    //4, 5 = 9
        //    int result = Csharp.Add(4, 5);
        //    Console.WriteLine(result);
        //}
            
        //-------------------------------------------------------------------------

        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Main(string[] args)
        {
            int a = 0;
            Csharp.AddOne(ref a);

            Console.WriteLine(a);

            int b = Csharp.AddOne2(a);
            a = b;
            Console.WriteLine(a);
        }
    }
}
