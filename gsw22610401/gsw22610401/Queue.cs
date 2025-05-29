using System;
using System.Diagnostics;
using System.Security.Principal;

namespace gsw22610401
{
    internal class Queue
    {
        static int[] queue = new int[11];
        static int head = -1;
        static int tail = -1;

        public static void Main(string[] args)
        {
            Console.WriteLine("스택 저장 프로그램");

            while (true)
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
                            Console.WriteLine("큐이 가득 차서 저장 불가.");
                        }
                        break;
                    case 2:
                        int temp = Pop();
                        if (temp == -2147483648)
                        {
                            Console.WriteLine("큐이 비어있음");
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
            if()
            {
                return false;
            }
            else
            {
                queue[++tail] = num;
                return true;
            }
        }
        static int Pop()
        {
            if (tail == head)
            {
                return -2147483648;
            }
            else
            {
                return queue[head--];
            }
        }
        
    }
}
