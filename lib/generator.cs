using System;
using System.Collections.Generic;

public static class Generator
{
  static Random _random = new Random();

  //https://www.dotnetperls.com/fisher-yates-shuffle
  public static List<T> Shuffle<T>(List<T> list)
  {
      int n = list.Count;
      for (int i = 0; i < n; i++)
      {
          int r = i + _random.Next(n - i);
          T t = list[r];
          list[r] = list[i];
          list[i] = t;
      }
      return list;
  }

  public static T Random<T>(List<T> list)
  {
    var index = _random.Next(list.Count);
    return list[index];
  }

  public static Func<T> GenerateRule<T>(List<T> inputList)
  {
    return () => Random(inputList);
  }

  public static Func<T> GenerateUniqueRule<T>(List<T> inputList)
  {
    IEnumerable<T> shuffledList = Shuffle(inputList);

    var enumerator = shuffledList.GetEnumerator();

    Func<T> func = () =>
        {
            if (enumerator.MoveNext())
            {
              //do nothing
            }
            else
            {
              enumerator.Reset();
              enumerator.MoveNext();
            }
            return enumerator.Current;
        };
    return func;
  }
}