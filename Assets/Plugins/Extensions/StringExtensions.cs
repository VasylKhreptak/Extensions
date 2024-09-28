namespace Plugins.Extensions
{
    public static class StringExtensions
    {
        public static string WithColor(this string text, string color) => $"<color={color}>{text}</color>";
    }
}