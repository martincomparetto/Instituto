namespace InstWeb
{
    public static class StringExtensions
    {
        public static bool TieneUnAsterisco(this string cadena)
        {
            return (cadena.Contains("*"));
        }
    }
}