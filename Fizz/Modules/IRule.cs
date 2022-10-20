using System.Collections.Generic;

namespace Fizz.Modules
{
    public interface IRule
    {
        void AddElement(int number, IList<string> result);
    }
}