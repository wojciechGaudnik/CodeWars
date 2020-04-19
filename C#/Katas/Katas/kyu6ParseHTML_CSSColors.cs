using System.Collections.Generic;

namespace Katas
{
    public class kyu6ParseHTML_CSSColors
    {
        private readonly IDictionary<string, string> presetColors;

        public kyu6ParseHTML_CSSColors(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public RGB Parse(string color)
        {
            if (presetColors.ContainsKey(color.ToLower())) color = presetColors[color.ToLower()];
            if (color.Length == 4) color = "#" + color[1] + color[1] + color[2] + color[2] + color[3] + color[3];
            if (color[0].Equals('#') && color.Length == 7)
            {
                return new RGB(
                    byte.Parse(color.Substring(1, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(3, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(5, 2), System.Globalization.NumberStyles.HexNumber));
            }
            return new RGB(50, 100, 255);
        }
    }
}

public struct RGB
{
    public byte r, g, b;
    public RGB(byte r, byte g, byte b)
    {
        this.r = r;
        this.g = g;
        this.b = b;

    }
}