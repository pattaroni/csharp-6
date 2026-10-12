using System;

public class UIElement
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }
    public bool IsEnabled { get; set; }

    public UIElement(int width, int height, string color, bool isEnabled)
    {
        Width = width;
        Height = height;
        Color = color;
        IsEnabled = isEnabled;
    }

    public virtual void Draw()
    {
        string state = "неактивний";
        if (IsEnabled)
        {
            state = "активний";
        }

        Console.WriteLine("Елемент " + Width + "x" + Height + ", колір: " + Color + ", стан: " + state);
    }
}
