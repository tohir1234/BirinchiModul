using System.Globalization;

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

        //1.4.0:15
        //static bool Hammasikichik(string str)
        //{
        //    foreach (char c in str)
        //    {
        //        if (!char.IsLower(c))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //1.4.0:16
        //static string Res(string s)
        //{
        //    string natja = "";
        //    foreach (char c in s)
        //    {
        //        if (char.IsLower(c))
        //        {
        //            natja += char.ToUpper(c);
        //        }
        //        else
        //        {
        //            natja += c;
        //        }

        //    }
        //    return natja;
        //}

        //1.4.0:17
        //static int Oksozi(string str)

        //{ 
        //   int sanoq = 0;
        //    for (int i = 0; i < str.Length - 1; i++)
        //    {
        //        if (str[i] == 'o' && str[i + 1] == 'k')
        //        {
        //            sanoq++;
        //        }
        //    }
        //    return sanoq;
        //} 

        //1.4.0:18
        //static string Res(string x)
        //{
        //    string str = "";

        //    foreach (char c in x)
        //    {
        //        if (char.IsLower(c))
        //        {
        //            str += "*";

        //        }
        //        else
        //        {
        //            str += c;
        //        }
        //    }
        ////    return str;


        //1.4.0:19
        //static string Res(string x)
        //{
        //    string str = "";

        //    foreach (char c in x)
        //    {
        //        if (char.IsUpper(c))
        //        {
        //            str += char.ToLower(c);

        //        }
        //        else
        //        {
        //            str += c;
        //        }
        //    }
        //    return str;

        //1.4.0:20
        //static string Res(string x)
        //{
        //    string str = "";

        //    foreach (char c in x)
        //    {
        //        if (char.IsLower(c))
        //        {
        //            str += char.ToUpper(c);

        //        }
        //        else
        //        {
        //            str += c;
        //        }
        //    }
        //    return str;
        //1.4.0:21
        //static int Oksozi(string str)

        //{
        //    int sanoq = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == '@')
        //        {
        //            sanoq++;
        //        }
        //    }
        //    return sanoq;
        //}


        // Homework 1.4.1

        //1.4.1:1
        //static string Res(string s)
        //{
        //    return "Hello" + s + "!";
        //}

        //1.4.1:2
        //static string Res(string a, string b)
        //{
        //    return a + b + b + a;
        //}

        //1.4.1:3
        //static string Res(string s, string x)
        //{
        //    return "<<" + s + ">>"   +


        //        "[[" + x + "]]";
        //}

        //1.4.1:4
        //static string Res(string s)
        //{
        //    string res=s.Substring(s.Length  - 3);
        //    return res = res + res + res;
        //}

        //1.4.1:5
        //static string Res(string s)
        //{
        //    string res = s.Substring(0,2);
        //    return res;
        //}

        //1.4.1:6
        //static string Res(string s)
        //{

        //    return s.Substring(0, s.Length / 2); 
        //}

        //1.4.1;7
        //static string Res(string s)
        //{

        //    return s.Substring(1, s.Length - 2);
        //}

        //1.4.1:8
        //static string Res(string a, string b)
        //{
        //    if (a.Length < b.Length)
        //    {
        //        return a + b + a; 
        //    }
        //    else
        //    {
        //        return b + a + b;
        //    }
        //}

        //1.4.1;9
        //static string Res(string s,string z)
        //{

        //    return s.Substring(1)+z.Substring(1);
        //}

        //1.4.1:10
        //static string REss(string s)
        //{
        //    if (s.Length <= 2)
        //    {
        //        return s;
        //    }
        //    return s.Substring(2) + s.Substring(0, 2);
        //}

        //1.4.1:11
        //static string Res(string s,bool front)
        //{
        //    if (front)
        //    {
        //        return s.Substring(0, 1);

        //    }
        //    else
        //    {
        //        return s.Substring(0,s.Length - 1);
        //    }

        //}

        //1.4.1:12
        //static string Res(string a, int n)
        //{
        //    string res = a.Substring(0, n);
        //    string res2 = a.Substring(a.Length - n, n);
        //        return res + res2;

        //}

        //1.4.1:13
        //static string Res(string s)
        //{
        //    int res = s.Length / 2;
        //    return s.Substring(res - 1, 3);
        //}

        //1.4.1:14
        //static string Res(string a, string b)
        //{
        //    if (a.Length > 0 && b.Length > 0 && a[a.Length - 1] == b[0])
        //    {
        //        return a + b.Substring(1);
        //    }
        //    return a + b;
        //}

        //1.4.1:15
        //static string Res(string s)
        //{
        //    if (s.Length < 2)
        //    {
        //        return s;

        //    }
        //    string boshi=s.Substring(0,s.Length-2);
        //    char oxirgi = s[s.Length - 1];
        //    char oxirol = s[s.Length - 2];
        //    return boshi+oxirgi+oxirol;
        //}

        static string Res(string s)
        {
            if (s.StartsWith("red"))
            {
                return "red";
            }
            if (s.StartsWith("bule"))
            {
                return "blue";
            }
            return "";

        } 





































        static void Main(string[] args)
        {

            Console.WriteLine("string kiriting");
            string a = Console.ReadLine();
         

         

          



            Console.WriteLine(Res(a));


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

