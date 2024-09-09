using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Metadata;

namespace Collections
{
    class SortedList
    {
        static void Main(string[] args)
        {
           SortedList sortedList=new SortedList(){{2,true},{1,"one"}};
           foreach(DictionaryEntry kvp in SortedList)
           {
             Console.WriteLine(Key.Value);
           }
        }
    
    }      
}