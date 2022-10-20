using System.Collections.Generic;
using Fizz.Modules;

namespace Fizz
{
    public class FizzGame
    {
        private readonly IEnumerable<IRule>  _rules;

        public FizzGame(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public List<string> Play()
        {
            var numbers = new List<string>();

            for (var i = 1; i <= 100; i++)
            {
                foreach (var rule in _rules)
                {
                    rule.AddElement(i, numbers);
                }
            }
            
            return numbers;
        }
    }
}