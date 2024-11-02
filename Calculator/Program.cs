Console.WriteLine("Enter the operation (+/-)");
char userOperator = Char.Parse(Console.ReadLine());
Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());
switch (userOperator)
{
    case '+':
        Add(firstNum, secondNum);
        break;
    case '-':
        Subtract(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void Add(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}
static void Subtract(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}