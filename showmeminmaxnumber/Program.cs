using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5개의 수를 입력 받아 가장 작은 수와 가장 큰 수를 출력하는 프로그램 작성
            int[] number = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요 >> ");
                number[i] = int.Parse(Console.ReadLine());
            }

            int max = number[0];
            int min = number[0];

            for(int i = 1; i < 5; i++)
            {
                if(max < number[i])
                {
                    max = number[i];
                }

                if(min > number[i])
                {
                    min = number[i];
                }
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
