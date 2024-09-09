using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Student:IComparable
    {
        public int Id{get;set;}
        public string Name{get;set;}

        public int CompareTo(object obj)
        {
             Student student =obj as Student;
             if(student==null) 
                 return -1;
             if(this.Id)    
        }

        public override string ToString()
        {
            return $"ID:{Id} Name {Name}";
        }
    }
}