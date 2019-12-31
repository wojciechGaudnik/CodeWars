namespace Katas
{
    public class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            var m = coins.Length;
            var table = new int[money + 1];
            table[0] = 1;
            for(var i = 0; i < m; i++)
            for(var j = coins[i]; j <= money; j++)
                table[j] += table[j - coins[i]];
            return table[money];
        }
    }

}