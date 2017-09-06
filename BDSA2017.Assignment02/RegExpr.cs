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
            foreach (String k in lines)
            {
               
                foreach (Match m in Regex.Matches(k, pattern))
                {
                   
                        yield return m.Value;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var pattern = @"(?<Width>\d{2,5})x(?<Height>\d{2,5})";
            foreach(Match m in Regex.Matches(resolutions, pattern))
            {
                    yield return ((int.Parse(m.Groups["Width"].Value),int.Parse(m.Groups["Height"].Value)));
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
