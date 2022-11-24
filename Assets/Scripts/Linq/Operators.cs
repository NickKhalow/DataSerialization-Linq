#nullable enable
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;


namespace DefaultNamespace
{
    public static class Operators
    {
        private static readonly int[] Numbers = new[]
            {0, 512, 10, 5, 60, 42, 69};


        [MenuItem("Linq/Operator")]
        public static void Print()
        {
            Debug.Log(JsonUtility.ToJson(Numbers.Where(n => n > 40).ToArray())!);
            Debug.Log(JsonUtility.ToJson(Numbers.Select(s => s * 2).ToArray())!);

            Debug.Log(Numbers.First());
            Debug.Log(Numbers.Last());

            Debug.Log(Numbers.All(n => n < 1024));
            Debug.Log(Numbers.Any(n => n % 2 == 0));
        }


        [MenuItem("Linq/Chain")]
        public static void Chain()
        {
            Debug.Log(Numbers
                .Where(n => n % 2 == 1)
                .Select(n => n * n)
                .Sum()
            );
        }


        [MenuItem("Linq/ChainImperative")]
        public static void ChainImperative()
        {
            var sum = 0;

            var onlyNotEvens = new List<int>(Numbers.Length);
            foreach (var number in Numbers)
            {
                if (number % 2 == 1)
                    onlyNotEvens.Add(number);
            }

            var squared = new List<int>(onlyNotEvens.Count);
            foreach (var onlyNotEven in onlyNotEvens)
            {
                squared.Add(onlyNotEven * onlyNotEven);
            }
            
            foreach (var i in squared)
            {
                sum += i;
            }
            
            Debug.Log(sum);
        }
    }
}