namespace ClaimTheSquare;

public class TextObject
{
    public int Index {get;set;}
    public string Content {get;set;}
    public string BgColor {get;set;} = "white";
    public string FontColor {get;set;} = "black";



    public TextObject(int index, string content, string bgColor, string fontColor)
    {
        Index = index;
        Content = content;
        BgColor = bgColor;
        FontColor = fontColor;
        
    }
    
    public TextObject()
    {
        
    }
    
}

