using System.Collections.Generic;

namespace Fizz.Modules
{
    public class RuleFizz : IRule
    {
        public void AddElement(int number, IList<string> result)
        {
            if (number % 5 != 0 && number % 3 == 0)
                result.Add("Fizz");
        }
    }
}