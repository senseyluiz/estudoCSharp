namespace Blog.Entities;
public class Coment
{
  public string Text {get; set;}

  public Coment()
  {
  }

  public Coment(string text)
  {
    Text = text;
  }
}