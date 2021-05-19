using System;
using System.Text;

namespace FirstDay
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if(numbers.Length==0)
            {
                return 0;
            }
            if(!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
            }
        }

	    public string NoRepeat(string target,char ch)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != ch)
                    result.Append(target[i]);
            }
            return result.ToString();
        }
        public Boolean IsPrime(string s)
        {
            int n;
            bool b = int.TryParse(s, out n);

            if (b)
            {
                if (n < 2)
                    throw new InvalidOperationException("your number  is less than 2");
                else if (n > 1000)
                    throw new InvalidOperationException("your number  is too large");
                else if (n < 0)
                    throw new InvalidOperationException("your number  is negative");
                else
                {
                    int a = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            a++;
                        }
                    }
                    if (a == 2)
                    {
                        return true;
                    }
                    return false;
                }

            }
            else
                throw new InvalidOperationException("it is not integer");
        }
    }
}
