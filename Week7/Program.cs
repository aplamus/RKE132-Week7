Console.WriteLine("aRE You coming or leaving?(in/out)");
string userChoice = Console.ReadLine();
if (userChoice != "in")
{
    PrintHello();
}
else
{
    printGoodBye();
}


PrintHello();
printGoodBye();

static void PrintHello()
{
    Console.WriteLine("Hello world");
}

static void printGoodBye()
{
    Console.WriteLine("Cya");
}