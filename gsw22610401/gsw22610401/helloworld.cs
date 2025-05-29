using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gsw22610401
{
    internal class helloworld
    {
        static int[] stk = new int[11];
        int top = -1;

        public static void Main(string[] args)
        {
            Console.WriteLine("스택 저장 프로그램");
            
            while(true)
            {
                Console.WriteLine("동작 입력: (1번 push, 2번 pop, 3번 종료)");
                int num = Console.Read();

                switch (num)
                {
                    case 1:
                        Console.WriteLine("저장할 수 입력");
                        int pNum = Console.ReadLine();
                        push(pNum);
                        break;

                    case 2:
                        Console.WriteLine(pop());
                        break;

                    case 3:
                        break;
                }

                //foreach(int a in stk)
                //{
                //    Console.WriteLine(a);
                //}
            }
        }
    }





}
