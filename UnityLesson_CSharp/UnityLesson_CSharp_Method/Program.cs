
using System;

namespace UnityLesson_CSharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloworld();
            PrintSomething("asfq"); // 함수 호출에서 소괄호 안 내용은 매개변수(parameter)라고 한다.
            bool tmpIsFineshed = false;
            tmpIsFineshed = PrintSomethingAndReturnIsFinished("asgasgasg");
            Console.WriteLine(tmpIsFineshed);
        }

        // 인자X, 반환X
        static void PrintHelloworld()
        {
            Console.WriteLine("Hello World!");
        }
        // 인자0 , 반환X
        static void PrintSomething(string something) // 함수 정의에서 소괄호 안 내용은 인자(Argument)라고 한다.

        {
            PrintHelloworld();
        }
        static void PrintSomethingAndReturnIsFinished();

        // 인자O , 반환0


        /*반환형 함수이름(인자자료형 인자이름, 인자자료형 인자이름 ..)
        {

             함수 연산 내용

             return 반환할 내용
        }*/
}
}







