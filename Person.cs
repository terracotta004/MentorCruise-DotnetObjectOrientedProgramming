namespace DotnetMentorshipAssignment2;

public class Person
{
    public string? Name;
    public int Age;
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
    public void CelebrateBirthday()
    {
        Age++;
        Console.WriteLine($"Happy birthday! You are now {Age} years old.");
    }
}
