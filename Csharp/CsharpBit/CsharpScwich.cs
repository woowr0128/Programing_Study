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
            // 조건문 관련 주석 추가.
            // 가위바위보 게임 제작.

            // 보는 주먹을 이긴다.
            // 주먹은 가위를 이긴다.
            // 가위는 보를 이긴다.
            // A,B중에 승자는 누구인가?
        }
    }
}
