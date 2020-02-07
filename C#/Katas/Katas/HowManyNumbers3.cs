using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class HowManyNumbers3
    {
        public static List<long> FindAll(int sumDigits, int numDigits)
        {
            Console.WriteLine(sumDigits + " <--- sumDigits");
            Console.WriteLine(numDigits + " <--- numDigits");
            if (sumDigits / numDigits > 9) return new List<long>();
            if (numDigits * 9 < sumDigits ) return new List<long>();
            var answer = Enumerable.Repeat(1, numDigits).ToArray();
            answer[numDigits - 1] = sumDigits - numDigits + 1;

            var isPossible = true;
            var toMove = 0;
            for (var i = numDigits - 1; i >= 0; i--)
            {
                if (answer[i] > 9 && toMove == 0)
                {
                    toMove = answer[i] - 9;
                    answer[i] = 9;
                    if (toMove == 0) break;
                    continue;
                }
                if (toMove == 0) break;
                if (toMove >= 9)
                {
                    answer[i] = 9;
                    toMove -= 8;
                    continue;
                }
                if (toMove >= 9) continue;
                answer[i] += toMove;
                toMove = 0;
                break;
            }
            var min = answer.ToArray();



            var max = answer.ToArray();
            var lastIndexMinus = -1;
            while (isPossible)
            {
                isPossible = false;
                for (var i = numDigits - 1; i > 0; i--)
                {
                    if (toMove == 0 && answer[i] > answer[i - 1])
                    {
                        answer[i]--;
                        toMove++;
                        isPossible = true;
                        lastIndexMinus = i;
                    }
                    if (toMove == 1 && answer[i - 1] + 1 <= answer[i])
                    {
                        answer[i - 1]++;
                        toMove--;
                        isPossible = true;
                        lastIndexMinus = -1;
                        break;
                    }
                }
                if(toMove > 0) break;
            }
            if(lastIndexMinus != -1) answer[lastIndexMinus]++;
            max = answer.ToArray();

            var count = min.SequenceEqual(max) ? 1 : 2;
            if (count == 1)
                return new List<long>() {1, int.Parse(string.Join("", min)), int.Parse(string.Join("", min))};
            var copyMin = min.ToArray();


            while (true)
            {
                copyMin[numDigits - 1]++;

                var indexLowestThenNine = 0;
                var numberLowestThenNine = 0;
                if (copyMin[numDigits - 1] == 10)
                {
                    for (var i = numDigits - 1; i >= 0; i--)
                    {
                        if (copyMin[i] >= 9) continue;
                        indexLowestThenNine = i;
                        numberLowestThenNine = copyMin[i];
                        break;
                    }

                    numberLowestThenNine++;
                    for (var i = indexLowestThenNine; i < numDigits; i++)
                    {
                        copyMin[i] = numberLowestThenNine;
                    }
                }

                if(copyMin.SequenceEqual(max)) break;

                if (copyMin.Sum(n => n) != sumDigits) continue;
                {
                    isPossible = true;
                    for (var i = 1; i < numDigits; i++)
                    {
                        if (copyMin[i - 1] > copyMin[i])
                        {
                            isPossible = false;
                        }
                    }
                    if (isPossible) count++;
                }
            }

            return new List<long>()
            {
                count,
                long.Parse(string.Join("", min)),
                long.Parse(string.Join("", max)),
            };
        }
    }
}