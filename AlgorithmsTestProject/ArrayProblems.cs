namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        if (xs == ys)
        {
            return true;
        }

        if (xs == null || ys == null || xs.Length != ys.Length)
        {
            return false;
        }

        for (int i = 0; i < xs.Length; i++)
        {
            if (!EqualityComparer<T>.Default.Equals(xs[i], ys[i]))
            {
                return false;
            }
        }

        return true;
    }


    public static void Swap<T>(T[] xs, int a, int b)
    {
        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static T LastElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static T MiddleElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static void Reverse<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static int CountElement<T>(T[] xs, T element)
    { 
        throw new NotImplementedException();
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}