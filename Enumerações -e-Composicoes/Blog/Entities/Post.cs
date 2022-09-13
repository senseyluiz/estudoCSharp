using System;
using System.Collections.Generic;
using System.Text;


namespace Blog.Entities;

public class Post
{
  public DateTime Moment {get; set;}
  public string Title {get; set;}
  public string Content {get; set;}
  public int Likes {get; set;}
  public List<Coment> Coments {get; set;} = new List<Coment>();


  public Post()
  {

  }
  public Post(DateTime moment, string title, string content, int likes)
  {
    Moment = moment;
    Title = title;
    Content = content;
    Likes = likes;
  }

  public void AddComent(Coment coment)
  {
    Coments.Add(coment);
  }

  public void RemoveComent(Coment coment)
  {
    Coments.Remove(coment);
  }

  public override string ToString()
  {
    StringBuilder sb = new();

    sb.AppendLine(Title);
    sb.Append(Likes);
    sb.Append(" Like - ");
    sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
    sb.AppendLine(Content);
    sb.AppendLine("Comments: ");

    foreach (var coment in Coments)
    {
      sb.AppendLine(coment.Text);
    }

    return sb.ToString();
  }

}