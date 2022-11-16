using System;

namespace CsharpBit
{
    class CsharpScwich
    {
        static void Main(string[] args)
        {
            int choice = 0;
            switch(choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("보입니다.");
                    break;
                case 2:
                    Console.WriteLine("바위입니다.");
                    break;
                case 3:
                    Console.WriteLine("치트입니다");
                    break;
            }
        }
    }
}
