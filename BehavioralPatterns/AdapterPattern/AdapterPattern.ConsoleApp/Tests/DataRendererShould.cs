using AdapterPattern.ConsoleApp.Library;
using AdapterPattern.ConsoleApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdapterPattern.ConsoleApp.Tests
{
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());
            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }

        [TestMethod]
        public void PatternRendererShould_RenderTwoPattern()
        {
            var myRenderer = new PatternRenderer();

            var myList = new List<Pattern>{
                new Pattern { Id = 1, Name = "", Description = "" },
                new Pattern { Id = 2, Name = "", Description = ""}
            };

            string result = myRenderer.ListPatterns(myList);
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count + 2, lineCount);
        }
    }
}
