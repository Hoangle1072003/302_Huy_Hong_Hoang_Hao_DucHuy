using System;

namespace Lab6
{
    public class StringReplacement
    {
        public static string ThayThe(string s1, string s2, string s3)
        {
            if (s1 == null || s2 == null || s3 == null)
            {
                throw new ArgumentNullException("Một hoặc nhiều chuỗi bị null.");
            }

            if (s1 == "" && s2 == "" && s3 == "")
            {
                return "";
            }

            if (s2 == "")
            {
                return s1;
            }

            if (s3 == "")
            {
                return s1.Replace(s2, "");
            }

            return s1.Replace(s2, s3);
        }
    }
}
