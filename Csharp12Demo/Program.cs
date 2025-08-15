// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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


