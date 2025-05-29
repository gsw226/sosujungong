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
        static int top = -1;

        public static void Main(string[] args)
        {
            Console.WriteLine("스택 저장 프로그램");
            
            while(true)
            {
                Console.WriteLine("동작 입력: (1번 push, 2번 pop, 3번 종료)");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("저장할 수 입력");
                        int pNum = int.Parse(Console.ReadLine());
                        if (Push(pNum))
                        {
                            Console.WriteLine("저장 완료");
                        }
                        else
                        {
                            Console.WriteLine("스택이 가득 차서 저장 불가.");
                        }
                        break;
                    case 2:
                        int temp = Pop();
                        if(temp == -2147483648)
                        {
                            Console.WriteLine("스택이 비어있음");    
                        }
                        else
                        {
                            Console.WriteLine(temp);
                        }
                        break;
                    case 3:
                        return;
                }
            }
        }
        static bool Push(int num)
        {
            if (top >= 9)
            {
                return false;
            }
            else
            {
                stk[++top] = num;
                return true;
            }
        }
        static int Pop()
        {
            if(top < 0)
            {
                return -2147483648;
            }
            else
            {
                return stk[top--];
            }
        }
    }
}
