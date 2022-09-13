using Blog.Entities;

namespace Blog;
class Program
{
  static void Main(string[] args)
  {
    
   Coment coment1 = new("Have a nice trip");
   Coment coment2 = new("Wow that's awesome!");

    Post post1 = new Post( 
      DateTime.Parse("21/06/2018 13:05:44"),
      "Traveling to New Zealand",
      "I'm going to visit this wonderful country",
      12
      );

    post1.AddComent(coment1);
    post1.AddComent(coment2);

    Coment coment3 = new("Good night");
    Coment coment4 = new("May the Force be with you");

    Post post2 = new Post( 
      DateTime.Parse("28/07/2018 23:14:19"),
      "Good night guys",
      "See you tomorrow",
      5
      );

    post2.AddComent(coment3);
    post2.AddComent(coment4);

    Console.WriteLine(post1);
    Console.WriteLine(post2);

  }

}


