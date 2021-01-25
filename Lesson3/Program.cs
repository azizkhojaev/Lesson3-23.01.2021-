using System;

namespace Lesson3
{
    class Homework1  //DZ1
    {
        public void Task1()
        {
            var A = Convert.ToInt32(Console.ReadLine());
            var B = Convert.ToInt32(Console.ReadLine());
            var sum = 0;

            for (int i = Math.Min(A, B); i <= Math.Max(A, B); i++)
                sum += i;

            Console.WriteLine("Sum of all alements between " + A + " and " + B + " is " + sum);
            Console.Write("All odd elements between " + A + " and " + B + " are  ");

            for (int i = Math.Min(A, B); i <= Math.Max(A, B); i++)
                if (i % 2 == 1)
                    Console.Write(i + " ");
        }
        public void Task2()
        {
            Console.WriteLine("Ractangle");
            //ractangle
            for (int i =0; i <10; i ++ )
            {
                for (int j =0; j <20; j ++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Triangle");
            //triangle
            for (int i =0; i <10; i ++ )
            {
                for (int j=0; j <=i*2; j ++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Equal side Triangle");
            //triangle 2
            for (int i=0;i <10; i ++ )
            {
                for (int j =i;j <10; j ++)
                    Console.Write(" ");

                for (int j =0; j <i*2; j ++ )
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Romb");
            //Romb
            for (int i =0; i <5; i ++ )
            {
                for (int j = i; j < 5; j++)
                    Console.Write("  ");

                for (int j = 0; j <= i * 2; j++)
                    Console.Write("**");

                Console.WriteLine();
            }
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("  ");

                for (int j = i*2; j <= 10; j++)
                    Console.Write("**");

                Console.WriteLine();
            }

        }
        public void Task3()
        {
            var P = Convert.ToInt32(Console.ReadLine());
            var cnt = P * 10;
            var K=0; 
            while (P<1100)
            {
                K++;
                P += cnt; 
            }
            Console.WriteLine("k = "+ K);
            Console.WriteLine("S = "+ P );
        }

    }
    class Homework2  //DZ2
    {
        public void Task1()
        {
            var x = new Random();
            var N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N+1];
            int max = 0, min=1001, sum =0; 
            for (int i =0; i <N; i ++ )
            {
                var cnt = x.Next(1,1000);
                arr[i] = cnt;

                max = Math.Max(max, cnt);
                min = Math.Min(min, cnt);
                sum += cnt;
            }
            Console.WriteLine("Max = "+max);
            Console.WriteLine("Min = "+min);
            Console.WriteLine("Sum = "+sum);
            Console.WriteLine("average ="+sum/N);
            Console.Write("All odd numbers are ");
            for (int i =0; i <N; i ++ )
                if (arr[i]%2==1)
                    Console.Write(i+" ");
        }
        public void Task2()
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var arr = new int[N + 1];
            var Ans = new int[N + 1]; 
            for (int i =1; i <=N; i ++ )
            {
                var x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x; 
            }

            for (int i = 1; i <= N; i++ )
                Ans[N - i] = arr[i];

            Console.WriteLine("All reversed alements are ");
            for (int i =0; i <N; i ++ )
            {
                Console.Write(Ans[i]+ " ");
            }
        }

        public void Task3()
        {
            Console.Write("Size of Array N= " );
            var N = Convert.ToInt32(Console.ReadLine());
            var x = new Random();
            int[] arr = new int[N + 1];
            for (int i = 0; i < N; i++)
            {
                var cnt = x.Next(1, 1000);
                arr[i] = cnt;
            }
            Console.Write("Coun = ");
            var count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Index = ");
            var index = Convert.ToInt32(Console.ReadLine());
            var temp = 0; 
            var Ans = new int[count];
            for (int i =index; i <index+count; i ++ )
            {
                if (i < N)
                    Ans[temp] = arr[i];
                else
                    Ans[temp] = 1;
                temp++; 
            }
            for (int i =0; i <count; i ++ )
            {
                Console.Write(Ans[i]+" ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var DZ1 = new Homework1();
            var DZ2 = new Homework2();

            //DZ1.Task3();

            DZ2.Task3();
        }
    }
}
