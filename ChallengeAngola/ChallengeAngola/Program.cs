using System;
using System.Collections.Generic;

namespace ChallengeAngola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var original = new List<int>{-1, -2, 0, 1 };
            var filtered = original.FilterCollection<int>(x=>x>0);
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
        //public static class Example <T>
        //{
        //    public static IList<T> FilterCollection(IList<T> originalCollection)
        //    {
        //        var filtered = new List<T>();
        //        for (int i = 0; i < originalCollection.Count; i++)
        //        {
        //            if (Evaluate(originalCollection[i]))
        //            {
        //                filtered.Add(originalCollection[i]);
        //            }
        //        }
        //        return filtered;
        //    }
        //    private static bool Evaluate(T evaluate) 
        //    {
        //        if (evaluate is int )
        //        {
        //            var value = (int)(object)evaluate;
        //            return value > 0;
        //        }
        //        return false;
        //    }
        //}
        //                 Rewrite the code considering the following points(the usage of LINQ is forbidden) :
        //                 A.FilterCollection should be able to receive any kind of collection instead of being restricted
        //                 to just List<>.
        //                 B.The code should work with any kind of value, not just int.
        //                 C.Erase the Evaluate method.Instead, the function that FilterCollection will use as a
        //                 predicate should get defined at runtime (every time the method is called) instead of
        //                 compile time.
        //                 D.FilterCollection should be called directly from the desired collection, for example:
        //                 inside a method
        //                 int[] original = new int[] { 1, 2, 3 };
        //                 Int[] filtered = original.FilterCollection(...);
        //                 E.FilterCollection should return a lazy collection.
    }
}
