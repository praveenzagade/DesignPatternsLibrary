using AdapterPattern.ConsoleApp.Model;
using System.Collections.Generic;

namespace AdapterPattern.ConsoleApp.Library
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}
