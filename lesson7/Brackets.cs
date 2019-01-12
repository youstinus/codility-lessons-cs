namespace lesson7
{
    // 25%
    class Brackets
    {
        public int Solution(string S)
        {
            int finals = 0;
            if (string.IsNullOrWhiteSpace(S))
                finals = 1;

            if (finals != 1 && S.Length > 1 && (S[S.Length - 2] == '(' && S[S.Length - 1] == ')'
                                                || S[S.Length - 2] == '[' && S[S.Length - 1] == ']'
                                                || S[S.Length - 2] == '{' && S[S.Length - 1] == '}'))
            {
                finals = Solution(S.Substring(0, S.Length - 2));
            }
            if (finals != 1 && S.Length > 1 && (S[0] == '(' && S[1] == ')'
                                                || S[0] == '[' && S[1] == ']'
                                                || S[0] == '{' && S[1] == '}'))
            {
                finals = Solution(S.Substring(2));
            }
            if (finals != 1 && S.Length > 1 && (S[0] == '(' && S[S.Length - 1] == ')'
                                                || S[0] == '[' && S[S.Length - 1] == ']'
                                                || S[0] == '{' && S[S.Length - 1] == '}'))
            {
                finals = Solution(S.Substring(1, S.Length - 2));
            }

            return finals;
        }
    }
}
