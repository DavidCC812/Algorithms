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
        if (xs == null || xs.Length == 0)
        {
            throw new IndexOutOfRangeException("The array is null or empty.");
        }

        return xs[0];
    }



    public static T LastElement<T>(T[] xs)
    {
        if (xs == null || xs.Length == 0)
        {
            throw new IndexOutOfRangeException("The array is null or empty.");
        }

        return xs[xs.Length - 1];
    }


    public static T MiddleElement<T>(T[] xs)
    {
        if (xs == null || xs.Length == 0)
        {
            throw new IndexOutOfRangeException("The array is null or empty.");
        }

        int middleIndex = xs.Length / 2;
        return xs[middleIndex];
    }


    public static void Reverse<T>(T[] xs)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        Array.Reverse(xs);
    }


    public static int CountElement<T>(T[] xs, T element)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        return xs.Count(x => EqualityComparer<T>.Default.Equals(x, element));
    }


    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        return string.Join(",", xs);
    }


    // Bonus problems

 
    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        return xs.Count(predicate);
    }



    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }

        return xs.Min();
    }


   public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs == null)
        {
            throw new ArgumentNullException(nameof(xs));
        }

        if (xs.Length < 1)
        {
            throw new IndexOutOfRangeException();
        }

        return xs.Max();
    }


  public static bool HasDuplicates<T>(T[] xs)
    {
        for (int i = 0; i < xs.Length; i++)
        {
            for (int j = i+1; j < xs.Length; j++)
            {
                if(xs[i].Equals(xs[j]))
                {
                    return false;
                }
            }
        }
        return true;
    }

}