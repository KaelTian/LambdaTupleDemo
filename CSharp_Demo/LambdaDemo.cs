using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Demo
{
    public class LambdaDemo
    {

        
        void Foo<T>(T x) { }

        void Bar<T>(Action<T> a) { }

        public void MyMethod()
        {
            //泛型需要显式指定参数 type 类型
            Bar((int x) => Foo(x));
            Bar<int>(x => Foo(x));
            Bar<int>(Foo);
        }
    }
}
