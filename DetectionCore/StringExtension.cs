using System;
using System.Text;

namespace DetectionCore
{
    internal static class StringExtension
    {
        public static bool TryGetInt(this string value, int startIndex, int length, out int result)
        {
            bool hasResult = false;
            int number = 0;
            int safedLength = Math.Min(length, value.Length - startIndex);
            foreach (char c in value.AsSpan(startIndex, safedLength))
            {
                if ('0' <= c && c <= '9')
                {
                    hasResult = true;
                    number = number * 10 + (c - '0');
                }
                else if (hasResult)
                {
                    break;
                }
            }
            result = number;
            return hasResult;
        }

        public static bool TryGetVersion(this string value, int startIndex, int length, out string result)
        {
            bool hasResult = false;
            int safedLength = Math.Min(length, value.Length - startIndex);
            var sb = new StringBuilder();
            foreach (char c in value.AsSpan(startIndex, safedLength))
            {
                if ('0' <= c && c <= '9')
                {
                    hasResult = true;
                    sb.Append(c);
                }
                else if (hasResult)
                {
                    if (c == '.' || c == '_')
                    {
                        sb.Append(c);
                        continue;
                    }
                    break;
                }
            }
            result = sb.ToString();
            return hasResult;
        }
    }
}
