namespace MatchingBrackets
{
    public class MatchingBrackets
    {
        public MatchingBrackets() { }

        public bool IsMatchingBrackets(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return true;

            const char openBrace = '{';
            const char closeBrace = '}';

            int openBracesCount = str.Count(s => s == openBrace);
            int closeBracesCount = str.Count(s => s == closeBrace);

            if (openBracesCount != closeBracesCount)
                return false;

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == openBrace) count++;
                if (str[i] == closeBrace) count--;
                if (count < 0) return false;
            }

            return count == 0;
        }
    }
}
