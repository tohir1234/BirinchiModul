using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Dars4
{
    internal class Program
    {


        //1.4.0: 1
        //static int Son(int a, int b)
        //   {
        //       return a + b;
        //   }

        //1.4.0:2
        //static string Almashtirish(string str)
        //{
        //    string natija = "";
        //    foreach (char c in str)
        //    {
        //        if (c == 'x') natija += 'y';
        //        else if (c == 'y') natija += 'z';
        //        else
        //        {
        //            natija += c;

        //        }


        //    }
        //    return natija;

        //}

        //1.4.0:3
        //static int Kichikharflarsoni(string str)
        //{
        //    int sanoq = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsLower(str[i]))
        //        {
        //            sanoq++;

        //        }




        //    }
        //    return sanoq;
        //}

        //1.4.0:4
        //static int Butunson(int x, int y)
        //{
        //    int sanoq = 0;
        //    for (int i=x   ; i<y; i++)
        //    {
        //        if (i%2!=0)
        //        {
        //            sanoq++;
        //        }

        //    }
        //    return sanoq;

        //}

        //1.4.0:5
        //static int Xona(int n)
        //{
        //    n = Math.Abs(n);
        //    if (n == 0)
        //    {
        //        return 1;
        //    }
        //    int sana = 0;
        //    while (n > 0)
        //    {
        //        n /= 10;
        //        sana++;
        //    }
        //    return sana;
        //}

        //1.4.0:6
        //static bool Raqamlikka(string a)
        //{
        //    foreach(char c in a)
        //    {
        //        if (!char.IsDigit(c))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}

        // 1.4.0:7
        //static bool Tub(int x)
        //{
        //    if (x < 2)
        //    {
        //        return false;
        //    }
        //    for (int i=2; i<=x/2; i++)
        //    {
        //        if (x%i==0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //1.4.0:8
        //static string Qaytaruvchi(string str)

        //{
        //    string natija = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        natija += str[i];
        //    }
        //    return natija;

        //}

        //1.4.0:9
        //static int Rum(string str)
        //{
        //    int r = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            r++;
        //        }

        //    }
        //    return r;
        //}

        //1.4.0:10
        //static bool Palindrom(string str)
        //{
        //    string teskari = "";
        //    for (int i=str.Length - 1; i>=0; i--)
        //    {
        //        teskari += str[i];

        //    }

        //return str==teskari;

        //}

        //1.4.0:11
        //static bool Raqamlikka(string a)
        //{
        //    foreach(char c in a)
        //    {
        //        if (!char.IsDigit(c))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}

        //1.4.0:12
        //static int  Res(string  x)
        //{
        //    int sanoq = 0;
        //    for (int i=0; i<x.Length; i++)
        //    {
        //        if (char.IsDigit(x[i]))
        //            {
        //            sanoq++;
        //        }
        //    }
        //    return sanoq;
        //}

        //1.4.0:13
        //static int Res(string x)
        //{
        //    int sanoq = 0;
        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        if (char.IsUpper(x[i]))
        //        {
        //            sanoq++;
        //        }
        //    }
        //    return sanoq;
        //}

        //1.4.0;14
        //static bool Res(string x)
        //{
        //    foreach (char c in x)
        //    {
        //      if (!char.IsUpper(c))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}


        static bool Hammasikichik(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLower(c))
                {
                    return false;
                }
            }
            return true;

        }

















        static void Main(string[] args)
        {

            Console.WriteLine("string kiriting");
            string a = Console.ReadLine();

            Console.WriteLine(Hammasikichik(a));


            //1.4.0:5
            //Console.WriteLine("son kiriting");
            //int y=int.Parse(Console.ReadLine());
            //Console.WriteLine(Xona(y));



            //1.4.0:4
            //Console.WriteLine(" a sonini kiriting");
            //int a=int.Parse(Console.ReadLine());

            //Console.WriteLine(" b sonini kiriting");
            //int b =int.Parse(Console.ReadLine());
            //Console.WriteLine(Butunson(a, b));

            //1.4.0:3
            //Console.WriteLine("string kiriting");
            //string s = Console.ReadLine();

            //Console.WriteLine(Kichikharflarsoni(s));


            //1.4.0:2
            //Console.WriteLine("string kirting");
            //string text=Console.ReadLine();
            //Console.WriteLine("natija" + Almashtirish(text));


            //1.4.0 : 1
            //Console.WriteLine(" a sonini kirting");
            //int a=int.Parse(Console.ReadLine());

            //Console.WriteLine(" a sonini kirting");
            //int b=int.Parse(Console.ReadLine());

            //int natija = Son(a, b);
            //Console.WriteLine(natija);


            //    string text = "salom Hello g13";
            //    var res = text.Substring(12, 3);
            //    Console.Write(res);
            //}

            //string text = "Foundation";
            //string text2 = "davay";
            //string natija = text.Substring(2,text.Length-4);
            //Console.Write(natija);



        }
    }
}

