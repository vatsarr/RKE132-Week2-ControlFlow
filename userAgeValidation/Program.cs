
Console.WriteLine("Hello, please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please insert your last name:");
string lastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Hello, Mr. {lastName}");
}
else if (userGender == 'm')
{
    Console.WriteLine($"Hello, Ms. {lastName}!");
}
else
{
    Console.WriteLine($"Welcome, {lastName}!");
};