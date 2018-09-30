using AdapterPattern.ConsoleApp.Model;
using System.Collections.Generic;

namespace AdapterPattern.ConsoleApp.Library
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter _dataPatternRendererAdapter;

        public PatternRenderer() : this(new DataPatternRendererAdapter())
        {

        }

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRendererAdapter)
        {
            _dataPatternRendererAdapter = dataPatternRendererAdapter;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            //return patterns.ToString();
            return _dataPatternRendererAdapter.ListPatterns(patterns);
        }
    }
}
