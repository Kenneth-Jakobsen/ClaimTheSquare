namespace ClaimTheSquare;

public class TextObject
{
    public int Index { get; set; }
    public string Content { get; set; }
    public string BgColor { get; set; }
    public string FColor { get; set; }


    public TextObject(int index, string content, string bgColor, string fColor)
    {
        Index = index;
        Content = content;
        BgColor = bgColor;
        FColor = fColor;
    }

    public TextObject()
    {
    }
}