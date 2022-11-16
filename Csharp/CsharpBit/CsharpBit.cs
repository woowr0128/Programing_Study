using System;

namespace CsharpBit
{
    class CsharpBit
    {
        static void Main(string[] args)
        {
            //int id = 123;
            //int key = 401;

            //int a = id ^ key;
            //int b = a ^ key;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // 비트 연산
            //--------------------------------------------------------

            int choice = 0;

            if (choice == 0)
                Console.WriteLine("가위입니다");
            else
            {
                if (choice == 1)
                    Console.WriteLine("바위입니다");
                else
                {
                    if (choice == 2)
                        Console.WriteLine("보입니다.");
                    else
                    {
                        Console.WriteLine("치트키입니다");
                    }
                }
            }
        
        }
    }
}
