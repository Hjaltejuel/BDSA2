using System;
using System.Collections.Generic;
using Xunit;


namespace BDSA2017.Assignment02.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Test_Flatten()
        {
            var listOfLists = new List<List<int>>
            {
                new List<int>() { 2, 1, 2, 3 },
                new List<int>() { 4, 5, 4, 6 }
            };

            Assert.Equal(new List<int> { 2, 1, 2, 3, 4, 5, 4, 6 }, Helpers.Flatten(listOfLists));
        }

        [Fact]
        public void Test_Filter()
        {
            var list = new List<int> { 2, 1, 2, 3, 0, 50, 2, 1 };

            Assert.Equal(new List<int> { 2, 2, 0, 50, 2 }, Helpers.Filter(list, (i) => i % 2 == 0));
        }

    }
}
