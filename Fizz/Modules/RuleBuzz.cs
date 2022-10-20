using System.Collections.Generic;

namespace Fizz.Modules
{
    public class RuleBuzz : IRule
    {
        public void AddElement(int number, IList<string> result)
        {
            if (number % 3 != 0 && number % 5 == 0 )
                result.Add("Buzz");
        }
    }
}