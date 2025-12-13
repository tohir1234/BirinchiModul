using System.ComponentModel.Design;

namespace dars_6;

internal class Program
{
      //1
    static float Add(float a, float b)
    {
        return a + b;
    }
    static float Add(float a, float b, float c)
    {
        return a + b + c;
    }
    static string Add(string a, string b)
    {
        return a + b;
    }
    
    //2
    static void Repeat(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(a + "");
        }
        Console.WriteLine();
    }
    static void Repeat(int a, int b)
    {
        for (int i = 0; i < b; i++)
        {
            Console.Write(a + "");
        }
        Console.WriteLine();
    }

    //3
    static float Calculate(float a, float b)
    {
        return a + b;
    }
    static float Calculate(float a, float b, float c)
    {
        return a * b * c;

    }

    //4
    static int getAmounDigit(int a)
    {
        return a.ToString().Length;
    }

    static int getAmounDigit(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c >= '0' && c <= '9')
            {
                count++;
            }
        }
        return count;
    }

    //5
    static int findMax(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));


    }
    static int findMax(int a, int b, int c, int d)
    {
        return Math.Max(findMax(a,b, c),d);


    }
    static int findMax(int a, int b, int c,int d, int e)
    {
        return Math.Max(findMax(a,b, c, d),e);


    }

    //6
    static int multipliction(int a)
    {
        int num = 1;
        for (int i=1; i<=a; i++)
        {
            num *= i;
        }
        return num;
    }
    static int multipliction(int a, int b)
    {
        int num = 1;
        for (int i=a; i<=b; i++)
        {
            num *= i;
        }
        return num;
    }
    static int multipliction(int a,int b, int c)
    {

        return a * b * c;
    }

    //7
    static int CounDigits(int a)
    {
        a= Math.Abs(a);
        if (a < 10)

        {
            return 1;
        }

        return 1 + CounDigits(a / 10);

    }

    //8
    static int Yigindi(int a, int b)
    {
        if (a > b)
        {
            return 0;
        }

        return a + Yigindi(a + 1, b);
    }

    //9
    static long SonlarYigindi(int n)
    {
        long sum = 0;
        for (int i=1; i<n; i++)
        {
            sum += i * i * i;

        }
        return sum;
    }

    //10
    static int myMax(int a, int b)
    {
        if (a > b)
        {
            return a;

        }
        else
        {
            return b;
        }
    }

    //11
    static int myabs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }

    //12
    static bool myIsupper(char c)
    {
        return (c>= 'A' && c <= 'Z');
    }

   //13
    static bool myToupper(char c)
    {
        if(c>='a' && c<='z')
        {
            return c - 32;
        }
        else
        {
            return c;
        }
    }
    

   








    static void Main(string[] args)
    {


        
       


        //9
        //{
        //    Console.Write("n = ");
        //    int n = int.Parse(Console.ReadLine());

        //    long result = SonlarYigindi(n);
        //    Console.WriteLine("Natija: S = " + result);
        //}


        //Repeat(3, 5);
        //Repeat(4);

        //Console.WriteLine(Add(4, 5));
        //Console.WriteLine(Add(4, 5, 6));
        //Console.WriteLine(Add("str","size"));
    }
}
