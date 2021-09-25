using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeAngola
{
    public static class CollectionExtension
    {
        public static Lazy<IList<T>> FilterCollection<T>(this IList<T> originalCollection, Func<T, bool> predicate)
        {
            var filtered = new Lazy<IList<T>>(()=>new List<T>());
            for (int i = 0; i < originalCollection.Count; i++)
            {
                if (predicate != null)
                {
                    if (predicate(originalCollection[i]))
                    {
                        filtered.Value.Add(originalCollection[i]);
                    }
                }
            }
            return filtered;
        }
        //private static bool Evaluate<T>(T evaluate)
        //{
        //    if (evaluate is int)
        //    {
        //        var value = (int)(object)evaluate;
        //        return value > 0;
        //    }
        //    return false;
        //}
    }
}
