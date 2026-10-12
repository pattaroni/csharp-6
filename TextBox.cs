using System;

public class TextBox : UIElement
{
    public int MaxLength { get; set; }
    public string Text { get; set; }

    public TextBox(int width, int height, string color, bool isEnabled, int maxLength)
        : base(width, height, color, isEnabled)
    {
        MaxLength = maxLength;
        Text = "";
    }

    public void EnterText(string text)
    {
        if (text.Length > MaxLength)
        {
            Console.WriteLine("Текст задовгий: максимум " + MaxLength + " символів");
        }
        else
        {
            Text = text;
            Console.WriteLine("У поле введено текст: " + Text);
        }
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("   Текстове поле, максимум " + MaxLength + " символів, вміст: «" + Text + "»");
    }
}
