using DocumentFormat.OpenXml.Bibliography;
using Microsoft.KernelMemory;
using OpenTelemetry.Resources;
using System.Text.RegularExpressions;

namespace CaseManagementChatDemo.Utils
{
    public static class StringUtils
    {
        public static string RemoveInvalidCharacters(string value)
        {
            return value.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("/", "").Replace("\\", "").Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("?", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("+", "").Replace("=", "").Replace("<", "").Replace(">", "").Replace("|", "").Replace("`", "").Replace("~", "").Replace("'", "").Replace("\"", "");
        }


        public static string StripOuterParagraphTags(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Use a regular expression to remove the outer <p> and </p> tags, case-insensitive
            string pattern = @"^\s*<p>(.*?)<\/p>?\s*$";
            return Regex.Replace(input, pattern, "$1", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public static string CreateCitationHTML(Citation citation)
        {
            string citationResults = string.Empty;
            if (citation.SourceName.ToLower() != "content.url")
            {
                citationResults = "<span title=\"";
                foreach (var p in citation.Partitions)
                {
                    citationResults += $"({p.Relevance*100}): {p.Text} <br/><br/>"; 
                }
                citationResults += $"\">{citation.SourceName}</span>";
            }
            else
            {
                citationResults = $"<a href=\"{citation.SourceUrl}\" target=\"_blank\" title=\"";
                foreach (var p in citation.Partitions)
                {
                    citationResults += $"({p.Relevance * 100}): {p.Text} <br/><br/>";
                }
                citationResults += $"\">{citation.SourceName}</a>";

            }

            return citationResults;
        }
    }
}
