using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Metadata;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // //1.Stack
            // Stack<string>stk=new Stack<string>();
            // stk.Push("santosh");
            // stk.Push("kUMAR");
            // // Console.WriteLine(stk.Pop());
            // // Console.WriteLine(stk.Peek());
            // Console.WriteLine("Count in the stack:-"+stk.Count);

            //Arraylist
            // int[] arr={5,6,7};
            // ArrayList array=new ArrayList();
            // array.Add(9);
            // array.Add("santosh");

            // //Array.AddRange(arr);
            // foreach(object o in array)
            // {
            //     Console.WriteLine(o);
            // }
            // Console.WriteLine(array.Capacity);

            //List Student
            List<Student> list=new List<Student>();
            list.Add(new Student(){Id=1,Name="Santosh"});
            list.Add(new Student(){Id=2,Name="Anand"});
            list.Add(new Student(){Id=3,Name="kash"});
            list.Add(new Student(){Id=4,Name="Ramesh"});

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            //IEComaprable
            Student student1=new Student(){Id=104,Name="Ankit"};
            Student student2=new Student(){Id=107,Name="Ravan"};
            // Console.WriteLine("Sorted list of Student");
            int Result= student1.CompareTo(student2);
            Console.WriteLine("IEComparable is "+Result);
             

            Console.WriteLine()

            foreach(var item in list)
            {
                Console.WriteLine(item.Id+item.Name);
            }
            Console.ReadLine();

            //2.Queue
            // Queue<int>que=new Queue<int>();
            // que.Enqueue(1);
            // que.Enqueue(2);
            // que.Enqueue(3);
            // Console.WriteLine(que.Dequeue());
            // Console.WriteLine(que.Dequeue());
            //Console.WriteLine("Count in the queue:-"+que.Count);

            // //Hashtable
            // Hashtable ht=new Hashtable();
            // ht.Add("Apple",5);
            // ht.Add("Banana",3);
            // ht.Add("santosh","Akash");
            // ht.Add('w',3);
            // ht.Add('x',null);
            // Student student=new Student(){Id=101,Name="Santosh"};
            // Student student1=new Student(){Id=7,Name="Akash"};
            // ht.Add(student,student1);

            // foreach(DictionaryEntry d in ht)
            // {
            //     Console.WriteLine(d.Key+":"+d.Value);
            // }

            // Dictionary<string,int?> dict=new Dictionary<string, int?>();
            // dict.Add("Apple",6);
            // dict.Add("Mango",7);
            // dict.Add("Guava",8);
            // dict.Add("null",3);
            // dict.Add("Grapes",null); 

            // foreach (KeyValuePair<string,int>kvp in dict)
            // {
            //     Console.WriteLine(kvp.Key+":"+kvp.Value);
            // }


        }
    }
}
