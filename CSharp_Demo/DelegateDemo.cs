using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Demo
{
    #region Eg:1

    //delegate int Transformer(int x);
    //class Util
    //{
    //    public static void Transform(int[] values, Transformer t)
    //    {
    //        for (var i = 0; i < values.Length; i++)
    //        {
    //            values[i] = t(values[i]);
    //        }
    //    }
    //}
    //class Program
    //{


    //    static int Square(int x) => x * x;

    //    static int Cube(int x) => x * x * x;
    //    static void Main(string[] args)
    //    {
    //        //1.  插件式编程
    //        //int[] values = { 1, 2, 3, 4, 5 };
    //        //Util.Transform(values, Square);
    //        //foreach (var value in values)
    //        //{
    //        //    Console.WriteLine($"Value:{value}.");
    //        //}

    //        //2.  多播应用
    //        Transformer t = null;
    //        t += Square;

    //        var result = t(3);

    //        Console.WriteLine($"result: {result}");

    //        t += Cube;

    //        var result1 = t(4);

    //        Console.WriteLine($"result1: {result1}");

    //        t -= Cube;

    //        var result2 = t(4);

    //        Console.WriteLine($"result2: {result2}");

    //        Console.ReadLine();

    //    }
    //}

    #endregion

    #region Eg:2

    //public delegate void ProgressReporter(int percentComplete);

    //class X
    //{
    //    public void InstanceProgress(int percentComplete)
    //        => Console.WriteLine($"Current progress: {percentComplete}%");
    //}


    //class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        X x = new X();
    //        ProgressReporter p = x.InstanceProgress;

    //        p(87);

    //        Console.WriteLine(p.Target == x);

    //        Console.WriteLine(p.Method);

    //        Console.ReadLine();

    //    }
    //}

    #endregion

    #region Eg:3 (Generic泛型)

    //public delegate T Transformer<T>(T arg);

    //public class Util
    //{
    //    public static void Transform<T>(T[] values, Transformer<T> t)
    //    {
    //        for (var i = 0; i < values.Length; i++)
    //        {
    //            values[i] = t(values[i]);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static int Cube(int x) => x * x * x;
    //    static void Main(string[] args)
    //    {

    //        int[] values = { 2, 3, 6, 7 };

    //        Util.Transform<int>(values, Cube);

    //        foreach (var value in values)
    //        {
    //            Console.WriteLine($"value:{value}");
    //        }

    //        Console.ReadLine();

    //    }
    //}

    #endregion

    #region Func

    public class Util
    {
        public static void Transform<T>(T[] values, Func<T,T> t)
        {
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }

    #endregion
}
