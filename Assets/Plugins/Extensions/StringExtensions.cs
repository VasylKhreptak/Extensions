using UnityEngine;

namespace Plugins.Extensions
{
    public static class StringExtensions
    {
        public static string WithColor(this string text, Color color) => $"<color={color}>{text}</color>";
    }
}