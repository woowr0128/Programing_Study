using System;

namespace CsharpBit
{
    class Csharpfor
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine("Hellow World");
            //}
            ////for (초기화식; 조건식; 반복식)

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hellow World");
            //}

            int num = 97;// 1, 97로만 나뉘는 숫자
            bool isPrime = true;

            for (int i = 2; i< num; i++)
            {
                if ((num % i)==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("소수입니다");
            }
            else
            {
                Console.WriteLine("소수가 아닙니다.");
            }

            for (int i=1; i <= 100; i++)
            {
                if((i % 3) == 0)
                {
                    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
                }
            }
        }
    }
}
