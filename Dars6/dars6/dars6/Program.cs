namespace dars6;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Add(4, 8));

    }

    //static int Add(int w, int g)
    //{
    //    return w + g;
    //}

    //static int Add(int l, int j, int d)
    //{
    //    return l + j + d;
    //}
    //static string Add(string b, string y, string h)
    //{
    //    return b + y + h;
    //}

    //static int Add(int k, int n)
    //{
    //    return k + n;
    //}
    //static int Add(int r, int t,int p)
    //{
    //    return r * t * p;
    //}

    static int Add(int v, int o)
    {
        int res = 1;
        for (int i=v; i>=1; i--)
        {
            res *= i;

        }
        return res;
    }


}
