using System;
using System.Collections.Generic;
using Xunit;


namespace BDSA2017.Assignment02.Tests
{
    public class IteratorsTests
    {
        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
   
    [Fact]
        public void Test_Flatten()
        {
            var test = new List<List<int>>();
            test.Add(new List<int>());
            test.Add(new List<int>());
            test[0].AddRange(new List<int>(){2,1,2,3});
            test[1].AddRange(new List<int>() { 2, 1, 2, 3 });
           
            
            Assert.Equal(new List<int> { 2, 1, 2, 3, 2, 1, 2, 3 },Helpers.Flatten(test));

        }

        [Fact]
        public void Test_Filter()
        {
            var test = new List<int>();
            test.AddRange(new List<int>() { 2, 1, 2, 3 ,0,50,2,1});
            Predicate<int> even = Even;


            Assert.Equal(new List<int> { 2,2,0,50,2 }, Helpers.Filter(test,even));

        }

    }
}
