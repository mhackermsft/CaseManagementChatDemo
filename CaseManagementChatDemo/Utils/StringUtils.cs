namespace CaseManagementChatDemo.Utils
{
    public static class StringUtils
    {
        public static string RemoveInvalidCharacters(string value)
        {
            return value.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace(",", "").Replace(";", "").Replace(":", "").Replace("/", "").Replace("\\", "").Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("?", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("+", "").Replace("=", "").Replace("<", "").Replace(">", "").Replace("|", "").Replace("`", "").Replace("~", "").Replace("'", "").Replace("\"", "");
        }
    }
}
