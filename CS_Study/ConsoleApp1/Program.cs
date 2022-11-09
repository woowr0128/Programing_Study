using System;

namespace ConsoleApp1
{
    class CS_Study
    {
        static void Main(string[] args)
        {
            //데이터 + 로직
            // 체력 0
            //byte(1바이트 0~255), short(2바이트~ -3만~3만), int (4바이트 -21억~21억), long(8바이트)
            //sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트)
            int hp;
            short level = 100;  // 레벨같은 한정적인 부분은 short등을 쓰지만 90%는 int사용. 최적화용
            long Id; // 아이템 아이디같은 정보는 long으로 관리해야 나중가서 편함.

            //소스트리 ClonText확인용 주석 추가

            Console.WriteLine("Hello World!");
           
        }
    }
}
