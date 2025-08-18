// See https://aka.ms/new-console-template for more information
using CSharp12Demo;
using System.Collections.Generic;
using Box = (int length, int breadth, int height);
using FeatureFilms = System.Collections.Generic.List<CSharp12Demo.FavMovie>;

Console.WriteLine("Hello, World!");

Console.WriteLine("Primary Constructors Demo");
PrintMovieDescription();
PrintMovieServiceDemo();
PrintCollectionsExpressionsDemo();
PrintInlineArrayDemo();
PrintOptionalLambdaExpressionDemo();
PrintAliasTupleDemo();
static void PrintMovieDescription()
{
    var movieExample = new Movie("Inception", new DateTime(2014, 11, 17), 9, "Christopher Nolan");
    Console.WriteLine(movieExample.GetDescription());

}
static void PrintMovieServiceDemo()
{
    IMovieRepository movieRepository = new MovieRepository();
    var movieService = new MovieService(movieRepository);
    var movies = movieService.GetAll().GetAwaiter().GetResult();
    foreach (var movie in movies)
    {
        Console.WriteLine(movie.GetDescription());
    }
    // Move the InlineArray attribute and struct definition outside of the PrintInlineArrayDemo method.
    // Remove the struct definition from inside the method.
}


static void PrintCollectionsExpressionsDemo()
{

    // Create an array:
    int[] arrOne = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    Console.WriteLine("Display arrOne - items: ");
    foreach (var item in arrOne)
    {
        Console.WriteLine(item);
    }


    // Create a span
    Span<char> spVowels = ['a', 'e', 'i', 'o', 'U'];
    Console.WriteLine("Display spVowels - items: ");
    foreach (var vowelItem in spVowels)
    {
        Console.WriteLine(vowelItem);
    }
    // Create a list:
    List<string> lstMovieParts = ["one", "two", "three"];

    Console.WriteLine("Display lstMovieParts - items: ");
    foreach (var individualMovie in lstMovieParts)
    {
        Console.WriteLine(individualMovie);
    }
    // Create a jagged 2D array:
    int[][] arrTwoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    Console.WriteLine("Display arrTwoD - items: ");
    foreach (var row in arrTwoD)
    {
        Console.WriteLine("new row in Jagged Array: ");
        foreach (var item in row)
        {
            Console.WriteLine(item);
        }
    }


    // Create a jagged 2D array from variables:
    Console.WriteLine("2D array from array variables demo :");
    int[] arrRowA = [1, 2, 3];
    int[] arrRowB = [4, 5, 6];
    int[] arrRowC = [7, 8, 9];
    int[][] arrJaggedTwoDfromVariables = [arrRowA, arrRowB, arrRowC];
    Console.WriteLine("Display arrJaggedTwoDfromVariables - items: ");
    foreach (var row in arrJaggedTwoDfromVariables)
    {
        Console.WriteLine("new row in Jagged Array: ");
        foreach (var item in row)
        {
            Console.WriteLine(item);
        }
    }

    // spread operator demo
    Console.WriteLine("Spread Operator demo : ");
    int[] fibSeriesOne = [0, 1, 1];
    int[] fibSeriesTwo = [2, 3, 5];
    int[] fibSeriesTwoThree = [8, 13, 21];
    int[] fibSeriesTwoFour = [34, 55, 89];


    int[] fibSeries = [.. fibSeriesOne, .. fibSeriesTwo, .. fibSeriesTwoThree, .. fibSeriesTwoFour];

    Console.WriteLine(" Display fibSeriesOne - items: ");
    foreach (var item in fibSeriesOne)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Display fibSeriesTwo - items: ");
    foreach (var item in fibSeriesTwo)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Display fibSeriesTwoThree - items: ");
    foreach (var item in fibSeriesTwoThree)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Display fibSeriesTwoFour - items: ");
    foreach (var item in fibSeriesTwoFour)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine(" Display fibSeries items, all arrays combined: ");
    foreach (var fibSeriesNo in fibSeries)
    {
        Console.Write($"{fibSeriesNo} ");
    }
    // output:
    // 0, 1, 1,2, 3, 5,8, 13, 21,34, 55, 89
}

static void PrintInlineArrayDemo()
{
    var inlineArr = new InlineArrayExample();

    for (int i = 0; i < 15; i++)
    {
        inlineArr[i] = i;
    }

    foreach (var individualItem in inlineArr)
    {
        Console.Write($"{individualItem} ");
    }
}

static void PrintOptionalLambdaExpressionDemo()
{
    //lambda exprression with single default parameter
    var defaultLambdaDemo = (int paramOne, int paramTwo = 1) => paramOne + paramTwo;

    Console.WriteLine(defaultLambdaDemo(18));
    Console.WriteLine(defaultLambdaDemo(18, 3));
    //lambda expression with multiple default parameter
    var defaultLambdaDemoAlt = (string paramOne, string paramTwo = "James",
        string paramThree = "Moriarty") => paramOne + " " +
        paramTwo + " " + paramThree;

    Console.WriteLine(defaultLambdaDemoAlt("Prof"));
    Console.WriteLine(defaultLambdaDemoAlt("Prof", "James"));
    Console.WriteLine(defaultLambdaDemoAlt("Sir", "Leigh", "Teabing"));
}

static void PrintAliasTupleDemo()
{
    // Alias a tuple type for container dimensions
    Box smallCargoContainer = (20, 4, 6);
    Console.WriteLine("Alias type: using Container = (int length, int breadth, int height);");
    Console.WriteLine($"Container Dimensions -> Length: {smallCargoContainer.length}, Breadth: {smallCargoContainer.breadth}, Height: {smallCargoContainer.height}");
}
static void PrintAliasGenericListDemo()
{
    // Alias a tuple type for container dimensions
    FeatureFilms GetGoodMovies()
    {
        List<CSharp12Demo.FavMovie> movies = new List<CSharp12Demo.FavMovie>
        {
            new CSharp12Demo.FavMovie
            {
            Name = "American History X",
            ReleaseDate = new DateTime(1998, 10, 30),
            Ratings = 8,
            Director = "Tony Kaye"
            },
            new CSharp12Demo.FavMovie
            {
                Name = "The Shawshank Redemption",
                ReleaseDate = new DateTime(1994, 9, 23),
                Ratings = 10,
                Director = "Frank Darabont"
            },
            new CSharp12Demo.FavMovie
            {
                Name = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24),
                Ratings = 10,
                Director = "Francis Ford Coppola"
            },
            new CSharp12Demo.FavMovie
            {
                Name = "The Dark Knight",
                ReleaseDate = new DateTime(2008, 7, 18),
                Ratings = 9,
                Director = "Christopher Nolan"
            },
            new CSharp12Demo.FavMovie
            {
                Name = "Hazaaron Khwaishein Aisi",
                ReleaseDate = new DateTime(2005, 4, 15),
                Ratings = 10,
                Director = "Sudhir Mishra"
            },
              new CSharp12Demo.FavMovie
            {
                Name = "Yeh Jawaani Hai Deewani",
                ReleaseDate = new DateTime(2013, 5, 31),
                Ratings = 7,
                Director = "Ayan Mukherjee"
            },
    };
        return movies;
    }
    Console.WriteLine("Alias type: Generic list demo");
    Console.WriteLine("Details of the Favourite movies are as follows: " + Environment.NewLine);

    //displaying the list of movies from FeatureFilms alias
    GetGoodMovies().ForEach(movie =>
    Console.WriteLine(nameof(movie.Name) + ": " + movie.Name + " "
    + nameof(movie.Director) + ": " + movie.Director + " "
    + nameof(movie.ReleaseDate) + ": " + movie.ReleaseDate.ToString("dd-MMMM-yyyy") + " "
    + nameof(movie.Ratings) + ": " + movie.Ratings + " "
    + Environment.NewLine)
    );
   
}

Console.ReadKey();





