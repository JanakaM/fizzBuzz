using System.Collections.Generic;
using System.Linq;
using Fizz;
using Fizz.Modules;
using Xunit;

namespace FizzTests2
{
    public class FizzTests
    {
        private readonly IEnumerable<IRule> rules;
        public FizzTests()
        {
            rules = new List<IRule>()
            {
                new RuleFizz(), new RuleBuzz(), new DefaultNumber(), new FizzBuzz()
            };
        }

        [Fact]
        public void Run_Fizz_printFizz()
        {
            var expectedFirstThirdNumbers = new List<string>() {"1", "2", "Fizz"};

            var fizz = new FizzGame(rules);

            var numbers = fizz.Play(); 
            
            Assert.Equal(expectedFirstThirdNumbers, numbers.Take(3));
        }
        
        [Fact]
        public void Run_Fizz_printBuzz()
        {
            var expectedFirstThirdNumbers = new List<string>() {"1", "2", "Fizz", "4", "Buzz"};

            var fizz = new FizzGame(rules);

            var numbers = fizz.Play(); 
            
            Assert.Equal(expectedFirstThirdNumbers, numbers.Take(5));
        }
        
        [Fact]
        public void Run_Fizz_printFizzBuzz()
        {
            var expected = "Fizz Buzz"; 

            var fizz = new FizzGame(rules);

            var numbers = fizz.Play(); 
            
            Assert.Equal(expected, numbers.Skip(14).First());
        }
    }
}