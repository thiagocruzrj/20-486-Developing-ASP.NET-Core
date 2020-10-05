namespace TUnidade
{
    public static class Util
    {
        public static bool PrimeiraLetraMaiuscula(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}