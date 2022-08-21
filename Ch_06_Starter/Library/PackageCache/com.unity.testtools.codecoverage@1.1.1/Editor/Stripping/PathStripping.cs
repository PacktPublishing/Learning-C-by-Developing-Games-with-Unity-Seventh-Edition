using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor.TestTools.CodeCoverage.Utils;

namespace UnityEditor.TestTools.CodeCoverage
{
    internal class PathStripping
    {      
        private Regex[] m_PathStrippingPatterns;
        private bool m_HasPathStrippingPatterns;

        public PathStripping()
        {
            m_PathStrippingPatterns = new Regex[] { };
        }

        public void Parse(string strippingPatterns)
        {
            string[] strippingPatternsArray = strippingPatterns.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            m_PathStrippingPatterns = strippingPatternsArray
                .Select(f => CreateFilterRegex(f))
                .ToArray();

            m_HasPathStrippingPatterns = m_PathStrippingPatterns.Length > 0;
        }

        public string StripPath(string path)
        {
            if (m_HasPathStrippingPatterns)
            {
                string newPath = CoverageUtils.NormaliseFolderSeparators(path);

                foreach (Regex strippingPattern in m_PathStrippingPatterns)
                {
                    Match match = strippingPattern.Match(newPath);
                    if (match.Success)
                        path = path.Replace(match.Value, "");
                }
            }

            return path;
        }

        Regex CreateFilterRegex(string filter)
        {
            filter = CoverageUtils.NormaliseFolderSeparators(filter);
          
            return new Regex(CoverageUtils.GlobToRegex(filter, false), RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }
    }
}
