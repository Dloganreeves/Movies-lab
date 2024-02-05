
using Movie_Database;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
bool runprogram = true;
Console.WriteLine("Welcome to the movie list application!");
List<Movie> movielist = new List<Movie>()
{
   new Movie ("Star Wars", "scifi"),
   new Movie ("Star Trek", "scifi"),
   new Movie ("Interstellar", "scifi"),
   new Movie ("Napoleon", "drama"),
   new Movie ("Queen", "drama"),
   new Movie ("A star is born", "drama"),
   new Movie ("Halloween", "horror"),
   new Movie ("Insidious", "horror"),
   new Movie ("Scream", "horror"),
   new Movie ("Howl's Moving Castle", "animated"),
   new Movie ("Spirited Away", "animated"),
   new Movie ("Ponyo", "animated")
};
Console.WriteLine($" There are {movielist.Count} movies");
while (runprogram)
{

    string choice;
    while (true)
    {
        Console.WriteLine("What category are you interest in:'scifi', 'drama', 'horror', or 'animated'?");
        choice = Console.ReadLine();
        if (choice == "scifi" || choice == "drama" || choice == "horror" || choice == "animated")
        {
            break;
        }
        else
        {
            Console.WriteLine("Please choose a valid category.");

        }
    }
    //for (int i = 0; i < movielist.Count; i++)
    //{
    //    if (choice == movielist[i].Category)
    //    {
    //        Console.WriteLine(movielist[i].Title);
    //    }
    //}

    List<Movie> sortedbycat = movielist.Where(movie => movie.Category.ToLower() == choice).ToList();
    sortedbycat.ForEach(movie => Console.WriteLine(movie.Title));
    while (true)
    {


        Console.WriteLine("Would you like to choose another category? y/n");
        string choice2 = Console.ReadLine().ToLower().Trim();
        if (choice2 == "y")
        {
            break;
        }

        else if (choice2 == "n")
        {
            runprogram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please choose only 'y' or 'n'");
        }
    }
}






