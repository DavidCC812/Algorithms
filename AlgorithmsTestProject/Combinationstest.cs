using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace AlgorithmsTestProject
{
    public static class Combinationstest
    {
        [Test]
        public static void TestGenerateCombinations()
        {
            var testInput = new[] { 1, 3, 5 };
            var combinations = GenerateCombinations(testInput);

            foreach (var combination in combinations)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
        }

        public static List<List<int>> GenerateCombinations(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var combinations = new List<List<int>>();
            GenerateCombinationsHelper(input, new List<int>(), 0, combinations);

            return combinations;
        }

        private static void GenerateCombinationsHelper(int[] input, List<int> currentCombination, int startIndex, List<List<int>> combinations)
        {
            combinations.Add(new List<int>(currentCombination));

            for (int i = startIndex; i < input.Length; i++)
            {
                currentCombination.Add(input[i]);
                GenerateCombinationsHelper(input, currentCombination, i + 1, combinations);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}

