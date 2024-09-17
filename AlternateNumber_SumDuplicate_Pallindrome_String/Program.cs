using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        NumbersProblem numbersProblem = new NumbersProblem();
        numbersProblem.AlterNumberFind();
        numbersProblem.RemoveDuplicateFromArray();
        Console.WriteLine(numbersProblem.CheckPallindrome());
        Console.ReadLine();
    }
}

public class NumbersProblem
{
    public void AlterNumberFind()
    {
        Console.WriteLine("Enter Input Number in integer limit");
        int number = Convert.ToInt32(Console.ReadLine());
        var str = number.ToString();
        StringBuilder strBuilder = new StringBuilder();
        int skip = 1;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            skip += 1;
            if (skip % 2 == 0)
            {
                strBuilder.Append(str[i]);
            }
        }

        int result = Convert.ToInt32(strBuilder.ToString());
        Console.WriteLine(result);
    }

    public void RemoveDuplicateFromArray()
    {
        int[] array = { 1, 1, 3, 3, 3, 5, 6, 2, 5 };
        int sum = 0;
        var filteredList = array.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => new
        {
            Key = x.Key,
            Count = x.Count()
        });

        foreach (var item in filteredList)
        {
            sum += item.Key * item.Count;
        }

        Console.WriteLine($"result is {sum}");
    }

    public string CheckPallindrome()
    {
        string strs = "Sandra loves pet dogs";
        string[] strArray = strs.Split(" ", StringSplitOptions.None);
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = strArray.Length; i > 0; i--)
        {
            string inputArrayString = strArray[i - 1].ToString();
            if (i != strArray.Length)
            {
                stringBuilder.Append(" ");
            }

            for (int j = inputArrayString.Length; j > 0; j--)
            {
                stringBuilder.Append(inputArrayString[j - 1]);
            }

        }

        string resultString = stringBuilder.ToString();
        return strs.Equals(resultString) ? "Pallindrome" : "Not Pallindrome";
    }
}