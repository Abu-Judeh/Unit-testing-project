using System.Globalization;

namespace String_Calculator;

public class StringCalculator
{
    public int add(string num)
    {
        
        if (string.IsNullOrEmpty(num))
        {
            return 0;
        }

        var delimiters = new List<char> { ',', '\n' };
        if(num.StartsWith("//"))
        {
            delimiters.Add(num[2]);
            num = num.Substring(4);
        }
        var numArray = num.Split(delimiters.ToArray());
        var negativeNum = numArray.Where(num => int.Parse(num) < 0).ToList();
        if (negativeNum.Any())
        {
            throw new Exception($"negatives not allowed: {string.Join(",", negativeNum)}");
        }
        return numArray.Where(num => int.Parse(num) <= 1000).Sum(num => int.Parse(num));
        
    }
}