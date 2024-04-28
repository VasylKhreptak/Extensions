using System;
using System.Collections.Generic;
using System.Linq;

namespace Plugins.Extensions
{
    public static class EnumerableExtensions
    {
        public static TSource GetByWeight<TSource>(this IEnumerable<TSource> source, Func<TSource, float> weight)
        {
            TSource[] enumerable = source as TSource[] ?? source.ToArray();
            float totalWeight = enumerable.Sum(weight);

            float randomNumber = UnityEngine.Random.value * totalWeight;

            float weightSum = 0;
            foreach (TSource item in enumerable)
            {
                weightSum += weight(item);
                if (weightSum >= randomNumber)
                    return item;
            }

            throw new InvalidOperationException("Failed to retrieve a random item by weight.");
        }

        public static TSource Random<TSource>(this IEnumerable<TSource> source)
        {
            TSource[] enumerable = source as TSource[] ?? source.ToArray();
            return enumerable.ElementAt(UnityEngine.Random.Range(0, enumerable.Length));
        }
    }
}