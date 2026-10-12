using System;

public class Button : UIElement
{
    public string Text { get; set; }

    public Button(int width, int height, string color, bool isEnabled, string text)
        : base(width, height, color, isEnabled)
    {
        Text = text;
    }

    public void Click()
    {
        if (IsEnabled)
        {
            Console.WriteLine("Кнопку «" + Text + "» натиснуто");
        }
        else
        {
            Console.WriteLine("Кнопка «" + Text + "» неактивна, натиснути не можна");
        }
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("   Кнопка з написом «" + Text + "»");
    }
}
