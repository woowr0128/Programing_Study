using System;

namespace CsharpBit
{
    class RSPGame
    {
        static void Main(string[] args)
        {
            // 0 : 가위, 1 : 바위 , 2 : 보
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

            if (choice == 0) // 사용자의 패가 가위일때.
            {
                if(aiChoice == 0) // AI가 가위라면
                {
                    Console.WriteLine("무승부입니다");
                }
                else if (aiChoice == 1) // AI 가 바위라면
                {
                    Console.WriteLine(" 패배입니다.");
                }
                else if (aiChoice == 2) // AI 가 보라면
                {
                    Console.WriteLine(" 승리입니다.");
                }
            }
            if (choice == 1) // 사용자의 패가 바위일때.
            {
                if (aiChoice == 0) 
                {
                    Console.WriteLine(" 승리입니다. ");
                }
                else if (aiChoice == 1) 
                {
                    Console.WriteLine(" 무승부입니다.");
                }
                else if (aiChoice == 2) 
                {
                    Console.WriteLine(" 패배입니다.");
                }
            }
            if (choice == 2) // 사용자의 패가 보일때.
            {
                if (aiChoice == 0) 
                {
                    Console.WriteLine(" 패배입니다. ");
                }
                else if (aiChoice == 1) 
                {
                    Console.WriteLine(" 승리입니다.");
                }
                else if (aiChoice == 2) 
                {
                    Console.WriteLine(" 무승부입니다.");
                }
            }
        }
    }

    //2022년 11월 24일 카타르 월드컵 보는중...
    // 하루만 ..ㅎㅎ
}
