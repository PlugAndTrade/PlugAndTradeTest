using System;
using System.Collections.Generic;
using System.Linq;

namespace PlugAndTradeTest
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TRes> AllMinBy<TRes>(this IEnumerable<TRes> source, Func<TRes, decimal> comp) =>
            source
                .Skip(1)
                .Aggregate(
                    new Tuple<decimal, IEnumerable<TRes>>(comp(source.First()), new[] { source.First() }),
                    (agg, item) =>
                    {
                        var c = comp(item);
                        return agg.Item1 < c ? agg
                            : agg.Item1 == c ? Tuple.Create(agg.Item1, agg.Item2.Concat(new[] { item }))
                            : Tuple.Create<decimal, IEnumerable<TRes>>(c, new[] { item });
                    }
                )
                .Item2;

        public static TRes MinBy<TRes>(this IEnumerable<TRes> source, Func<TRes, decimal> comp) => source.AllMinBy(comp).First();

        public static IEnumerable<IReadOnlyCollection<TRes>> CartesianProduct<TRes>(this IEnumerable<IEnumerable<TRes>> lists)
        {
            var enumerators = lists
                .Select(l => l.GetEnumerator())
                .Where(e => e.MoveNext())
                .ToArray();

            while (true)
            {
                yield return enumerators.Select(x => x.Current).ToArray();
                foreach (var enumerator in enumerators)
                {
                    if (!enumerator.MoveNext())
                    {
                        if (enumerator == enumerators.Last())
                        {
                            yield break;
                        }
                        enumerator.Reset();
                        enumerator.MoveNext();
                        continue;
                    }

                    break;
                }
            }
        }
    }
}