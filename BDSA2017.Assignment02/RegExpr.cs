using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2017.Assignment02
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            String pattern = @"[a-zA-Z\dÆØÅæøå]+"; ;
            foreach (String line in lines)
            {               
                foreach (Match match in Regex.Matches(line, pattern))
                {                   
                    yield return match.Value;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var pattern = @"(?<Width>\d{2,5})x(?<Height>\d{2,5})";
            foreach(Match match in Regex.Matches(resolutions, pattern))
            {
                yield return ((int.Parse(match.Groups["Width"].Value), int.Parse(match.Groups["Height"].Value)));
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var filter1 = $@"<\s*({tag}).*?(?<first>>.*?<)\s*\/\s*\1\s*>";
            var filter2 = @">\s*(?<second>.*?)\s*<";
            foreach (Match match1 in Regex.Matches(html, filter1))
            {
                foreach (Match match2 in Regex.Matches(match1.Groups["first"].Value, filter2))
                {
                    yield return match2.Groups["second"].Value;
                }
            }

        }
    }
}
