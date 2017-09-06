using System.Collections.Generic;
using Xunit;

namespace BDSA2017.Assignment02.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Test_WordSplit()
        {
            List<string> listen1 = new List<string>() { @"Hej Med \12313\...,", @".- Dig, Du Er ½+++<<<----       Sød" };


            Assert.Equal(new List<string> { "Hej", "Med", "12313", "Dig", "Du", "Er", "Sød" }, RegExpr.SplitLine(listen1));
        }

        [Fact]
        public void Test_Resolution()
        {
            var listen1 = "19000x0000 21dedad 21r1ead 222x1900 ,dsadsa, 9000x4500";


            Assert.Equal(new List<(int, int)>() {(19000,0000),(222,1900), (9000,4500) }, RegExpr.Resolution(listen1));
        }
    }
}
