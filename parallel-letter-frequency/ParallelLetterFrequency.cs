using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public static class ParallelLetterFrequency
{

    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        ConcurrentDictionary<char, int> DictOfChars = new ConcurrentDictionary<char, int>();

        Parallel.ForEach(texts, text =>
        {
                foreach (var chara in text.ToLower())
                {
                    if (char.IsLetter(chara))
                        lock (DictOfChars)
                        {
                            if (!DictOfChars.TryAdd(chara, 1))
                                DictOfChars[chara]++;
                        }
                }
        });

        return DictOfChars.ToDictionary(key=> key.Key, val=> val.Value);
    }

/*    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        var map = new ConcurrentDictionary<char, int>();

        Parallel.ForEach(texts, text =>
        {
            foreach (var c in text.ToLower().Where(char.IsLetter))
                map.AddOrUpdate(c, 1, (_, i) => i + 1);
        });

        return new Dictionary<char, int>(map);
    }*/
}
