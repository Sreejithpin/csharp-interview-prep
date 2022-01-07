using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lib
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public string UseJsonNetForSomeReason<T>(T input)
        {
            Test();
            return JsonConvert.SerializeObject(input);
        }

        public void Test()
        {
            Test test = new Test() { Id = 1, Name = "t" };
            Test test1 = new Test() { Id = 2, Name = "t2" };
            var lst = new List<Test>();
            lst.Add(test);
            lst.Add(test1);

            var str = JsonConvert.SerializeObject(lst);

            var t = JsonConvert.DeserializeObject<List<Test>>(str)  ;
        }
    }
 
    public class Test
    {
        
        public int Id { get; set; }

 
        public string Name { get; set; }
    }
}
