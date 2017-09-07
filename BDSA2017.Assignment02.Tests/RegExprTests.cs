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


            Assert.Equal(new List<(int, int)>() { (19000, 0000), (222, 1900), (9000, 4500) }, RegExpr.Resolution(listen1));
        }

        [Fact]
        public void Test_InnerText()
        {
            var expected = new List<string> { "theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings" };
            var html = @"< p > A < b > regular expression </ b >, < b > regex </ b > or < b > regexp </ b > (sometimes called a<b>rational expression</ b >) is, in < a href = /wiki/Theoretical_computer_science title = Theoretical computer science > theoretical computer science</ a > and < a href = /wiki/Formal_language title = Formal language > formal language </ a > theory, a sequence of < a href = /wiki/Character_(computing) title = Character (computing) > characters </ a > that define a<i>search<a href= /wiki/Pattern_matching title= Pattern matching > pattern </ a ></ i >.Usually this pattern is then used by < a href = /wiki/String_searching_algorithm title = String searching algorithm > string searching algorithms</ a > for find or find and replace operations on < a href = /wiki/String_(computer_science) title = String (computer science) > strings </ a >.</ p >";
            Assert.Equal(expected, RegExpr.InnerText(html, "a"));
        }

        [Fact]
        public void Test_InnerTextTagNested()
        {
            var expected = new List<string> { "The phrase","regular expressions","(and consequently, regexes) is often used to mean the specific, standard textual syntax for representing","patterns","that matching", "text", "need to conform to." };
            var html = @"<div>
    <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>
</div> ";
            Assert.Equal(expected, RegExpr.InnerText(html, "p"));

        }
    }
}
