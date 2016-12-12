using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> PackBy<T>(this IEnumerable<T> source, int count)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (count <= 0)
                throw new ArgumentException("Must be greate then zero.", nameof(count));

            using (var enumerator = source.GetEnumerator())
            {
                while (true)
                {
                    var currentCount = 0;
                    var currentPack = new List<T>(count);

                    bool hasNext = true;

                    while (currentCount < count && (hasNext = enumerator.MoveNext()))
                    {
                        currentCount++;
                        currentPack.Add(enumerator.Current);
                    }

                    if (currentPack.Any())
                        yield return currentPack;

                    if (!hasNext)
                        yield break;
                }
            }
        }
    }
}
