using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPratice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 C# 기본
            //int base = 0;
            var abc = 3;
            // var var = 3;

            //한줄 주석
            /*
             * 여러줄 주석
             * 
             */

            /*** XML 주석 ***/

            // #1 출력
            Console.WriteLine("Hello World");
            Console.Write("줄바꿈 싫어");

            // #1 기본 자료형
            Console.WriteLine(52 + 4 - 1);
            //사칙연산자 = 산술 연산 = Artimetic Operator
            // + - * / %

            // 실수 (Real Number)
            Console.WriteLine(52.0);

            //문자
            Console.WriteLine('A');
            Console.WriteLine('가');

            //문자열(string)
            Console.WriteLine("Hello World");
            //Escape Character
            Console.WriteLine("미\n\\림\t마\"고");

            //문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");
            
            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]);    // "0" 출력
            //Console.WriteLine("Hello World"[100]);  // 예외 발생
            //Console.WriteLine("Hello World"[-3]);   // 예외 발생

            // 주의
            Console.WriteLine('가' + '힣');
            // 문자열 연결 연산자X, 덧셈 연산자임

            // 논리(Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);

            // 비교 연산자 (Comparison operator)
            // == != > < >= <=

            //논리
            // && || !   and or not
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
        }
    }
}

