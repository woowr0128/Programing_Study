using System;

namespace CsharpStudy
{
    class OverLoding
    {
        //함수 이름의 재사용
        static int Add(int a, int b)
        {
            return a + b;
        }
        static float Add(float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int ret = OverLoding.Add(2, 3);
            float ret2 = OverLoding.Add(2.0f, 3.0f);
                
        }
    }
}
