using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<T> NewWhere<T>(this IEnumerable<T> items,Func<T,bool> predicate)
        {
            var list = new List<T>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }  
        
        public static IEnumerable<TResult> NewSelect<T,TResult>(this IEnumerable<T> items,Func<T, TResult> selector)
        {

            foreach (var item in items)
            {
                yield return selector(item);
            }

        }

        public static IEnumerable<TResult> NewSelectMany<T, TResult>(this IEnumerable<T> items, Func<T, IEnumerable<TResult>> selector)
        {

            foreach (var item in items)
            {
                foreach (var innerItem in selector(item))
                {
                    yield return innerItem;
                }
               
            }

        }
    }
}
