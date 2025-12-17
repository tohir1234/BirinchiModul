namespace dars8
{      //ref vs out
    internal class Program
    {
        static void Main(string[] args)
        {

            ////m1
            //int a = 5;
            //Ref1(ref a);
            //Console.WriteLine(a);
            //static int Ref1(ref int s)
            //{
            //    return s * 2;
            //}


            ////m2
            //int a2;
            //Out1(out a2);
            //Console.WriteLine(a2);
            //static int Out1(out int a)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    return a;
            //}

            ////m3
            //int a3 = 3;
            //int b3 = 7;
            //static int Ref2(ref int a, ref int b)
            //{
            //    (a, b) = (b, a);
            //    return 0;

            //}
            //Ref2(ref a3, ref b3);
            //Console.WriteLine(a3);
            //Console.WriteLine(b3);

            ////m4
            //int a4;
            //static int Out4(out int a)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    return a * a;
            //}
            //Out4(out a4);
            //Console.WriteLine(a4);

            ////m5
            //int a5 = 10;
            //static int Ref5(ref int a)
            //{
            //    if (a % 2 == 0)
            //    {
            //        a = 0;
            //        return a;
            //    }
            //    return a;
            //}
            //Ref5(ref a5);
            //Console.WriteLine(a5);

            ////m6
            //int a6 = -10;
            //static void Ref6(ref int a)
            //{
            //    if (a < 0)
            //    {
            //        a *= -1;
            //    }

            //}
            //Ref6(ref a6);
            //Console.WriteLine(a6);

            ////m7 
            //int a7 = 10;
            //int b7 = 5;
            //int yig; int kop;

            //static void Out7(int a, int b, out int yig, out int kop)
            //{
            //    yig = a + b;
            //    kop = a * b;
            //}
            //Out7(a7, b7, out yig, out kop);
            //Console.WriteLine(yig);
            //Console.WriteLine(kop);

            ////m8
            //int a8 = 1000;
            //static void Ref8(ref int a)
            //{
            //    int b = int.Parse(Console.ReadLine());
            //    if (a > b)
            //    {
            //        a -= b;
            //    }
            //}
            //Ref8(ref a8);
            //Console.WriteLine(a8);

            ////m9
            //int a9;
            //static bool Out9(out int a)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    if (a % 2 == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            //Out9(out a9);
            //Console.WriteLine(a9);

            ////m10
            //int a10 = 1;
            //static void Ref10(ref int a)
            //{
            //    a++;
            //}
            //for (var i = 1; i <= 10; i++)
            //{
            //    Ref10(ref a10);
            //    Console.WriteLine(a10);
            //}

            //List<int> n = new List<int>(999999999);
            //for (var i = 0; i < 1000000000; i++)
            //{
            //    n.Add(i);
            //    Console.WriteLine($"{i} => {n[i]}");
            //}

        }
    }
}
