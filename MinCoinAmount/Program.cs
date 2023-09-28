namespace MinimumCoinAmount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int amountOne = 17;
            int amountTwo = 1700;
            Console.WriteLine(MinSplit(amountOne));
            Console.WriteLine(MinSplit(amountTwo));
        }

        public static int MinSplit(int amount)
        {
            int[] coinArray = { 50, 20, 10, 5, 1 };
            int sumOfCoins = 0;

            for (int i = 0; i < coinArray.Length; i++)
            {
                if (amount >= coinArray[i])
                {
                    int coinsNeeded = amount / coinArray[i];
                    sumOfCoins += coinsNeeded;
                    amount -= coinsNeeded * coinArray[i];
                }
            }

            return sumOfCoins;
        }
    }
}