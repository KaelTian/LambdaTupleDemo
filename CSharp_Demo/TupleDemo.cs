using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Demo
{
    /// <summary>
    /// 元组
    /// </summary>
    public class TupleDemo
    {
        public (string Name, int Age) GetPerson() => (Name: "Lol", Age: 33);

    }
}
