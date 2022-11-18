using System;

namespace CsharpBit
{
    class CsharpScwich
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine(" 당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine(" 당신의 선택은 바위입니다 ");
                    break;
                case 2:
                    Console.WriteLine(" 당신의 선택은 보입니다");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine(" 컴퓨터의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine(" 컴퓨터의 선택은 바위입니다 ");
                    break;
                case 2:
                    Console.WriteLine(" 컴퓨터의 선택은 보입니다");
                    break;
            }

            //승리 무승부 패배
        }
    }
}
