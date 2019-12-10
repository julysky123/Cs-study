using System;


class While
{
    public static void Main()
    {
        int count = 0;
        while (count <3)
        {
            Console.WriteLine(count + ": Hello, C#");
            ++count;
        }

        //홀수끼리의 합 짝수끼리의 합
        int k=1;
        int even_sum=0, odd_sum = 0;
        while(k<101)
        {
            odd_sum += k;
            even_sum += k + 1;
            k += 2;
        }


        //달력 찍기.
        Console.WriteLine(" Sun Mon Tue Wen Thu Fri Sat");
        int kk = 1;
        while (true)
        {
            int w = 0;
            while(w<7)
            {
                Console.Write("{0,4:d2}", kk++);        // 4칸씩 차지. 숫자는 2칸을 사용 
                w++;
                if (kk > 32) break;
            }
            Console.WriteLine("");
            if (kk > 32) break;
        }
        
    }
}
