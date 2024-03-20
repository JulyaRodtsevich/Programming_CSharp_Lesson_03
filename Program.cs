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

        int rank1 = 0;
        int temp1 = num1;
        while (temp1 > 0)
        {
            rank1++;
            temp1 = temp1 / 10;
        }

        int[] num1Array = new int[rank1];
        for (int i = 0; i < rank1; i++)
        {
            num1Array[i] = num1 % 10;
            num1 = num1 / 10;
        }

        int rank2 = 0;
        int temp2 = num2;
        while (temp2 > 0)
        {
            rank2++;
            temp2 = temp2 / 10;
        }

        int[] num2Array = new int[rank2];
        for (int i = 0; i < rank2; i++)
        {
            num2Array[i] = num2 % 10;
            num2 = num2 / 10;
        }


        int maxRank = num1Array.Length > num2Array.Length ? num1Array.Length : num2Array.Length;
        int[] resultArray = new int[maxRank];

        int carry = 0;
        for (int i = 0; i < maxRank; i++)
        {
            int sum = num1Array[i] + num2Array[i] + carry;
            resultArray[i] = sum % 10;
            carry = sum / 10;
        }

        if (carry > 0)
        {
            resultArray[maxRank] = carry;
        }

        string result = "";
        for (int i = resultArray.Length - 1; i >= 0; i--)
        {
            result += resultArray[i];
        }

        Console.WriteLine("The result is: " + result);
    }
}