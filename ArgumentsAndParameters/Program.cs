Console.WriteLine("Enter something");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);

static void PrintAnyWord(string anyString)
{
    anyString= anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}