using System;

public class Item
{
    public string Type { get; private set; }
    public string Color { get; private set; }
    public string Size { get; private set; }

    public Item(string type, string color, string size)
    {
        if (string.IsNullOrEmpty(type) || type.Length > 100)
        {
            throw new ArgumentException("Invalid type", nameof(type));
        }

        if (string.IsNullOrEmpty(color) || color.Length > 100)
        {
            throw new ArgumentException("Invalid color", nameof(color));
        }

        if (string.IsNullOrEmpty(size) || size.Length > 100)
        {
            throw new ArgumentException("Invalid size", nameof(size));
        }

        Type = type;
        Color = color;
        Size = size;
    }
}
