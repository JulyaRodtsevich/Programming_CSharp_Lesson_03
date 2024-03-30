internal class Program
{
    private static void Main(string[] args)
    {
        // 123 + 321 = 444
        // 9999 + 9999 = 19998
        // 1234 + 432 = 1666

        Console.WriteLine("Enter the first number: ");
        string num1str = Console.ReadLine();
        int num1 = int.Parse(num1str);

        Console.WriteLine("Enter the second number: ");
        string num2str = Console.ReadLine();
        int num2 = int.Parse(num2str);

        int rank1 = rank(num1);
        int rank2 = rank(num2);
        int rank = (rank1 > rank2) ? rank1 : rank2; // Max
        rank += 1;
        int[] num1Array = new int[rank];
        int[] num2Array = new int[rank];
        for (int i = 0; i < rank; i++)
        {
            num1Array[i] = num1 % 10;
            num1 = num1 / 10;
            num2Array[i] = num2 % 10;
            num2 = num2 / 10; 
        }
        
        int[] resultArray = new int[rank];
        int carry = 0;
        for (int i = 0; i < rank; i++)
        {
            int sum = num1Array[i] + num2Array[i] + carry;
            resultArray[i] = sum % 10;
            carry = sum / 10;
        }

        string result = "";
        for (int i = resultArray.Length - 1; i >= 0; i--)
        {
            result += resultArray[i];
        }

        Console.WriteLine("The result is: " + result);
    }

    private int rank(int x)
    {
        int rank = 0;
        int temp = x;
        while (temp > 0)
        {
            rank++;
            temp = temp / 10;
        }
        return rank;
    }
}
