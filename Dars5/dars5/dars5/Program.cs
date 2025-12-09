using System.ComponentModel.Design;

namespace dars5
{
    internal class Program
    {
        //1.5.1:1
        //static int Miqdor(List<int> list)
        // {
        //     int count = 0;
        //     for (int i = 0; i < list.Count; i++)
        //     {
        //         int z = list[i];
        //         if ((z >= 100 && z <= 999) || (z <= -100 && z >= -999))
        //         {
        //             count++;
        //         }
        //     }
        //     return count;

        // }


        //1.5.1:2
        //static int Miqdor(List<int> list)
        //{
        //    int count = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int z = list[i];
        //        if (z % 2 == 0)

        //        {
        //            count++;
        //        }
        //    }
        //    return count;

        //}

        //1.5.1:3
        //static int Miqdor(List<int> list)
        //{
        //    int count = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int z = list[i];
        //        if (z % 2 != 0)

        //        {
        //            count++;
        //        }
        //    }
        //    return count;

        //}

        //1.5.1:4
        //static int Miqdor(List<int> list)
        //{
        //    int count = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int z = list[i];
        //        if (z % 3 == 0 && z% 7==0)

        //        {
        //            count++;
        //        }
        //    }
        //    return count;

        //}

        //1.5.1:5
        //static void Miqdor(List<int> list , out int yigindi,out int count)
        //{
        //     yigindi=0;
        //     count = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int z = list[i];
        //        if (z >= 10 && z <= 99)

        //        {
        //            yigindi += z;
        //            count++;
        //        }

        //    }    
        //}

        //1.5.1:6
        //static void Almashtir(List<int> list)
        //{
        //    if (list.Count > 1)
        //    {
        //        int temp = list[0];
        //        list[0] = list[list.Count - 1];
        //        list[list.Count - 1] = temp;
        //    }

        //}

        //1.5.1.:7
        //static  int Yigindi(List<int> list)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < 3 && i < list.Count;i++)
        //    {
        //        sum += list[i];
        //    }
        //    return sum;
        //}

        //1.5.1:8
        //static int Yigindi(List<int> list)
        //{
        //    int sum = 0;
        //    int start =Math.Max(0, list.Count - 3);
        //    for (int i = start;  i < list.Count ; i++)
        //    {
        //        sum += list[i];
        //    }
        //    return sum;
        //}

        //1,5,1:9
        //static bool Taqqos(List<int>list)
        //{
        //    int toq = 0;
        //    int juft = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        juft++;
        //    }
        //    else
        //    {
        //        toq++;
        //    }
        //    return toq > juft;
        //}







        //1.5.1:10
        //static void Miqdor(List<int> list)
        //{
          
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] % 2 == 0)
        //        {
        //            list[i] = list[i] * 3;

        //        }

                  
                

        //    }
        //}



        static void Main(string[] args)
        {


            //1.5.1:10
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}

            //Miqdor(list);
            //Console.WriteLine("Almashtirilgan list =");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}

            //1.5.1:9
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}

            //bool natija = Taqqos(list);
            //Console.WriteLine("Almashtirilgan list =");
            //Console.WriteLine("Natija" + natija);






            //1.5.1:8
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}
            //Console.WriteLine(" oxirgi 3ta elementning yigindisi=" + Yigindi(list));



            //1.5.1:7
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}
            //Console.WriteLine(" dastlabki 3ta elementning yigindisi=" + Yigindi(list));  




            //1.5.1:6
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}

            //Almashtir(list);
            //Console.WriteLine("Almashtirilgan list =");
            //for(int i=0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}





            //1.5.1:5
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();



            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}
            //int yigindi, count;
            //Miqdor(list, out yigindi, out count);
            //Console.WriteLine(" 3 xonali sonlar miqdori=" + count);

            //Console.WriteLine(" 3 xonali sonlar yigindisi=" + yigindi);



            //1.5.1:1
            //Console.WriteLine("list kiriting ");
            //int z = int.Parse(Console.ReadLine());


            //List<int> list = new List<int>();

            //for (var i = 0; i < z; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var n = int.Parse(Console.ReadLine());
            //    list.Add(n);
            //}
            //Console.WriteLine(" 3 xonali sonlar miqdori=" + Miqdor(list));


            //Console.WriteLine("list Lengthni kiriting :");
            //var n=int.Parse(Console.ReadLine());
            //List<int> ints =new List<int>();

            //for (var i=0; i<n; i++)
            //{
            //    Console.Write("List elementlarini kiriting :");
            //    var num = int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //}

            // Homework 1.5.1

            //Console.Write("List lengthni kiriting : ");
            //var n = int.Parse(Console.ReadLine());

            //List<int> ints = new List<int>();

            //for (var i = 0; i < n; i++)
            //{

            //    Console.Write("List elementini kiriting : ");
            //    var num = int.Parse(Console.ReadLine());
            //    ints.Add(num);
            //}

        }
    }
}
