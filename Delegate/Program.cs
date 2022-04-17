using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //델리게이트 (대리자) 정의
    delegate int Dele(int a, int b);
    class Program
    {
        // 델리게이트 인스턴스 생성
        static void Main(string[] args)
        {
            //델리게이트 인스턴스 생성
            Dele plus = new Dele(Plus);
            Dele minus = new Dele(Minus);
            Dele multy = new Dele(Multy);

            //델리게이트를 매개변수로 하는 메서드를 호출
            Calc(1, 2, plus);
            Calc(4, 3, minus);
            Calc(5, 6, multy);

            Console.ReadLine();
        }

        // 델리게이트를 매개변수로 받는 메서드
        private static void Calc(int a, int b, Dele dele)
        {
            Console.WriteLine(dele(a, b));
        }

        //델리게이트로 다른 메서드에 넘겨줄 메서드
        private static int Multy(int a, int b)
        {
            return a * b;
        }

        private static int Minus(int a, int b)
        {
            return a - b;
        }

        private static int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
